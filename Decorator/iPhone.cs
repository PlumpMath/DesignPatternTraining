using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class iPhone
    {
        public string Owner { set; get; }

        public virtual void 打电话()
        {
            Console.WriteLine("{0}的手机可以打电话", this.Owner);
        }
    }
}
