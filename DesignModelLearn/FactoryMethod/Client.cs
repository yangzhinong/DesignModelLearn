using DesignModeLearn.FactoryMethod.Cars;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignModeLearn.FactoryMethod
{
    class Client
    {

        public void Main()
        {
            ICarFactory factory = (ICarFactory)Assembly.GetEntryAssembly()
                                     .CreateInstance("DesignModeLearn.FactoryMethod.Cars.BmwFactory");
            ICar car = factory.CreateCar();
            car.Run();

            XmlConverts.XmlConvertFactory xmlFactory = new XmlConverts.ExcelConvertFactory();
            Console.WriteLine(xmlFactory.ReadToXml("hello.xls"));
        }

    }
}
