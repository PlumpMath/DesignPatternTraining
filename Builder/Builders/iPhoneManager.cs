using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builders
{
    public class iPhoneManager
    {
        public Products.iPhone Produce(iPhoneBuilder builder)
        {
            builder.AssembleScreen();
            builder.AssembleHomeButton();
            return builder.AssembleFinish();
        }
    }
}
