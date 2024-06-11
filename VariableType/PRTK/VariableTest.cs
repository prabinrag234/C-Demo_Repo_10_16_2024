using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VariableType.PRTK
{
    internal class VariableTest
    {
        int nonStaic;
        static int sTatic;
        readonly int readOnly;
        const int cOnst = 5;
        static VariableTest()
        {
            sTatic = 10;
        }
        public VariableTest(int value)
        {
            Console.WriteLine("The Readonly Value before initializing " + this.readOnly);
            this.readOnly = value;
            Console.WriteLine("The Readonly Value after initializing " + this.readOnly);
            
        }

        static void Main()
        {
            VariableTest test = new VariableTest(10);
            test.nonStaic = 1;
            Console.WriteLine("The Value of non-static variable is = " + test.nonStaic);
            Console.WriteLine("The Value of static variable before initialization = " + sTatic);
            sTatic = 4;
            Console.WriteLine("The Value of static variable after initialization = " + sTatic);
            Console.WriteLine("The Value of const value i" + cOnst);
            Console.ReadLine();
        }
    }
}
