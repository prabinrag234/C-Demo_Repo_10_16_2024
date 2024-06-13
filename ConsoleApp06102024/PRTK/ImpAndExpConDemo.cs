using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06102024.PRTK
{
    //Implicit Constructor
    public class ImpAndExpConDemo
    {
        public int x;
    }

    //Explicit Constructor
    public class Explicit
    {
        public int x;
        public Explicit(int i)
        {
            this.x = i;
        }
    }

    public class TestImplicitandExplicit
    {
        static void Main()
        {
            //Implicit Constructor Call
            ImpAndExpConDemo s1 = new ImpAndExpConDemo();
            ImpAndExpConDemo s2 = new ImpAndExpConDemo();
            ImpAndExpConDemo s3 = new ImpAndExpConDemo();

            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x);

            //Explicit Constructor Call
            Explicit j1 = new Explicit(10);
            Explicit j2 = new Explicit(20);
            Explicit j3 = new Explicit(30);

            Console.WriteLine(j1.x + " " + j2.x + " " + j3.x);

            Console.ReadLine();
        }
    }

}
