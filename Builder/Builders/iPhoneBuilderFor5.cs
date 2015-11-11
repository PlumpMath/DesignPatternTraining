using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builders
{
    public class iPhoneBuilderFor5 : iPhoneBuilder
    {
        private Products.iPhone iphone = new Products.iPhone("5");

        public override void AssembleScreen()
        {
            this.iphone.Screen = new Products.Parts.Screen(4.0f);
        }

        public override void AssembleHomeButton()
        {
            this.iphone.HomeButton = new Products.Parts.HomeButton(false);
        }

        public override Products.iPhone AssembleFinish()
        {
            return this.iphone;
        }
    }
}
