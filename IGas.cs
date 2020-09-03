using System;

namespace garrysGarage
{
    public interface IGas
    {
        double FuelCapacity { get; set; }
        int CurrentTankPercentage { get; set; }

        void RefuelTank()
        {

        }
    }
}