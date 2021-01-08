using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.Cars
{
    class BenzFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new BenzCar();
        }
    }
}
