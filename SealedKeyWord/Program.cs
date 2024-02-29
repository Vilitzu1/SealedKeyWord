namespace SealedKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * A car can be a BMW, an Audi, a Porshe etc.
            * Polymorphism at work
            * 1. Cars can all be used whereever a Car is expected.
            * No cast is required because of an implicit conversion from a derived
            * class to its base class exists
            */
            var cars = new List<Car>
           {
               new Audi(200,"blue","A4"),
               new BMW(250,"red","M3")
           };

            /*
             * The virtual method Repair is invoked on each of the
             * derived classes, not the base class
             */
            foreach (var car in cars)
            {
                car.Repair();
            }
            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(300, "Green", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "Orange", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Camo", "M3 Super Turbo");
            myM3.Repair();

        }
    }
}
