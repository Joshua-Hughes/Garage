using System;
using System.Globalization;

namespace Garage
{
    public class Zero : Vehicle, IBatteryPowered
    {
        public double CurrentBatteryKWh { get; set; }


        public void ChargeBattery()
        {
            this.CurrentBatteryKWh = 1.00;
        }

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

        public string CurrentChargePercentage()
        {
            return $"The {this.GetType().Name} currently has {this.CurrentBatteryKWh.ToString("P", CultureInfo.InvariantCulture)}";
        }
    }
}
