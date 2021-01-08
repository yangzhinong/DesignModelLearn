using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.XmlConverts
{
    abstract class XmlConvertFactory
    {
        public abstract IConverter CreateConverter();

        public string ReadToXml(object src)
        {
            return CreateConverter().Read(src);
        }
    }
}
