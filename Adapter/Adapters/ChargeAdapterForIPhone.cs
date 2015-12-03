using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Adapters
{
    public class ChargeAdapterForIPhone : ChargeAdapter
    {
        public ChargeAdapterForIPhone(Phones.iPhone phone)
        {
            this.phone = phone;
        }

        private Phones.iPhone phone;

        public override void Charge()
        {
            this.phone.ChargeWithLighting();
        }
    }
}
