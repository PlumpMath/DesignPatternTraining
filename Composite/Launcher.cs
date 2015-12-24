using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Launcher
    {
        public static void After()
        {
            var menu = new Menu { Text = "ROOT" };
            for (var i = 1; i < 3; i++)
            {
                var menuL1 = new Menu { Text = string.Format("MENU {0}", i) };
                for (var j = 1; j < 3; j++)
                {
                    var menuL2 = new Menu { Text = string.Format("MENU {0}{1}", i, j) };
                    menuL1.Add(menuL2);
                }
                menu.Add(menuL1);
            }

            menu.Expend();
        }
    }
}
