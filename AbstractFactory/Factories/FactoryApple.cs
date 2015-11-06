using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factories
{
    public class FactoryApple : Factory
    {
        public override Products.ProductPhone CreatePhone()
        {
            return new Products.Apple.iPhone();
        }

        public override Products.ProductPad CreatePad()
        {
            return new Products.Apple.iPad();
        }
    }
}
