using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06102024.PRTK
{
    internal class ParamLessConDemo
    {
        public ParamLessConDemo() 
        {
            Console.WriteLine("Const Loaded.");
        }
        static void Main()
        {
            ParamLessConDemo obj = new ParamLessConDemo();
            Console.ReadLine();
        }
    }
}
