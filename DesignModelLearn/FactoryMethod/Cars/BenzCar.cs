using System;

namespace DesignModeLearn.FactoryMethod.Cars
{
    internal class BenzCar : ICar
    {
        public void Run()
        {
            Console.WriteLine($"{nameof(BenzCar)} is running");
        }
    }
}