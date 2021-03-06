using System;

namespace garrysGarage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla silently passes by. Shhh!");
        }
    }
}