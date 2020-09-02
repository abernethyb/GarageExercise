using System;

namespace garrysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("And the vehicle comes to a holt");
        }
    }
}