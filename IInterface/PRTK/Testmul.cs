using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterface.PRTK
{
    internal class Testmul : Imul1, Imul2
    {
        void test() { }
        void Imul1.test() { }
        void Imul2.test() { }
        public static void Main()
        {
            Testmul testmul = new Testmul();
            testmul.test();
            Imul1 imul1 = testmul;
            Imul2 imul2 = testmul;
            imul1.test();
            imul2.test();
            Console.ReadLine();
        }
    }
}
