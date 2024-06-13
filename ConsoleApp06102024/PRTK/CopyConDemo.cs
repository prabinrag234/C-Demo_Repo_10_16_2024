using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06102024.PRTK
{
    internal class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }
        public CopyConDemo(CopyConDemo sender)
        {
            x = sender.x + 10;
        }
        public void Disp()
        {
            Console.WriteLine("This is the value of i => " + x);
        }
        static void Main()
        {
            CopyConDemo obj1 = new CopyConDemo(5);
            obj1.Disp();
            CopyConDemo obj2 = new CopyConDemo(obj1);
            obj2.Disp();
            Console.ReadLine();
        }
    }
}
