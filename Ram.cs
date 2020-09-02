using System;

namespace garrysGarage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles by. RumbleRumbleRumble!");
        }
    }
}