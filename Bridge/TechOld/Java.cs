using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.TechOld
{
    public class Java : WebSystem
    {
        public override void ApplicationStart()
        {
            Console.WriteLine("Java的站点启动");
        }
    }
}
