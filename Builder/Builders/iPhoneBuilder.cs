using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builders
{
    public abstract class iPhoneBuilder
    {
        public abstract void AssembleScreen();
        public abstract void AssembleHomeButton();

        public abstract Products.iPhone AssembleFinish();
    }
}
