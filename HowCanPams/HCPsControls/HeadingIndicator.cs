using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Data;

namespace HowCanPamsControls
{
    class HeadingIndicator : HCPsGUIControl
    {
        #region Fields

        float Heading;
        bool ringType = true;

        Bitmap ctr = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.HeadingCenter);
        Bitmap ring = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.HeadingRing);
        Bitmap ringM = new Bitmap(HowCanPams.HCPsControls.HCPsControlsResource.HeadingRingM);

        #endregion

        #region Constructor

        private System.ComponentModel.Container components = null;

        public HeadingIndicator()
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
            Bitmap bmp = new Bitmap(ring.Width, ring.Height);

            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform(75, 75);   // pindahkan pusat putaran ke 75,75
            gfx.RotateTransform(Heading);     // putarkan benda
            gfx.TranslateTransform(-75, -75); // kembalikan pusat putaran ke titik 0,0
            if (ringType) gfx.DrawImageUnscaled(ring, 0, 0);
            else          gfx.DrawImageUnscaled(ringM, 0, 0);
            pe.Graphics.DrawImageUnscaled(bmp, 0, 0);

            pe.Graphics.DrawImageUnscaled(ctr, 0, 0);

            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 9.0F);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            if (ringType) pe.Graphics.DrawString(String.Format("{0:000.00°}", Heading), drawFont, drawBrush, 50, 85);
            else          pe.Graphics.DrawString(String.Format("{0:0000}", Math.Round(Heading*17.777)), drawFont, drawBrush, 59, 85);

            gfx.Dispose();
            bmp.Dispose();
            maskPen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftHeading">The aircraft heading in °deg</param>
        public void SetHeadingIndicatorParameters(float aircraftHeading, bool headingType)
        {
            if (aircraftHeading < 0) Heading = 360 + aircraftHeading;
            else Heading = aircraftHeading;
            ringType = headingType;
            this.Refresh();
        }

        #endregion
    }
}
