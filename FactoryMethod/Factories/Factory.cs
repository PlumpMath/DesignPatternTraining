﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Factories
{
    public abstract class Factory
    {
        public abstract Products.Product Create();
    }
}
