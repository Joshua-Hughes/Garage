using System;

namespace Garage
{
    public interface IGasPowered
    {
        string CurrentTankPercentage();

        void RefuelTank();
    }
}