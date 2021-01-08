using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes
{
    /// <summary>
    /// 角色（产品）
    /// </summary>
    public class Actor
    {
        public string Type { get; set; }
        public string Sex { get; set; }

        public string HairStyle { get; set; }

        public string Face { get; set; }

        /// <summary>
        /// 服饰
        /// </summary>
        public string Costume { get; set; }

        public override string ToString()
        {
            return $"{Type}, {Sex}, {HairStyle}, {Costume}";
        }

    }
}
