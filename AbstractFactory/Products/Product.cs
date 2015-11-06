using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Products
{
    public abstract class Product
    {
        public virtual string ProductName { get { return this.GetType().Name; } }

        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
