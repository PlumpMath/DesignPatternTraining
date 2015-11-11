using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Products
{
    public class iPhone
    {
        internal iPhone(string type)
        {
            this.Type = type;
        }

        public string Type { private set; get; }

        public Products.Parts.Screen Screen { internal set; get; }
        public Products.Parts.HomeButton HomeButton { internal set; get; }

        public override string ToString()
        {
            return string.Format(@"iPhone {0}
Screen: {1}
HomeButton: {2}
", this.Type, this.Screen, this.HomeButton);
        }
    }
}
