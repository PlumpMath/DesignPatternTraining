using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Phones
{
    public class Android
    {
        public void ChargeWithUSB()
        {
            Console.WriteLine("通过USB接口充电");
        }
    }
}
