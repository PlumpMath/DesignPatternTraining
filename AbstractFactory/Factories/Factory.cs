using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factories
{
    public abstract class Factory
    {
        public abstract Products.ProductPhone CreatePhone();
        public abstract Products.ProductPad CreatePad();
    }
}
