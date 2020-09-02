namespace garrysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna n4012p = new Cessna()
            {
                MainColor = "Blue",
                MaximumOccupancy = "2"
            };

            Tesla imaginaryTesla = new Tesla();
            Ram truck = new Ram();

            n4012p.Drive();
            n4012p.Turn("left");
            n4012p.Stop();
            imaginaryTesla.Drive();
            truck.Drive();
            truck.Stop();

        }
    }
}