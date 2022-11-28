using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Plane : Vehicle , IEngine
    {

        double _winglength;

        public double WingLength 
        {
            get => _winglength;
            set
            {
                _winglength = value;
            }
        }

        public Plane(double drivetime, double drivepath, double winglength) : base(drivetime, drivepath)
        {

            WingLength = winglength;

        }

        public override void AvarageSpeed()
        {
            double answer = DrivePath / DriveTime;
            Console.WriteLine(answer);
        }

        public void RemainOilAmount(double oilcapacity, double currentoil, string fueltype)
        {
            double remainoilamount = oilcapacity - currentoil;
            Console.WriteLine(remainoilamount);
        }
    }
}
