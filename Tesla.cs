using System;

namespace CustomColorsAndSounds
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Thistle Tesla is coming! Run! *Dying Cat Noises*");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla drifted to the {direction}, disappearing in a cloud of smoke.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla quickly stopped, leaving a tire trail behind it.");
        }
    }
}