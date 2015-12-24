using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class 战神金刚
    {
        private System.Lock oLock = new System.Lock();
        private System.Link oLink = new System.Link();
        private System.Engine oEngine = new System.Engine();
        private System.Composite oComposite = new System.Composite();

        public void 出击()
        {
            oLock.Open();
            oLink.Concat();
            oEngine.Open();
            oEngine.SwitchOn();
            oEngine.PowerUp();
            oComposite.Standby();
            oComposite.Foot();
            oComposite.Body();
            oComposite.Head();
            oEngine.SetUp();
        }
    }
}
