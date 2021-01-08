using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes
{
    /// <summary>
    /// 抽象角色建造者
    /// </summary>
    public abstract class ActorBuilder
    {
        protected Actor _actor = new Actor();
        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairStyle();

        public Actor CreateActor()
        {
            return _actor;
        }
    }
}
