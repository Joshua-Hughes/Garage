using System;

namespace Garage
{
    public interface IBatteryPowered
    {
        string CurrentChargePercentage();

        void ChargeBattery();
    }
}