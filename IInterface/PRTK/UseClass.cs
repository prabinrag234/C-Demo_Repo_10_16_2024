using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterface.PRTK
{
    internal class UseClass : Program
    {
        public UseClass() { }
        public static void Main()
        {
            InterfaceImplementation @interface = new InterfaceImplementation();
            @interface.Test1(10,12);

            Console.ReadLine();
        }
    }
}
