namespace garrysGarage
{
    public class Zero : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}