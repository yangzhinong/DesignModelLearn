using System;

namespace DesignModeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new FactoryMethod.Client();
            c1.Main();

            var c2 = new BuilderModes.Client();
            c2.Main();

            Console.Read();
        }
    }
}
