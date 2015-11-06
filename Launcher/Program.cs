using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var product = SimpleFactory.SimpleFactory.Create("A");
                //Console.WriteLine(product);

                //var factory = new FactoryMethod.Factories.FactoryApplePad();
                //var product = factory.Create();
                //Console.WriteLine(product);

                var factory = new AbstractFactory.Factories.FactoryApple();
                var product = factory.CreatePhone();
                Console.WriteLine(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:{0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
