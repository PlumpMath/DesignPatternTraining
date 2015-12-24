using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Components.DataBase
{
    public abstract class DataBaseSystem
    {
        public string Name { get { return this.GetType().Name; } }
    }
}
