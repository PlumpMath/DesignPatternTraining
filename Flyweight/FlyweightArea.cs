using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class FlyweightArea
    {
        public FlyweightArea(string areaName)
        {
            this.AreaName = areaName;
        }

        public string AreaName { private set; get; }

        private int count = 0;

        public void Play()
        {
            this.count++;
            Console.WriteLine("Play @ {0}, now there're {1} people here", this.AreaName, this.count);
        }

        public void Leave()
        {
            this.count--;
            Console.WriteLine("Leave from {0}, now there're {1} people here", this.AreaName, this.count);
        }
    }
}
