using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Chartreuse",
                MaximumOccupancy = "1-2 bodies.",
                CurrentBatteryKWh = 0.70
            };
            Zero fx = new Zero()
            {
                MainColor = "Dark Salmon",
                MaximumOccupancy = "1-2 bodies",
                CurrentBatteryKWh = 0.80
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Tan",
                MaximumOccupancy = "5 bodies",
                CurrentBatteryKWh = 0.89
            };

            List<IBatteryPowered> electricVehicles = new List<IBatteryPowered>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IBatteryPowered ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage()}");
            }

            foreach (IBatteryPowered ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            Console.WriteLine("");

            foreach (IBatteryPowered ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage()}");
            }

            Console.WriteLine("");
            /***********************************************/

            Ram ram = new Ram()
            {
                MainColor = "Cadet Blue",
                MaximumOccupancy = "3 bodies",
                CurrentFuel = 0.40
            };
            Cessna cessna150 = new Cessna()
            {
                MainColor = "Light Cyan",
                MaximumOccupancy = "8 bodies",
                CurrentFuel = 0.42
            };

            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasPowered gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage()}");
            }

            foreach (IGasPowered gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            Console.WriteLine("");

            foreach (IGasPowered gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage()}");
            }
        }
    }
}