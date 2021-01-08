using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes
{

    /// <summary>
    /// 客户端使用示例
    /// </summary>
    class Client
    {

        public void Main()
        {
            ActorDirector director = new ActorDirector();
            Actor actor = director.Construct(new HeroBuilder()); //此处可以反射注入

            Console.WriteLine(actor.ToString());

        }
    }
}
