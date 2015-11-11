using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public sealed class GateOfTheOrient
    {
        private static object syncLock = new object();
        private volatile static GateOfTheOrient instance = null;
        public static GateOfTheOrient Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new GateOfTheOrient();
                        }
                    }
                }
                return instance;
            }
        }

        private GateOfTheOrient()
        {
            Console.WriteLine("Building...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Build finished!");
        }

        public override string ToString()
        {
            return string.Format("HASH CODE:{0}", this.GetHashCode());
        }
    }
}
