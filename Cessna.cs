using System;
namespace garrysGarage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys over. Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna has stopped in mid air.  This is probably bad.  Oh no. Here it comes.  Falling, falling. Zoooooom!");
        }
    }
}