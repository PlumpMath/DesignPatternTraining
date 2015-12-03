using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorators
{
    public class 手机保护壳 : 手机修饰器
    {
        public 手机保护壳(iPhone phone) : base(phone) { }

        public override void 展示给大家看()
        {
            Console.WriteLine("{0}的手机装了保护壳", this.phone.Owner);
        }

        public void 不怕摔()
        {
            Console.WriteLine("{0}的手机不怕摔", this.phone.Owner);
        }
    }
}
