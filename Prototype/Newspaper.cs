using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class Newspaper : ICloneable
    {
        public string Title { set; get; }

        public string A1 { set; get; }
        public string A2 { set; get; }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Newspaper Clone()
        {
            var copy = this.MemberwiseClone() as Newspaper;
            return copy;
        }

        public override string ToString()
        {
            return string.Format("The newspaper is {0}, A1's news:{1}, A2's news:{2}", this.Title, this.A1, this.A2);
        }
    }
}
