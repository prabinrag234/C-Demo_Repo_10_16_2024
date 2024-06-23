using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterface.PRTK
{
    internal class InterfaceImplementation : IInterfacetest
    {
        public void Test1(int A, int B)
        {
            Console.WriteLine(A + ", " + B + "are get");
        }
    }
}
