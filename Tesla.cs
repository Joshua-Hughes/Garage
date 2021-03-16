using System;
using System.Globalization;

namespace Garage
{
    public class Tesla : Vehicle, IBatteryPowered
    {
        public double CurrentBatteryKWh { get; set; }


        public void ChargeBattery()
        {
            this.CurrentBatteryKWh = 1.00;
        }

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

        public string CurrentChargePercentage()
        {
            return $"The {this.GetType().Name} currently has {this.CurrentBatteryKWh.ToString("P", CultureInfo.InvariantCulture)}";
        }
    }
}