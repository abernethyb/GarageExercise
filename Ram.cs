using System;

namespace garrysGarage
{
    public class Ram : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles by. RumbleRumbleRumble!");
        }
    }
}