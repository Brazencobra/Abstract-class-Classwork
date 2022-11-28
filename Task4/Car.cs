using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Car : Vehicle , IEngine
    {

        byte _doorcount;

        

        public byte DoorCount 
        {
            get => _doorcount;
            set
            {
                _doorcount = value;
            }
        }

        public Car(double drivetime, double drivepath,byte doorcount) : base(drivetime, drivepath)
        {

            DoorCount = doorcount;

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
