using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest.PRTK.Test2
{
    class Parent2
    {
        public Parent2(bool j) 
        {
            Console.WriteLine("Parent Constructor called." + j );
        }
        internal void ParentMathod1()
        {
            Console.WriteLine("Parent Method called.");
        }
        internal void ParentMathod2()
        {
            Console.WriteLine("Parent Method2 Called.");
        }
    }
}
