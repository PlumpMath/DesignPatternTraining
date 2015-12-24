using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Components.Languages
{
    public abstract class ProgramLanguage
    {
        public string Name { get { return this.GetType().Name; } }
    }
}
