using System;

namespace CustomColorsAndSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 3.6,
                MainColor = "Black",
                MaximumOccupancy = "1-2 bodies."
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 100,
                MainColor = "Thistle",
                MaximumOccupancy = "Up to 5 bodies."
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 1236,
                MainColor = "Light Yellow",
                MaximumOccupancy = "9-10 bodies."
            };
            Ram D100 = new Ram()
            {
                FuelCapacity = 33,
                MainColor = "Dark Grey",
                MaximumOccupancy = "2 bodies."
            };

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            Console.WriteLine("");
            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            Console.WriteLine("");
            mx410.Drive();
            mx410.Turn("Left");
            mx410.Stop();
            Console.WriteLine("");
            D100.Drive();
            D100.Turn("Right");
            D100.Stop();
        }
    }
}
