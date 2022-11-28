using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class Vehicle
    {

        double _drivetime;
        double _drivepath;

        public double DriveTime 
        {
            get => _drivetime;
            set
            {
                _drivetime = value;
            }
        }
        public double DrivePath
        {
            get => _drivepath;
            set
            {
                _drivepath = value;
            }
        }

        public Vehicle(double drivetime, double drivepath)
        {
            _drivetime = drivetime;
            _drivepath = drivepath;
        }

        public abstract void AvarageSpeed();
        
    }
}
