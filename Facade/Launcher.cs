using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Launcher
    {
        public static void Before()
        {
            var oLock = new System.Lock();
            var oLink = new System.Link();
            var oEngine = new System.Engine();
            var oComposite = new System.Composite();

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

        public static void After()
        {
            var 战神金刚 = new 战神金刚();
            战神金刚.出击();
        }
    }
}
