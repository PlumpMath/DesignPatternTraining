using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.System
{
    public class Engine
    {
        public void Open()
        {
            Console.WriteLine("热能装置连接");
        }

        public void SwitchOn()
        {
            Console.WriteLine("启动电源");
        }

        public void PowerUp()
        {
            Console.WriteLine("增大推力");
        }

        public void SetUp()
        {
            Console.WriteLine("前进,战神金刚!");
        }
    }
}
