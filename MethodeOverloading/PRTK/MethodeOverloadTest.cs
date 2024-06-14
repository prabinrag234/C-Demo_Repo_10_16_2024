using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeOverloading.PRTK
{
    internal class MethodeOverloadTest
    {
        public void Method() 
        {
            Console.WriteLine("Method 1");
        }
        public void Method(int i) 
        {
            Console.WriteLine("Method 2");
        }
        public void Method(string i) 
        {
            Console.WriteLine("Method 3");
        }
        public void Method(int i,string j) 
        {
            Console.WriteLine("Method 4");
        }
        public void Method(string i,int j) 
        {
            Console.WriteLine("Method 5");
        }

        static void Main()
        {
            MethodeOverloadTest methodeOverloadTest = new MethodeOverloadTest();
            methodeOverloadTest.Method(5);
            methodeOverloadTest.Method();
            methodeOverloadTest.Method("string",5);
            methodeOverloadTest.Method("string");
            methodeOverloadTest.Method(5,"string");
            Console.ReadLine();
        }
    }
}
