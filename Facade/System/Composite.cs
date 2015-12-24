using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.System
{
    public class Composite
    {
        public void Standby()
        {
            Console.WriteLine("开始组合");
        }

        public void Foot()
        {
            Console.WriteLine("组成脚和腿");
        }

        public void Body()
        {
            Console.WriteLine("组成躯干和手臂");
        }

        public void Head()
        {
            Console.WriteLine("我来组成头部!");
        }
    }
}
