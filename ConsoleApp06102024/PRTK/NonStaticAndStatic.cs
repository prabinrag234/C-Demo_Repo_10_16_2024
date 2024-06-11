using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06102024.PRTK
{
    public class NonStaticAndStatic
    {
        static int x;
        int y;
        static NonStaticAndStatic()
        {
            Console.WriteLine("This is a Static Constructor call.");
        }

        public NonStaticAndStatic(int i)
        {
            this.y = i;
            Display(y);
            Console.WriteLine("This is a Non Static Constructor call.");
        }

        void Display(int a)
        {
            Console.WriteLine("Value is " + a);
        }
        static void Main()
        {
            Console.WriteLine("The value of x are => " + x);
            Console.WriteLine("This is a Main function call.");
            NonStaticAndStatic obj = new NonStaticAndStatic(10);
            NonStaticAndStatic obj1 = new NonStaticAndStatic(20);
            NonStaticAndStatic obj2 = new NonStaticAndStatic(30);
            Console.WriteLine(obj.y + " " + obj.y + " "+ obj2.y + " ");
            Console.ReadLine();
        }

    }

}
