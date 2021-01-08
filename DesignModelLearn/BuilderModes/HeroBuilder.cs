using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes
{
    /// <summary>
    /// 具体的英雄角色建造者
    /// </summary>
    public class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            _actor.Costume = "盔甲";
        }

        public override void BuildFace()
        {
            _actor.Face = "英俊";
        }

        public override void BuildHairStyle()
        {
            _actor.HairStyle = "短发";
        }

        public override void BuildSex()
        {
            _actor.Sex = "man";
        }

        public override void BuildType()
        {
            _actor.Type = "Hero";
        }
    }
}
