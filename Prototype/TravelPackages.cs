using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class TravelPackages : ICloneable
    {
        public int Coin { set; get; }
        public Newspaper Newspaper { set; get; }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public TravelPackages Clone()
        {
            var copy = this.MemberwiseClone() as TravelPackages;
            copy.Newspaper = this.Newspaper.Clone();
            return copy;
        }

        public override string ToString()
        {
            return string.Format("The package has coin {0}, has newspaper : {1}", this.Coin, this.Newspaper != null ? this.Newspaper.Title : "NO");
        }
    }
}
