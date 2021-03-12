using System;

namespace CustomColorsAndSounds
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Light Yellow Cessna flies over! NNNEEEEOOOOOOWWWW!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The plane turned {direction}, almost doing a full spin in  the process.");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane landed very carefully.");
        }
    }
}