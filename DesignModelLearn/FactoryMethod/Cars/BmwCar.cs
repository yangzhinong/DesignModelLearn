using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.Cars
{
    class BmwCar : ICar
    {
        public void Run()
        {
            Console.WriteLine($"{nameof(BmwCar)} is running");
        }
    }
}
