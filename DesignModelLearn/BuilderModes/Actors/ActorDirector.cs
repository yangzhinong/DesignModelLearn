using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes
{

    /// <summary>
    /// 角色指挥者
    /// </summary>
    public class ActorDirector
    {
        public Actor Construct(ActorBuilder builder)
        {
            builder.BuildType();
            builder.BuildSex();
            builder.BuildFace();
            builder.BuildCostume();
            builder.BuildHairStyle();
            return builder.CreateActor();
        }
    }
}
