using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.Cars
{
    interface ICarFactory
    {
        ICar CreateCar();
    }
}
