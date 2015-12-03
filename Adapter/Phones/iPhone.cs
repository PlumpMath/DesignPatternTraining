using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Phones
{
    public class iPhone
    {
        public void ChargeWithLighting()
        {
            Console.WriteLine("通过iLighting接口充电");
        }
    }
}
