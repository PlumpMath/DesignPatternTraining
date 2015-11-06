using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factories
{
    public class FactorySamung : Factory
    {
        public override Products.ProductPhone CreatePhone()
        {
            return new Products.Samung.S6();
        }

        public override Products.ProductPad CreatePad()
        {
            return new Products.Samung.Note5();
        }
    }
}
