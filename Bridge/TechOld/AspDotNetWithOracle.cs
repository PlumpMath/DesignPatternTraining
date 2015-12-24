using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.TechOld
{
    public class AspDotNetWithOracle : AspDotNet
    {
        public override void ApplicationStart()
        {
            base.ApplicationStart();
            Console.WriteLine("Oracle启动");
        }
    }
}
