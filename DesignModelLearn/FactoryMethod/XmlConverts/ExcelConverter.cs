using System;
using System.Text;

namespace DesignModeLearn.FactoryMethod.XmlConverts
{
    internal class ExcelConverter : IConverter
    {
        public string Read(object src)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{src}");
            sb.AppendLine($"<xml>Hello world </xml>");
            return sb.ToString();
        }
    }
}