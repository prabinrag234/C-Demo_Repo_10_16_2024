using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06112024.PRTK
{
    internal class VarInsRef
    {
        int a;

        static void Main()
        {
            VarInsRef obj = new VarInsRef();
            Console.WriteLine(obj.a + " As instance"); //a class variable can only access by using an instance of the class

            VarInsRef obj1; //un assigned class variable
            obj1 = new VarInsRef(); // assigned class variable.
            Console.WriteLine(obj1.a + " As assigned variable");

            VarInsRef obj2 = new VarInsRef();  //all newly created instance will share different memory location.
            obj2.a = 50;                   //all newly created instance will share different memory location.
            Console.WriteLine(obj2.a + " As a shared memory location");     //all newly created instance will share different memory location.
            VarInsRef obj3 = new VarInsRef();  //all newly created instance will share different memory location.
            obj3.a = 100;                  //all newly created instance will share different memory location.
            Console.WriteLine(obj3.a + " As a shared memory location");     //all newly created instance will share different memory location.

            VarInsRef obj4 = new VarInsRef(); //these all shared the common memory location that's why is same for all state.
            VarInsRef obj5 = obj4;          //these all shared the common memory location that's why is same for all state.
            obj4.a = 12;                  //these all shared the common memory location that's why is same for all state.
            Console.WriteLine(obj4.a + " As a common Memory Location");    //these all shared the common memory location that's why is same for all state.
            Console.WriteLine(obj5.a + " As a common Memory Location");    //these all shared the common memory location that's why is same for all state.
            obj5.a = 18;                  //these all shared the common memory location that's why is same for all state.
            Console.WriteLine(obj4.a + " As a common Memory Location");    //these all shared the common memory location that's why is same for all state.
            Console.WriteLine(obj5.a + " As a common Memory Location");    //these all shared the common memory location that's why is same for all state.

            Console.ReadLine();
        }
        
    }
}
