namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car(100,200,4);
            car.AvarageSpeed();
            car.RemainOilAmount(100,40,"dizel");

            Bicycle bicycle = new Bicycle(100, 200,"blabla");
            bicycle.AvarageSpeed();
            bicycle.RemainOilAmount(100, 40, "dizel");

            Plane plane = new Plane(100, 200, 4);
            plane.AvarageSpeed();
            plane.RemainOilAmount(100, 40, "dizel");

        }
    }
}