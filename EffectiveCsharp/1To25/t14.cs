using System;
using System.Collections.Generic;
using System.Text;

namespace EffectiveCsharp._1To25
{
    /// <summary>
    /// 尽量删减重复的初始化逻辑
    /// </summary>
    public class t14
    {
        private int count;
        private string name;
        public string copyName;
        public t14() : this(0, "都选C")
        {

        }
        public t14(int count = 0, string name = "")
        {
            this.count = count;
            this.name = name;
            copyName = name;
            if (this.count < 0)
            {
                this.count = 0;
            }
        }
    }
}
