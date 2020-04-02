using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace HowCanPams
{
    public partial class HowCanPams : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        /// Handling the window messages
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT) message.Result = (IntPtr)HTCAPTION;
        }

        int dbug;
        #region global variable

        const byte IDLE = 0;
        const byte HEADER_START = 1;
        const byte HEADER_M = 2;
        const byte HEADER_ARROW = 3;
        const byte HEADER_SIZE = 4;
        const byte HEADER_CMD = 5;
        const byte HEADER_ERR = 6;

        static byte sendTask;
        static byte[] inBuf;
        static byte c_state = IDLE;
        static byte offset = 0;
        static byte dataSize = 0;
        static byte checksum = 0;
        static byte cmd;
        static int serial_error_count = 0;
        static int serial_packet_count = 0;

        static SerialPort _serialPort;

        static data_gui gui;

        static double GPSMouseLat, GPSMouseLon;
        static float TargetSA;

        static bool headingType = true;
        #endregion

        public HowCanPams()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inBuf = new byte[300];   //init input buffer

            //Init serial port object
            _serialPort = new SerialPort();
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.DtrEnable = false;
            _serialPort.ReadBufferSize = 4096; // 4KB read buffer
            _serialPort.ReadTimeout = 500;     // 500msec timeout;

            gui = new data_gui();

            enumerateSerialPort();

            // Initialize map:
            //gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            //gmap.MinZoom = 0;
            //gmap.MaxZoom = 24;
            //gmap.SetPositionByKeywords("Maputo, Mozambique");
            //gmap.Position = new PointLatLng(-7.971684, 100.589759);
            //gmap.Manager.Mode = AccessMode.CacheOnly;
            //GPSMouseLat = 0;
            //GPSMouseLon = 0;
        }

        private void bkgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            byte c;
            BackgroundWorker bw = sender as BackgroundWorker;

            while (!bw.CancellationPending)                // backgroundworker runs continously
            {
                if (_serialPort.IsOpen)
                {
                    while (_serialPort.BytesToRead > 0)
                    {
                        c = (byte)_serialPort.ReadByte();
                        switch (c_state)
                        {
                            case IDLE: c_state = (c == '$') ? HEADER_START : IDLE; break;
                            case HEADER_START: c_state = (c == 'M') ? HEADER_M : IDLE; break;
                            case HEADER_M: c_state = (c == '>') ? HEADER_ARROW : IDLE; break;
                            case HEADER_ARROW: dataSize = c;
                                offset = 0;
                                checksum = 0; checksum ^= c;
                                c_state = (dataSize <= 100) ? HEADER_SIZE : IDLE; break;
                            case HEADER_SIZE: cmd = c;
                                checksum ^= c;
                                c_state = HEADER_CMD; break;
                            case HEADER_CMD:
                                if (offset < dataSize)
                                { //Proses mengamankan data
                                    checksum ^= c;
                                    inBuf[offset++] = c;
                                }
                                else
                                {
                                    if (checksum == c)
                                    {
                                        serial_packet_count++;
                                        evaluateCommand(cmd);
                                    }
                                    else serial_error_count++;
                                    c_state = IDLE;
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void evaluateCommand(Byte typeData)
        {
            byte ptr;
            switch (typeData)
            {
                case 65:
                    ptr = 0;
                    gui.GPS_FIX = inBuf[ptr]; ptr++;
                    gui.GPS_numSat = inBuf[ptr]; ptr++;
                    gui.GPS_LAT = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                    gui.GPS_LON = BitConverter.ToInt32(inBuf, ptr); ptr += 4;
                    gui.GPS_altitude = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.GPS_speed = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.GPS_ground_course = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case 66:
                    ptr = 0;
                    gui.angx = (float)BitConverter.ToInt32(inBuf, ptr) / 1000; ptr += 4;
                    gui.angy = (float)BitConverter.ToInt32(inBuf, ptr) / 1000; ptr += 4;
                    gui.heading = (float)BitConverter.ToInt32(inBuf, ptr) / 1000; ptr += 4; if (gui.heading < 0) gui.heading += 360;
                    gui.ax = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.ay = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.az = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.gx = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.gy = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.gz = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.magx = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.magy = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    gui.magz = BitConverter.ToInt16(inBuf, ptr); ptr += 2;
                    break;
                case 67: ptr = 0; break;
                case 68: ptr = 0; break;
                case 69: ptr = 0; break;
                case 70:
                    ptr = 0;
                    if ((int)(float.Parse(txtTargetSA.Text) * 1000) == BitConverter.ToInt32(inBuf, ptr)) TargetSA = (float)BitConverter.ToUInt32(inBuf, ptr) / 1000;
                    ptr += 4;
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_serialPort.BytesToRead == 0)
            {
                switch (sendTask++ % 2)
                {
                    case 0: reqData(65); break;
                    case 1: reqData(66); break;
                }
            }
            updateGUI();
        }

        private void updateGUI()
        {
            lblAccX.Text = "" + Math.Round((float)gui.ax / 2048, 2);
            lblAccY.Text = "" + Math.Round((float)gui.ay / 2048, 2);
            lblAccZ.Text = "" + Math.Round((float)gui.az / 2048, 2);
            lblGyroX.Text = "" + Math.Round((float)gui.gx / 16.4, 2);
            lblGyroY.Text = "" + Math.Round((float)gui.gy / 16.4, 2);
            lblGyroZ.Text = "" + Math.Round((float)gui.gz / 16.4, 2);
            lblMagnX.Text = "" + (float)gui.magx * 0.92;
            lblMagnY.Text = "" + (float)gui.magy * 0.92;
            lblMagnZ.Text = "" + (float)gui.magz * 0.92;
            lblRol.Text = "" + Math.Round(gui.angx, 1);
            lblPit.Text = "" + Math.Round(gui.angy, 1);
            lblYaw.Text = "" + Math.Round(gui.heading, 1);
            lblRolPrb.Text = "" + Math.Round(gui.angx * 17.777, 0);
            lblPitPrb.Text = "" + Math.Round(gui.angy * 17.777, 0);
            lblYawPrb.Text = "" + Math.Round(gui.heading * 17.777, 0);

            lblGPSFix.Text = "" + gui.GPS_FIX;
            lblNumSat.Text = "" + gui.GPS_numSat;
            lblGPSLat.Text = "" + gui.GPS_LAT;
            lblGPSLon.Text = "" + gui.GPS_LON;
            lblGPSAlt.Text = "" + gui.GPS_altitude;
            //lblGPSFix.Text = "" + gui.GPS_speed;
            //lblGPSFix.Text = "" + gui.GPS_ground_course;
            headingIndicator.SetHeadingIndicatorParameters(gui.heading, headingType);
            pitchIndicator.SetPitchIndicatorParameters(gui.angy, TargetSA);

            textBox1.Text = "" + dbug;
        }

        private void reqData(byte typeData)
        {
            byte c = 0;
            byte[] o = new byte[10];
            o[0] = (byte)'$';
            o[1] = (byte)'M';
            o[2] = (byte)'<';
            o[3] = (byte)0; c ^= o[3];       //no payload 
            o[4] = (byte)typeData; c ^= o[4];
            o[5] = (byte)c;
            _serialPort.Write(o, 0, 6);
        }

        private void sndData(byte typeData, byte lengthData, byte[] dataSend)
        {
            uint i = 0;
            byte c = 0;
            byte[] o = new byte[10];
            o[0] = (byte)'$';
            o[1] = (byte)'M';
            o[2] = (byte)'<';
            o[3] = (byte)lengthData; c ^= o[3];       //panjang payload 
            o[4] = (byte)typeData;  c ^= o[4];
            for (i = 0; i < lengthData; i++) { o[i + 5] = (byte)dataSend[i]; c ^= o[i + 5]; }
            o[i + 5] = (byte)c;
            _serialPort.Write(o, 0, lengthData + 6);
        }

        private void cmdSerialOpen_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen) {
                _serialPort.Close();
                Timer.Stop();
                bkgWorker.CancelAsync();
                cmdSerialOpen.Text = "Connect";
            } else {
                _serialPort.PortName = cbbPortName.Text;
                _serialPort.BaudRate = int.Parse(cbbSerialBaud.Text);
                _serialPort.Open();
                Timer.Start();
                if (!bkgWorker.IsBusy) { bkgWorker.RunWorkerAsync(); }
                cmdSerialOpen.Text = "Disconnect";
            }
        }

        private void cbbPortName_DropDown(object sender, System.EventArgs e) { enumerateSerialPort(); }

        private void enumerateSerialPort()
        {
            cmdSerialOpen.Enabled = true;
            cbbPortName.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) cbbPortName.Items.Add(port);
            //if prefered port is not available then select the first one 
            if (cbbPortName.Text == "" && cbbPortName.Items.Count > 0)  cbbPortName.SelectedIndex = 0;
            if (cbbPortName.Items.Count == 0) cmdSerialOpen.Enabled = false;
        }

        private void gmap_MouseMove(object sender, MouseEventArgs e)
        {
            GPSMouseLat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
            GPSMouseLon = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            gmapCoor.Text = "{ " + GPSMouseLat + " - " + GPSMouseLon + " }";
        }

        private void gmap_MouseUp(object sender, MouseEventArgs e)
        {

            gmap.Position = new PointLatLng(GPSMouseLat, GPSMouseLon);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(gmap.Position, GMarkerGoogleType.orange_dot);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            gmap.Position = new PointLatLng(GPSMouseLat, GPSMouseLon);
        }

        private void btnCalibA_Click(object sender, EventArgs e) { reqData(67); }
        private void btnCalibG_Click(object sender, EventArgs e) { reqData(68); }
        private void btnCalibM_Click(object sender, EventArgs e) { reqData(69); }

        private void btnTargetSA_Click(object sender, EventArgs e)
        {
            byte[] o = BitConverter.GetBytes((int)(float.Parse(txtTargetSA.Text) * 1000));
            sndData(70, 4, o);
        }

        private void txtTargetSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && txtTargetSA.Text.IndexOf('.') > -1) e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void btnHeadingNorm_Click(object sender, EventArgs e) { headingType = true; }
        private void btnHeadingMile_Click(object sender, EventArgs e) { headingType = false; }


    }
}
