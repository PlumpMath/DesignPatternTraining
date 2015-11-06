using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Factories
{
    public class FactoryApplePad : Factory
    {
        public override Products.Product Create()
        {
            return new Products.ProductPad();
        }
    }
}
