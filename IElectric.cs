using System;

namespace garrysGarage
{
    public interface IElectric
    {
        double BatteryKWh { get; set; }

        int CurrentChargePercentage { get; set; }

        void ChargeBattery()
        {
            
        }
    }
}