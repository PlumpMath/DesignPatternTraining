using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorators
{
    public class 手机贴膜 : 手机修饰器
    {
        public 手机贴膜(iPhone phone) : base(phone) { }

        public override void 展示给大家看()
        {
            Console.WriteLine("{0}的手机装了手机贴膜", this.phone.Owner);
        }
    }
}
