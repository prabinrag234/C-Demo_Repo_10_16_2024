using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding.PRTK
{
    public class MethodOverridingTest
    {
        public virtual void Test()
        {
            Console.WriteLine("This is a override method in parent");
        }
    }
    internal class child : MethodOverridingTest 
    { 
        public override void Test()
        {
            Console.WriteLine("This is a override method in child");
        }
        static void Main()
        {
            child child = new child();
            child.Test();
            Console.ReadLine();
        }
    }
}
