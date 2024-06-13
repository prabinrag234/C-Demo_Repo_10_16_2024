using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06102024.PRTK
{
    internal class ParamConDemo
    {
        public ParamConDemo(int i) 
        {
            Console.WriteLine("The Value Of i = " + i);
        }
        public ParamConDemo(string a)
        {
           Console.WriteLine("The Value if a = " + a);
        }

        static void Main()
        {
            ParamConDemo obj = new ParamConDemo("2");
            ParamConDemo obj2 = new ParamConDemo(20);
            Console.ReadLine();
        }
    }
}
