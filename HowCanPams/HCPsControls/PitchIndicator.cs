using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Data;

namespace HowCanPamsControls
{
    class PitchIndicator : HCPsGUIControl
    {
        #region Fields

        float Pitch;
        float tgtPitch;

        Bitmap holder = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.PitchHolder);
        Bitmap direct = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.PitchDirect);
        Bitmap target = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.TargetDirect);

        #endregion

        #region Constructor

        private System.ComponentModel.Container components = null;

        public PitchIndicator()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Pen maskPen = new Pen(this.BackColor, 30);

            // display Ring
            Bitmap bmp = new Bitmap(400, 330);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform(103, 294);   //pindahkan pusat putaran ke 73,72
            gfx.RotateTransform(-Pitch);    //putarkan benda
            gfx.TranslateTransform(-103, -294); //kembalikan pusat putaran ke titik 0,0
            gfx.DrawImageUnscaled(direct, 0, 0);
            pe.Graphics.DrawImageUnscaled(bmp, 0, 0);

            pe.Graphics.DrawImageUnscaled(holder, 0, 0);

            // display Ring
            Bitmap bmpTgt = new Bitmap(400, 330);
            Graphics gfxTgt = Graphics.FromImage(bmpTgt);
            gfxTgt.TranslateTransform(103, 294);   //pindahkan pusat putaran ke 73,72
            gfxTgt.RotateTransform(-tgtPitch);    //putarkan benda
            gfxTgt.TranslateTransform(-103, -294); //kembalikan pusat putaran ke titik 0,0
            gfxTgt.DrawImageUnscaled(target, 0, 0);
            pe.Graphics.DrawImageUnscaled(bmpTgt, 0, 0);

            //System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 9.0F);
            //System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //pe.Graphics.DrawString(String.Format("{0:000.00°}", Pitch), drawFont, drawBrush, 50, 85);

            gfx.Dispose();
            bmp.Dispose();
            maskPen.Dispose();
            //drawFont.Dispose();
            //drawBrush.Dispose();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftHeading">The aircraft heading in °deg</param>
        public void SetPitchIndicatorParameters(float aircraftHeading, float TargetPitch)
        {
            if (aircraftHeading < 0) Pitch = 360 + aircraftHeading;
            else Pitch = aircraftHeading;
            if (TargetPitch < 0) tgtPitch = 360 + TargetPitch;
            else tgtPitch = TargetPitch;
            this.Refresh();
        }

        #endregion
    }
}
