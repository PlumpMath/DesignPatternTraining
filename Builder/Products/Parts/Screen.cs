using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Products.Parts
{
    public class Screen : Parts.ProductPart
    {
        public Screen(float size)
        {
            this.Size = size;
        }

        public float Size { set; get; }

        public override string ToString()
        {
            return string.Format("Size:{0}\"", this.Size);
        }
    }
}
