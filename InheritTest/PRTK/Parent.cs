using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest.PRTK
{
    internal class Parent
    {
        public void methode1()
        {
            Console.WriteLine("Method 1");
        }
        private void methode2()
        {
            Console.WriteLine("Method 2");
        }
        protected void methode3()
        {
            Console.WriteLine("Method 3");
        }
        internal void methode4()
        {
            Console.WriteLine("Method 4");
        }
        protected internal void methode5()
        {
            Console.WriteLine("Method 5");
        }
    }
}
