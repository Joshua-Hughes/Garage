using System;
using System.Globalization;

namespace Garage
{
    public class Ram : Vehicle, IGasPowered
    {
        public double CurrentFuel { get; set; }

        public void RefuelTank()
        {
            this.CurrentFuel = 1.00;
        }

        public override void Drive()
        {
            Console.WriteLine("The Dark Grey Ram trudges by! Brbrbrbrbrbrbroom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram very slowly turned {direction}, slinging mud everywhere!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram finally came to a stop 10 minutes after hitting the brakes.");
        }

        public string CurrentTankPercentage()
        {
            return $"The {this.GetType().Name} currently has {this.CurrentFuel.ToString("P", CultureInfo.InvariantCulture)}";
        }
    }
}