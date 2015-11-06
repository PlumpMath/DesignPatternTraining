using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Products
{
    public class ProductPhone : Product
    {
        public override string ProductName
        {
            get { return "iPhone"; }
        }
    }
}
