using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.TechOld
{
    public class AspDotNet : WebSystem
    {
        public override void ApplicationStart()
        {
            Console.WriteLine("Asp.Net的站点启动");
        }
    }
}
