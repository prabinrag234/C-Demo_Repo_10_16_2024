using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingandHiding.PRTK
{
    public class Parent
    {
        public virtual void ParentMethod1()
        {
            Console.WriteLine("Parent Method 1");
        }
        public void ParentMethod2() 
        {
            Console.WriteLine("Parent Method 2");
        }
    }
}
