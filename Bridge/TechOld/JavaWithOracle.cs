using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.TechOld
{
    public class JavaWithOracle : Java
    {
        public override void ApplicationStart()
        {
            base.ApplicationStart();
            Console.WriteLine("Oracle启动");
        }
    }
}
