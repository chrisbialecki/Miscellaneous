using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_Argument_By_Ref
{
    class Program
    {
        int yOut = 5;

        static void Method(ref int i)
        {
            i = i + 44;
        }

        public void MethodOut(out int y)
        {           

            y = yOut * 2;                 

        }


        static void Main(string[] args)
        {
            int valRef = 1;
            Method(ref valRef);
            Console.WriteLine(valRef);

            int valOut;
            Program p = new Program();
            p.MethodOut(out valOut);
            Console.WriteLine(valOut);

            Console.ReadLine();
        }
        
    }
}
