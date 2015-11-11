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

                //var factory = new AbstractFactory.Factories.FactoryApple();
                //var product = factory.CreatePhone();
                //Console.WriteLine(product);

                //var manager = new Builder.Builders.iPhoneManager();
                //var builder = new Builder.Builders.iPhoneBuilderFor5();
                //var product = manager.Produce(builder);
                //Console.WriteLine(product);

                //var chinaDaily = new Prototype.Newspaper { Title = "China Daily", A1 = "同程旅游是休闲旅游第一名", A2 = "同程网是世界排名前三的中文网站" };
                //var copies = new List<Prototype.Newspaper>();
                //for (var i = 0; i < 5; i++)
                //{
                //    copies.Add(chinaDaily.Clone());
                //}
                //foreach (var copy in copies)
                //{
                //    Console.WriteLine(copy);
                //}
                ////chinaDaily.Title = "中国日报";
                ////Console.WriteLine(chinaDaily);
                ////foreach (var copy in copies)
                ////{
                ////    Console.WriteLine(copy);
                ////}
                //////var peopleDaily = chinaDaily.Clone() as Prototype.Newspaper;
                //////peopleDaily.Title = "人民日报";
                //////Console.WriteLine(chinaDaily);
                //////Console.WriteLine(peopleDaily);

                ////var travelPackages = new Prototype.TravelPackages { Coin = 10, Newspaper = new Prototype.Newspaper { Title = "参考消息" } };
                ////var other = travelPackages.Clone();
                ////Console.WriteLine(other);
                ////other.Newspaper.Title = "中国日报";
                ////Console.WriteLine(travelPackages);
                ////Console.WriteLine(other);

                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
                Console.WriteLine(Singleton.GateOfTheOrient.Instance);
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
