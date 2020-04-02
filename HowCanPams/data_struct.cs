using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowCanPams
{

    #region mw_data_gui

    public class data_gui
    {
        public int ax;          //AccSmooth
        public int ay;          //AccSmooth
        public int az;          //AccSmooth
        public int gx;          //Gyro Smooth
        public int gy;          //Gyro Smooth
        public int gz;          //Gyro Smooth
        public int magx;    //Magnetometer 
        public int magy;    //Magnetometer 
        public int magz;   //Magnetometer 
        public int baro;
        public float heading;
        public float angx;                //Must be /10
        public float angy;                //Must be /10

        public int GPS_FIX;
        public int GPS_numSat;
        public int GPS_LAT;
        public int GPS_LON;
        public int GPS_altitude;
        public int GPS_speed;
        public int GPS_ground_course;

    }
}
    #endregion
