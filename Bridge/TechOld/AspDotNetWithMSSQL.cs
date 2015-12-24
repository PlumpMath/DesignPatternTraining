using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.TechOld
{
    public class AspDotNetWithMSSQL : AspDotNet
    {
        public override void ApplicationStart()
        {
            base.ApplicationStart();
            Console.WriteLine("MS-SQL启动");
        }
    }
}
