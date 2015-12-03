using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class Square
    {
        private IDictionary<string, FlyweightArea> areas = new Dictionary<string, FlyweightArea>();

        public FlyweightArea GetArea(string areaName)
        {
            if (!areas.ContainsKey(areaName))
            {
                areas.Add(areaName, new FlyweightArea(areaName));
            }
            return areas[areaName];
        }
    }
}
