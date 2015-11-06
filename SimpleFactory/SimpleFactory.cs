using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public sealed class SimpleFactory
    {
        public static Products.Product Create(string productName)
        {
            switch ((productName ?? string.Empty).Trim().ToLower())
            {
                case "a": return new Products.ProductA();
                case "b": return new Products.ProductB();
                default: throw new ArgumentOutOfRangeException("productName");
            }
        }
    }
}
