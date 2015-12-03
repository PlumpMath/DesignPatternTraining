using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorators
{
    public abstract class 手机修饰器 : iPhone
    {
        protected 手机修饰器(iPhone phone)
        {
            this.phone = phone;
        }

        protected iPhone phone { private set; get; }

        public override void 打电话()
        {
            this.phone.打电话();
        }

        public abstract void 展示给大家看();
    }
}
