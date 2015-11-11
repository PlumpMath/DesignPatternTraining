using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Builders
{
    public class iPhoneBuilderFor6S : iPhoneBuilder
    {
        private Products.iPhone iphone = new Products.iPhone("6S");

        public override void AssembleScreen()
        {
            this.iphone.Screen = new Products.Parts.Screen(4.7f);
        }

        public override void AssembleHomeButton()
        {
            this.iphone.HomeButton = new Products.Parts.HomeButton(true);
        }

        public override Products.iPhone AssembleFinish()
        {
            return this.iphone;
        }
    }
}
