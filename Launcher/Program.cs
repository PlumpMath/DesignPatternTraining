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
                //var iPhone = new Adapter.Phones.iPhone();
                //var android = new Adapter.Phones.Android();

                //Adapter.Adapters.ChargeAdapter adapter = null;
                //adapter = new Adapter.Adapters.ChargeAdapterForIPhone(iPhone);
                //adapter.Charge();
                //adapter = new Adapter.Adapters.ChargeAdapterForAndroid(android);
                //adapter.Charge();

                //var square = new Flyweight.Square();
                //square.GetArea("A").Play();
                //square.GetArea("A").Play();
                //square.GetArea("A").Play();
                //square.GetArea("B").Play();
                //square.GetArea("B").Play();
                //square.GetArea("A").Leave();
                //square.GetArea("C").Play();

                var iphone = new Decorator.iPhone { Owner = "孙博" };
                iphone.打电话();
                var newphone = new Decorator.Decorators.手机保护壳(iphone);
                newphone.打电话();
                newphone.展示给大家看();
                newphone.不怕摔();
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
