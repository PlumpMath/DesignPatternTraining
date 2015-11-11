using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Products.Parts
{
    public class HomeButton : Parts.ProductPart
    {
        public HomeButton(bool hasTouchID)
        {
            this.HasTouchID = hasTouchID;
        }

        public bool HasTouchID { private set; get; }

        public override string ToString()
        {
            return string.Format("TouchID:[{0}]", this.HasTouchID ? "YES" : "NO");
        }
    }
}
