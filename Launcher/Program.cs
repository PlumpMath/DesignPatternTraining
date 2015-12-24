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
                Composite.Launcher.After();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception  :{0}", ex.Message);
                Console.WriteLine("StackTrace :{0}", ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
