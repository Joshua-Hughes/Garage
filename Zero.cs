using System;

namespace CustomColorsAndSounds
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Black Zero zooms by! Zoooooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The bike quickly turned {direction}, almost losing its balance.");
        }

        public override void Stop()
        {
            Console.WriteLine("The bike came to a careful stop, as to not hurt the driver.");
        }
    }
}
