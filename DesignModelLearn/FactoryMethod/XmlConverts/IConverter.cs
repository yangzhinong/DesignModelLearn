using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.FactoryMethod.XmlConverts
{
    interface IConverter
    {
        string Read(object src);
    }
}
