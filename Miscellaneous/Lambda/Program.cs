using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        //// parameters: in, in, out
        //public static Func<string, string, int> func1 = (x, y) => x.Length + y.Length;
      public string x = "home";

        

        static void Main(string[] args)
        {
        //    var i = func1("home", "us");
        //    Console.WriteLine(i);
            
        //    Console.ReadLine();
            Program p = new Program();
           
            Console.WriteLine(p.x == "home" ? "true" : "false");
            Console.ReadLine();

        }
    }
}
