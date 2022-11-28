using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Bicycle : Vehicle , IEngine
    {

        string _pedalkind;

        public string PedalKind 
        {
            get => _pedalkind;
            set
            {
                _pedalkind = value;
            }
        }

        public Bicycle(double drivetime, double drivepath, string pedalkind) : base(drivetime, drivepath)
        {

            PedalKind = pedalkind;

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
