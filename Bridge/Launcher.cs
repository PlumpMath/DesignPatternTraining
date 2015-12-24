using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Launcher
    {
        public static void Before()
        {
            var app = new TechOld.AspDotNetWithMSSQL();
            app.ApplicationStart();
        }

        public static void After()
        {
            var lang = new Components.Languages.AspDotNet();
            var db = new Components.DataBase.MSSQL();
            var app = new Components.ApplicationTechBridge();
            app.Language = lang;
            app.DataBase = db;
            app.ApplicationStart();
        }
    }
}
