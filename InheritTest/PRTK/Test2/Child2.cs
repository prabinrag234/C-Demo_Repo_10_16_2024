using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest.PRTK.Test2
{
    internal class Child2 : Parent2
    {
        public Child2() : base(true)
        {
            Console.WriteLine("Child Constructor called");
        }
        protected void ChildMethod()
        {
            Console.WriteLine("Child Method called");
        }

        static void Main()
        {
            Child2 child2 = new Child2();
            
            Console.ReadLine();
        }
    }
}
