using System;
using System.Globalization;

namespace Garage
{
    public class Cessna : Vehicle, IGasPowered
    {
        public double CurrentFuel { get; set; }

        public void RefuelTank()
        {
            this.CurrentFuel = 1.00;
        }

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

        public string CurrentTankPercentage()
        {
            return $"The {this.GetType().Name} currently has {this.CurrentFuel.ToString("P", CultureInfo.InvariantCulture)}";
        }
    }
}