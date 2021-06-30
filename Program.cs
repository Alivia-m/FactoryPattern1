using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create");
            int wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
