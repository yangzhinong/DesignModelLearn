using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.XmlConverts
{
    class ExcelConvertFactory : XmlConvertFactory
    {
        public override IConverter CreateConverter()
        {
            return new ExcelConverter();
        }
    }
}
