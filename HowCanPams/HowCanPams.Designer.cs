namespace HowCanPams
{
    partial class HowCanPams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowCanPams));
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cmdSerialOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblPit = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblAccY = new System.Windows.Forms.Label();
            this.lblAccZ = new System.Windows.Forms.Label();
            this.lblAccX = new System.Windows.Forms.Label();
            this.lblGyroY = new System.Windows.Forms.Label();
            this.lblGyroX = new System.Windows.Forms.Label();
            this.lblGyroZ = new System.Windows.Forms.Label();
            this.lblMagnZ = new System.Windows.Forms.Label();
            this.lblGPSLat = new System.Windows.Forms.Label();
            this.lblGPSLon = new System.Windows.Forms.Label();
            this.lblNumSat = new System.Windows.Forms.Label();
            this.lblGPSFix = new System.Windows.Forms.Label();
            this.lblGPSAlt = new System.Windows.Forms.Label();
            this.lblPitPrb = new System.Windows.Forms.Label();
            this.lblRolPrb = new System.Windows.Forms.Label();
            this.lblYawPrb = new System.Windows.Forms.Label();
            this.gmapCoor = new System.Windows.Forms.Label();
            this.lblMagnY = new System.Windows.Forms.Label();
            this.lblMagnX = new System.Windows.Forms.Label();
            this.cbbPortName = new System.Windows.Forms.ComboBox();
            this.cbbSerialBaud = new System.Windows.Forms.ComboBox();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnCalibA = new System.Windows.Forms.Button();
            this.btnCalibM = new System.Windows.Forms.Button();
            this.btnCalibG = new System.Windows.Forms.Button();
            this.txtTargetSA = new System.Windows.Forms.TextBox();
            this.btnTargetSA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.headingIndicator = new HowCanPamsControls.HeadingIndicator();
            this.btnHeadingMile = new System.Windows.Forms.Button();
            this.btnHeadingNorm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pitchIndicator = new HowCanPamsControls.PitchIndicator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // bkgWorker
            // 
            this.bkgWorker.WorkerSupportsCancellation = true;
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cmdSerialOpen
            // 
            this.cmdSerialOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSerialOpen.ForeColor = System.Drawing.Color.Black;
            this.cmdSerialOpen.Location = new System.Drawing.Point(667, 14);
            this.cmdSerialOpen.Name = "cmdSerialOpen";
            this.cmdSerialOpen.Size = new System.Drawing.Size(120, 31);
            this.cmdSerialOpen.TabIndex = 1;
            this.cmdSerialOpen.Text = "Connect";
            this.cmdSerialOpen.UseVisualStyleBackColor = true;
            this.cmdSerialOpen.Click += new System.EventHandler(this.cmdSerialOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(155, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(310, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(310, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(310, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "GPS FIX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Jumlah Satelit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Lintang";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Bujur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ketinggian";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 763);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Koordinat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Accelerometer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(155, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Gyroscope";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(10, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Kemiringan";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(10, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 20);
            this.label19.TabIndex = 7;
            this.label19.Text = "SA";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(10, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "SPS";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(170, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "°  =";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(170, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 20);
            this.label22.TabIndex = 7;
            this.label22.Text = "°  =";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(170, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "°  =";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(280, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 20);
            this.label24.TabIndex = 7;
            this.label24.Text = "₥";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(280, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 20);
            this.label25.TabIndex = 7;
            this.label25.Text = "₥";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(280, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(22, 20);
            this.label26.TabIndex = 7;
            this.label26.Text = "₥";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(310, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 20);
            this.label27.TabIndex = 7;
            this.label27.Text = "Magnetometer";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(108, 95);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(22, 20);
            this.label28.TabIndex = 7;
            this.label28.Text = "G";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(108, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 20);
            this.label29.TabIndex = 7;
            this.label29.Text = "G";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(108, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(22, 20);
            this.label30.TabIndex = 7;
            this.label30.Text = "G";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(248, 35);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 20);
            this.label31.TabIndex = 7;
            this.label31.Text = "°/s";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(248, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 20);
            this.label32.TabIndex = 7;
            this.label32.Text = "°/s";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(248, 95);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 20);
            this.label33.TabIndex = 7;
            this.label33.Text = "°/s";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(411, 95);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(78, 20);
            this.label34.TabIndex = 7;
            this.label34.Text = "miliGauss";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(411, 65);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 20);
            this.label35.TabIndex = 7;
            this.label35.Text = "miliGauss";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(411, 35);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(78, 20);
            this.label36.TabIndex = 7;
            this.label36.Text = "miliGauss";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.DarkGray;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(329, 201);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 35);
            this.label37.TabIndex = 12;
            this.label37.Text = "Sudut Pengarah Sasaran";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Black;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(412, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 20);
            this.label38.TabIndex = 7;
            this.label38.Text = "Target";
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.DarkGray;
            this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(8, 201);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(125, 20);
            this.label39.TabIndex = 12;
            this.label39.Text = "Perilaku Meriam";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.DarkGray;
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(8, 32);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(125, 20);
            this.label40.TabIndex = 12;
            this.label40.Text = "Sistem Sensorik";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.DarkGray;
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(8, 403);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 20);
            this.label41.TabIndex = 12;
            this.label41.Text = "Sudut Arah";
            // 
            // lblPit
            // 
            this.lblPit.BackColor = System.Drawing.Color.Black;
            this.lblPit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPit.ForeColor = System.Drawing.Color.White;
            this.lblPit.Location = new System.Drawing.Point(105, 45);
            this.lblPit.Name = "lblPit";
            this.lblPit.Size = new System.Drawing.Size(61, 22);
            this.lblPit.TabIndex = 7;
            this.lblPit.Text = "000";
            this.lblPit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.Black;
            this.lblRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(105, 20);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(61, 22);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "000";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYaw
            // 
            this.lblYaw.BackColor = System.Drawing.Color.Black;
            this.lblYaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaw.ForeColor = System.Drawing.Color.White;
            this.lblYaw.Location = new System.Drawing.Point(105, 70);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(61, 22);
            this.lblYaw.TabIndex = 7;
            this.lblYaw.Text = "000";
            this.lblYaw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccY
            // 
            this.lblAccY.BackColor = System.Drawing.Color.Black;
            this.lblAccY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccY.ForeColor = System.Drawing.Color.White;
            this.lblAccY.Location = new System.Drawing.Point(45, 65);
            this.lblAccY.Name = "lblAccY";
            this.lblAccY.Size = new System.Drawing.Size(65, 20);
            this.lblAccY.TabIndex = 7;
            this.lblAccY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccZ
            // 
            this.lblAccZ.BackColor = System.Drawing.Color.Black;
            this.lblAccZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccZ.ForeColor = System.Drawing.Color.White;
            this.lblAccZ.Location = new System.Drawing.Point(45, 95);
            this.lblAccZ.Name = "lblAccZ";
            this.lblAccZ.Size = new System.Drawing.Size(65, 20);
            this.lblAccZ.TabIndex = 7;
            this.lblAccZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccX
            // 
            this.lblAccX.BackColor = System.Drawing.Color.Black;
            this.lblAccX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccX.ForeColor = System.Drawing.Color.White;
            this.lblAccX.Location = new System.Drawing.Point(45, 35);
            this.lblAccX.Name = "lblAccX";
            this.lblAccX.Size = new System.Drawing.Size(65, 20);
            this.lblAccX.TabIndex = 7;
            this.lblAccX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGyroY
            // 
            this.lblGyroY.BackColor = System.Drawing.Color.Black;
            this.lblGyroY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGyroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGyroY.ForeColor = System.Drawing.Color.White;
            this.lblGyroY.Location = new System.Drawing.Point(185, 65);
            this.lblGyroY.Name = "lblGyroY";
            this.lblGyroY.Size = new System.Drawing.Size(65, 20);
            this.lblGyroY.TabIndex = 7;
            this.lblGyroY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGyroX
            // 
            this.lblGyroX.BackColor = System.Drawing.Color.Black;
            this.lblGyroX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGyroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGyroX.ForeColor = System.Drawing.Color.White;
            this.lblGyroX.Location = new System.Drawing.Point(185, 35);
            this.lblGyroX.Name = "lblGyroX";
            this.lblGyroX.Size = new System.Drawing.Size(65, 20);
            this.lblGyroX.TabIndex = 7;
            this.lblGyroX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGyroZ
            // 
            this.lblGyroZ.BackColor = System.Drawing.Color.Black;
            this.lblGyroZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGyroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGyroZ.ForeColor = System.Drawing.Color.White;
            this.lblGyroZ.Location = new System.Drawing.Point(185, 95);
            this.lblGyroZ.Name = "lblGyroZ";
            this.lblGyroZ.Size = new System.Drawing.Size(65, 20);
            this.lblGyroZ.TabIndex = 7;
            this.lblGyroZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMagnZ
            // 
            this.lblMagnZ.BackColor = System.Drawing.Color.Black;
            this.lblMagnZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagnZ.ForeColor = System.Drawing.Color.White;
            this.lblMagnZ.Location = new System.Drawing.Point(340, 95);
            this.lblMagnZ.Name = "lblMagnZ";
            this.lblMagnZ.Size = new System.Drawing.Size(65, 20);
            this.lblMagnZ.TabIndex = 7;
            this.lblMagnZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGPSLat
            // 
            this.lblGPSLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLat.Location = new System.Drawing.Point(75, 135);
            this.lblGPSLat.Name = "lblGPSLat";
            this.lblGPSLat.Size = new System.Drawing.Size(175, 15);
            this.lblGPSLat.TabIndex = 8;
            this.lblGPSLat.Text = "XXX.XXXXXXXXXX";
            this.lblGPSLat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGPSLon
            // 
            this.lblGPSLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSLon.Location = new System.Drawing.Point(75, 150);
            this.lblGPSLon.Name = "lblGPSLon";
            this.lblGPSLon.Size = new System.Drawing.Size(175, 15);
            this.lblGPSLon.TabIndex = 8;
            this.lblGPSLon.Text = "XXX.XXXXXXXXXX";
            this.lblGPSLon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumSat
            // 
            this.lblNumSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSat.Location = new System.Drawing.Point(100, 120);
            this.lblNumSat.Name = "lblNumSat";
            this.lblNumSat.Size = new System.Drawing.Size(150, 15);
            this.lblNumSat.TabIndex = 8;
            this.lblNumSat.Text = "XXX";
            this.lblNumSat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGPSFix
            // 
            this.lblGPSFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSFix.Location = new System.Drawing.Point(100, 105);
            this.lblGPSFix.Name = "lblGPSFix";
            this.lblGPSFix.Size = new System.Drawing.Size(150, 15);
            this.lblGPSFix.TabIndex = 8;
            this.lblGPSFix.Text = "XXX";
            this.lblGPSFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGPSAlt
            // 
            this.lblGPSAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSAlt.Location = new System.Drawing.Point(75, 165);
            this.lblGPSAlt.Name = "lblGPSAlt";
            this.lblGPSAlt.Size = new System.Drawing.Size(175, 15);
            this.lblGPSAlt.TabIndex = 8;
            this.lblGPSAlt.Text = "XXX.XXXXXXXXXX";
            this.lblGPSAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPitPrb
            // 
            this.lblPitPrb.BackColor = System.Drawing.Color.Black;
            this.lblPitPrb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPitPrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitPrb.ForeColor = System.Drawing.Color.White;
            this.lblPitPrb.Location = new System.Drawing.Point(205, 45);
            this.lblPitPrb.Name = "lblPitPrb";
            this.lblPitPrb.Size = new System.Drawing.Size(72, 22);
            this.lblPitPrb.TabIndex = 7;
            this.lblPitPrb.Text = "000";
            this.lblPitPrb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRolPrb
            // 
            this.lblRolPrb.BackColor = System.Drawing.Color.Black;
            this.lblRolPrb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRolPrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolPrb.ForeColor = System.Drawing.Color.White;
            this.lblRolPrb.Location = new System.Drawing.Point(205, 20);
            this.lblRolPrb.Name = "lblRolPrb";
            this.lblRolPrb.Size = new System.Drawing.Size(72, 22);
            this.lblRolPrb.TabIndex = 7;
            this.lblRolPrb.Text = "000";
            this.lblRolPrb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYawPrb
            // 
            this.lblYawPrb.BackColor = System.Drawing.Color.Black;
            this.lblYawPrb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYawPrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYawPrb.ForeColor = System.Drawing.Color.White;
            this.lblYawPrb.Location = new System.Drawing.Point(205, 70);
            this.lblYawPrb.Name = "lblYawPrb";
            this.lblYawPrb.Size = new System.Drawing.Size(72, 22);
            this.lblYawPrb.TabIndex = 7;
            this.lblYawPrb.Text = "000";
            this.lblYawPrb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gmapCoor
            // 
            this.gmapCoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmapCoor.Location = new System.Drawing.Point(581, 763);
            this.gmapCoor.Name = "gmapCoor";
            this.gmapCoor.Size = new System.Drawing.Size(200, 13);
            this.gmapCoor.TabIndex = 8;
            this.gmapCoor.Text = "{ XXX.XXXXXXXX , XXX.XXXXXXXX }";
            this.gmapCoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMagnY
            // 
            this.lblMagnY.BackColor = System.Drawing.Color.Black;
            this.lblMagnY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagnY.ForeColor = System.Drawing.Color.White;
            this.lblMagnY.Location = new System.Drawing.Point(340, 65);
            this.lblMagnY.Name = "lblMagnY";
            this.lblMagnY.Size = new System.Drawing.Size(65, 20);
            this.lblMagnY.TabIndex = 7;
            this.lblMagnY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMagnX
            // 
            this.lblMagnX.BackColor = System.Drawing.Color.Black;
            this.lblMagnX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagnX.ForeColor = System.Drawing.Color.White;
            this.lblMagnX.Location = new System.Drawing.Point(340, 35);
            this.lblMagnX.Name = "lblMagnX";
            this.lblMagnX.Size = new System.Drawing.Size(65, 20);
            this.lblMagnX.TabIndex = 7;
            this.lblMagnX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbPortName
            // 
            this.cbbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPortName.FormattingEnabled = true;
            this.cbbPortName.Location = new System.Drawing.Point(575, 16);
            this.cbbPortName.Name = "cbbPortName";
            this.cbbPortName.Size = new System.Drawing.Size(86, 28);
            this.cbbPortName.TabIndex = 9;
            this.cbbPortName.DropDown += new System.EventHandler(this.cbbPortName_DropDown);
            // 
            // cbbSerialBaud
            // 
            this.cbbSerialBaud.FormattingEnabled = true;
            this.cbbSerialBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbbSerialBaud.Location = new System.Drawing.Point(10, 3);
            this.cbbSerialBaud.Name = "cbbSerialBaud";
            this.cbbSerialBaud.Size = new System.Drawing.Size(86, 21);
            this.cbbSerialBaud.TabIndex = 10;
            this.cbbSerialBaud.Text = "57600";
            this.cbbSerialBaud.Visible = false;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(523, 42);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(628, 718);
            this.gmap.TabIndex = 15;
            this.gmap.Zoom = 0D;
            this.gmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseMove);
            this.gmap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseUp);
            // 
            // btnCalibA
            // 
            this.btnCalibA.BackColor = System.Drawing.Color.Transparent;
            this.btnCalibA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalibA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibA.ForeColor = System.Drawing.Color.Black;
            this.btnCalibA.Location = new System.Drawing.Point(14, 125);
            this.btnCalibA.Name = "btnCalibA";
            this.btnCalibA.Size = new System.Drawing.Size(127, 25);
            this.btnCalibA.TabIndex = 1;
            this.btnCalibA.Text = "Kalibrasi Accelerometer";
            this.btnCalibA.UseVisualStyleBackColor = false;
            this.btnCalibA.Click += new System.EventHandler(this.btnCalibA_Click);
            // 
            // btnCalibM
            // 
            this.btnCalibM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibM.ForeColor = System.Drawing.Color.Black;
            this.btnCalibM.Location = new System.Drawing.Point(314, 125);
            this.btnCalibM.Name = "btnCalibM";
            this.btnCalibM.Size = new System.Drawing.Size(175, 25);
            this.btnCalibM.TabIndex = 1;
            this.btnCalibM.Text = "Kalibrasi Magnetometer";
            this.btnCalibM.UseVisualStyleBackColor = true;
            this.btnCalibM.Click += new System.EventHandler(this.btnCalibM_Click);
            // 
            // btnCalibG
            // 
            this.btnCalibG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibG.ForeColor = System.Drawing.Color.Black;
            this.btnCalibG.Location = new System.Drawing.Point(153, 125);
            this.btnCalibG.Name = "btnCalibG";
            this.btnCalibG.Size = new System.Drawing.Size(134, 25);
            this.btnCalibG.TabIndex = 1;
            this.btnCalibG.Text = "Kalibrasi Gyroscope";
            this.btnCalibG.UseVisualStyleBackColor = true;
            this.btnCalibG.Click += new System.EventHandler(this.btnCalibG_Click);
            // 
            // txtTargetSA
            // 
            this.txtTargetSA.Location = new System.Drawing.Point(416, 39);
            this.txtTargetSA.Name = "txtTargetSA";
            this.txtTargetSA.Size = new System.Drawing.Size(73, 20);
            this.txtTargetSA.TabIndex = 15;
            this.txtTargetSA.Text = "5.2";
            this.txtTargetSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTargetSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTargetSA_KeyPress);
            // 
            // btnTargetSA
            // 
            this.btnTargetSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTargetSA.ForeColor = System.Drawing.Color.Black;
            this.btnTargetSA.Location = new System.Drawing.Point(416, 63);
            this.btnTargetSA.Name = "btnTargetSA";
            this.btnTargetSA.Size = new System.Drawing.Size(73, 25);
            this.btnTargetSA.TabIndex = 1;
            this.btnTargetSA.Text = "Lock Target";
            this.btnTargetSA.UseVisualStyleBackColor = true;
            this.btnTargetSA.Click += new System.EventHandler(this.btnTargetSA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblGyroY);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblGyroX);
            this.panel1.Controls.Add(this.btnCalibA);
            this.panel1.Controls.Add(this.lblGyroZ);
            this.panel1.Controls.Add(this.btnCalibG);
            this.panel1.Controls.Add(this.lblAccZ);
            this.panel1.Controls.Add(this.btnCalibM);
            this.panel1.Controls.Add(this.lblAccY);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblAccX);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.lblMagnZ);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblMagnX);
            this.panel1.Controls.Add(this.lblMagnY);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 157);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblPit);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblPitPrb);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblGPSLat);
            this.panel2.Controls.Add(this.lblRolPrb);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblYaw);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblYawPrb);
            this.panel2.Controls.Add(this.lblNumSat);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblGPSFix);
            this.panel2.Controls.Add(this.lblGPSAlt);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblGPSLon);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(13, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 191);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHeadingNorm);
            this.panel3.Controls.Add(this.btnHeadingMile);
            this.panel3.Controls.Add(this.headingIndicator);
            this.panel3.Location = new System.Drawing.Point(336, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 191);
            this.panel3.TabIndex = 23;
            // 
            // headingIndicator
            // 
            this.headingIndicator.BackColor = System.Drawing.Color.Black;
            this.headingIndicator.Location = new System.Drawing.Point(16, 33);
            this.headingIndicator.Name = "headingIndicator";
            this.headingIndicator.Size = new System.Drawing.Size(150, 150);
            this.headingIndicator.TabIndex = 11;
            this.headingIndicator.Text = "headingIndicator1";
            // 
            // btnHeadingMile
            // 
            this.btnHeadingMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeadingMile.ForeColor = System.Drawing.Color.Black;
            this.btnHeadingMile.Location = new System.Drawing.Point(105, 160);
            this.btnHeadingMile.Name = "btnHeadingMile";
            this.btnHeadingMile.Size = new System.Drawing.Size(73, 25);
            this.btnHeadingMile.TabIndex = 1;
            this.btnHeadingMile.Text = "Mile";
            this.btnHeadingMile.UseVisualStyleBackColor = true;
            this.btnHeadingMile.Click += new System.EventHandler(this.btnHeadingMile_Click);
            // 
            // btnHeadingNorm
            // 
            this.btnHeadingNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeadingNorm.ForeColor = System.Drawing.Color.Black;
            this.btnHeadingNorm.Location = new System.Drawing.Point(3, 160);
            this.btnHeadingNorm.Name = "btnHeadingNorm";
            this.btnHeadingNorm.Size = new System.Drawing.Size(73, 25);
            this.btnHeadingNorm.TabIndex = 1;
            this.btnHeadingNorm.Text = "Derajat";
            this.btnHeadingNorm.UseVisualStyleBackColor = true;
            this.btnHeadingNorm.Click += new System.EventHandler(this.btnHeadingNorm_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTargetSA);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.btnTargetSA);
            this.panel4.Controls.Add(this.pitchIndicator);
            this.panel4.Location = new System.Drawing.Point(13, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 363);
            this.panel4.TabIndex = 24;
            // 
            // pitchIndicator
            // 
            this.pitchIndicator.BackColor = System.Drawing.Color.Black;
            this.pitchIndicator.Location = new System.Drawing.Point(21, -4);
            this.pitchIndicator.Name = "pitchIndicator";
            this.pitchIndicator.Size = new System.Drawing.Size(415, 365);
            this.pitchIndicator.TabIndex = 14;
            this.pitchIndicator.Text = "pitchIndicator1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnMinimize);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Location = new System.Drawing.Point(1082, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(94, 48);
            this.panel5.TabIndex = 26;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimize.BackgroundImage = global::HowCanPams.Properties.Resources.BtnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.BackgroundImage = global::HowCanPams.Properties.Resources.btnClose;
            this.btnClose.Location = new System.Drawing.Point(50, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Background
            // 
            this.Background.Image = global::HowCanPams.Properties.Resources.Camouflage;
            this.Background.Location = new System.Drawing.Point(5, 30);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1155, 753);
            this.Background.TabIndex = 20;
            this.Background.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(815, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // HowCanPams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1168, 788);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbbSerialBaud);
            this.Controls.Add(this.cbbPortName);
            this.Controls.Add(this.gmapCoor);
            this.Controls.Add(this.cmdSerialOpen);
            this.Controls.Add(this.Background);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HowCanPams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowCanPams";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bkgWorker;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblAccY;
        private System.Windows.Forms.Label lblAccZ;
        private System.Windows.Forms.Label lblAccX;
        private System.Windows.Forms.Label lblGyroY;
        private System.Windows.Forms.Label lblGyroX;
        private System.Windows.Forms.Label lblGyroZ;
        private System.Windows.Forms.Label lblMagnZ;
        private System.Windows.Forms.Label lblGPSLat;
        private System.Windows.Forms.Label lblGPSLon;
        private System.Windows.Forms.Label lblGPSFix;
        private System.Windows.Forms.Label lblGPSAlt;
        private System.Windows.Forms.Label lblNumSat;
        private System.Windows.Forms.Label lblPit;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.Label gmapCoor;
        private System.Windows.Forms.Label lblMagnY;
        private System.Windows.Forms.Label lblMagnX;
        private System.Windows.Forms.Label lblPitPrb;
        private System.Windows.Forms.Label lblRolPrb;
        private System.Windows.Forms.Label lblYawPrb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cmdSerialOpen;
        private System.Windows.Forms.Button btnCalibA;
        private System.Windows.Forms.Button btnCalibM;
        private System.Windows.Forms.Button btnCalibG;
        private System.Windows.Forms.Button btnTargetSA;
        private System.Windows.Forms.Button btnHeadingMile;
        private System.Windows.Forms.Button btnHeadingNorm;
        private System.Windows.Forms.TextBox txtTargetSA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbPortName;
        private System.Windows.Forms.ComboBox cbbSerialBaud;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private HowCanPamsControls.PitchIndicator pitchIndicator;
        private HowCanPamsControls.HeadingIndicator headingIndicator;
    }
}

