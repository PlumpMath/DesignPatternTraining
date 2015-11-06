using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Products
{
    public class ProductPad : Product
    {
        public override string ProductName
        {
            get { return "iPad"; }
        }
    }
}
