using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.Cars
{
    class BmwFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new BmwCar();
        }
    }
}
