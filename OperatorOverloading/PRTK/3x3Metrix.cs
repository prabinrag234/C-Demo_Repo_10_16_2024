using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.PRTK
{
    internal class _3x3Metrix
    {
        int a,b,c,d,e,f,g,h,i;
        public _3x3Metrix(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            this.a = a; this.b = b; this.c = c;
            this.d = d; this.e = e; this.f = f;
            this.g = g; this.h = h; this.i = i;
        }

        #region Operator Overloading Methodes
        public static _3x3Metrix operator +(_3x3Metrix obj,_3x3Metrix obj1)
        {
            _3x3Metrix add = new _3x3Metrix(obj.a + obj1.a,obj.b + obj1.b,obj.c + obj1.c,obj.d + obj1.d,obj.e + obj1.e,obj.f + obj1.f,obj.g + obj1.g,obj.h + obj1.h,obj.i + obj1.i);
            return add;
        }

        public static _3x3Metrix operator -(_3x3Metrix obj,_3x3Metrix obj1)
        {
            _3x3Metrix add = new _3x3Metrix(obj.a - obj1.a,obj.b - obj1.b,obj.c - obj1.c,obj.d - obj1.d,obj.e - obj1.e,obj.f - obj1.f,obj.g - obj1.g,obj.h - obj1.h,obj.i - obj1.i);
            return add;
        }

        public static _3x3Metrix operator *(_3x3Metrix obj,_3x3Metrix obj1)
        {
            _3x3Metrix add = new _3x3Metrix(obj.a * obj1.a,obj.b * obj1.b,obj.c * obj1.c,obj.d * obj1.d,obj.e * obj1.e,obj.f * obj1.f,obj.g * obj1.g,obj.h * obj1.h,obj.i * obj1.i);
            return add;
        }

        public static _3x3Metrix operator /(_3x3Metrix obj,_3x3Metrix obj1)
        {
            _3x3Metrix add = new _3x3Metrix(obj.a / obj1.a,obj.b / obj1.b,obj.c / obj1.c,obj.d / obj1.d,obj.e / obj1.e,obj.f / obj1.f,obj.g / obj1.g,obj.h / obj1.h,obj.i / obj1.i);
            return add;
        }
        #endregion

        public static void Main()
        {
            _3x3Metrix _3X3 = new _3x3Metrix(12,28,34,54,12,46,95,84,75);
            _3x3Metrix _3X32 = new _3x3Metrix(84,54,15,65,34,75,84,59,62);

            Console.WriteLine("\n\tMatrix 1\n");
            Console.WriteLine("\t" + _3X3.a + " " + _3X3.b + " " + _3X3.c + "\n\t" + _3X3.d + " " + _3X3.e + " " + _3X3.f + "\n\t" + _3X3.g + " " + _3X3.h + " " + _3X3.i + "\n\n");
            Console.WriteLine("\tMatrix 2\n");
            Console.WriteLine("\t" + _3X32.a + " " + _3X32.b + " " + _3X32.c + "\n\t" + _3X32.d + " " + _3X32.e + " " + _3X32.f + "\n\t" + _3X32.g + " " + _3X32.h + " " + _3X32.i + "\n\n");

            #region Implementation
            Console.WriteLine("\tAddition of these Matrix is\n");
            _3X3 = _3X3 + _3X32;
            Console.WriteLine("\t" + _3X3.a + " " + _3X3.b + " " + _3X3.c + "\n\t" + _3X3.d + " " + _3X3.e + " " + _3X3.f + "\n\t" + _3X3.g + " " + _3X3.h + " " + _3X3.i + "\n\n");
            _3X3 = new _3x3Metrix(12, 28, 34, 54, 12, 46, 95, 84, 75);

            Console.WriteLine("\tSubtraction of these Matrix is\n");
            _3X3 = _3X3 - _3X32;
            Console.WriteLine("\t" + _3X3.a + " " + _3X3.b + " " + _3X3.c + "\n\t" + _3X3.d + " " + _3X3.e + " " + _3X3.f + "\n\t" + _3X3.g + " " + _3X3.h + " " + _3X3.i + "\n\n");
            _3X3 = new _3x3Metrix(12, 28, 34, 54, 12, 46, 95, 84, 75);

            Console.WriteLine("\tMultiplication of these Matrix is\n");
            _3X3 = _3X3 * _3X32;
            Console.WriteLine("\t" + _3X3.a + " " + _3X3.b + " " + _3X3.c + "\n\t" + _3X3.d + " " + _3X3.e + " " + _3X3.f + "\n\t" + _3X3.g + " " + _3X3.h + " " + _3X3.i + "\n\n");
            _3X3 = new _3x3Metrix(12, 28, 34, 54, 12, 46, 95, 84, 75);

            Console.WriteLine("\tDivision of these Matrix is\n");
            _3X3 = _3X3 / _3X32;
            Console.WriteLine("\t" + _3X3.a + " " + _3X3.b + " " + _3X3.c + "\n\t" + _3X3.d + " " + _3X3.e + " " + _3X3.f + "\n\t" + _3X3.g + " " + _3X3.h + " " + _3X3.i + "\n\n");
            #endregion

            Console.ReadLine();
        }

    }
}
