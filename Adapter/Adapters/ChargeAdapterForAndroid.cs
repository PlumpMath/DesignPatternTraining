using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Adapters
{
    public class ChargeAdapterForAndroid : ChargeAdapter
    {
        public ChargeAdapterForAndroid(Phones.Android phone)
        {
            this.phone = phone;
        }

        private Phones.Android phone;

        public override void Charge()
        {
            this.phone.ChargeWithUSB();
        }
    }
}
