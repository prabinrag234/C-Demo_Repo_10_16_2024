using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.PRTK
{
    internal class OperatorOverloading
    {
        int a, b, c, d;
        public OperatorOverloading(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static OperatorOverloading operator +(OperatorOverloading obj, OperatorOverloading obj1)
        {
            OperatorOverloading obj2 = new OperatorOverloading(obj.a+obj1.a,obj.b+obj1.b,obj.c+obj1.c,obj.d+obj1.d);
            return obj2;
        }

        public static void Main()
        {
            OperatorOverloading M = new OperatorOverloading(10,20,30,40);
            OperatorOverloading M1 = new OperatorOverloading(10,20,30,40);
            Console.WriteLine("Matrix 1");
            Console.WriteLine(M.a + " " + M.b + "\n" + M.c + " " + M.d + "\n");
            Console.WriteLine("Matrix 2");
            Console.WriteLine(M1.a + " " + M1.b + "\n" + M1.c + " " + M1.d + "\n");
            Console.WriteLine("The Sum of the matrix is :");
            M = M + M1;
            Console.WriteLine(M.a + " " + M.b + "\n" + M.c + " " + M.d);
            Console.ReadLine();
        }
    }
}
