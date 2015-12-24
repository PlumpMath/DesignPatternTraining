using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Components
{
    public class ApplicationTechBridge : WebSystem
    {
        public override void ApplicationStart()
        {
            Console.WriteLine("站点启动，用了[{0}]和[{1}]技术", this.Language.Name, this.DataBase.Name);
        }

        public Languages.ProgramLanguage Language { set; get; }
        public DataBase.DataBaseSystem DataBase { set; get; }
    }
}
