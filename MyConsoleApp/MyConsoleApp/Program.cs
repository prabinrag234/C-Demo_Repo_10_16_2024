using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myint = { 1, 2, 3 };
            Array.Reverse(myint);
            foreach (int i in myint)
            {
                Console.WriteLine(i);
            }
        }
    }
}
