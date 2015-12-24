using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Menu
    {
        public Menu Parent { private set; get; }
        private IList<Menu> children = new List<Menu>();

        public string Text { set; get; }

        public void Add(Menu menu)
        {
            menu.Parent = this;
            this.children.Add(menu);
        }

        public bool Remove(Menu menu)
        {
            menu.Parent = null;
            return this.children.Remove(menu);
        }

        public void Expend()
        {
            Console.WriteLine("{0}{1}", this.LeftSpace, this.Text);
            if (this.children != null && this.children.Any())
            {
                foreach (var child in this.children)
                {
                    child.Expend();
                }
            }
        }

        private string LeftSpace
        {
            get
            {
                if (this.Parent == null)
                {
                    return string.Empty;
                }
                return "-" + this.Parent.LeftSpace;
            }
        }
    }
}
