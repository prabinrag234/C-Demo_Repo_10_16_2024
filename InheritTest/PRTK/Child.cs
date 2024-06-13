using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest.PRTK
{
    internal class Child : Parent
    {
        public void test()
        {
            Console.WriteLine("Test demo");
        }
        static void Main()
        {
            Child child = new Child();
            child.methode1();
            child.methode5();
            child.methode3();
            child.methode4();
            Parent parent = new Parent();
            parent.methode5();
            parent.methode4();
            parent.methode1();

            Console.ReadLine();
        }
    }
}
