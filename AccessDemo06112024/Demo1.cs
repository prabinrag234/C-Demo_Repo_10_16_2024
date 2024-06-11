using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Consume items in the same class within the same project.
    public class Demo1
    {
        private void stat1()
        {
            Console.WriteLine("Private Method Called");
        }
        public void stat2()
        {
            Console.WriteLine("Public Method Called");
        }
        protected void stat3()
        {
            Console.WriteLine("Protected Method Called");
        }
        internal void stat4()
        {
            Console.WriteLine("Internal Method Called");
        }
        protected internal void stat5()
        {
            Console.WriteLine("Protected internal Method Called");
        }
        static void Main(string[] args)
        {
            Demo1 program = new Demo1();
            program.stat1();
            program.stat2();
            program.stat3();
            program.stat4();
            program.stat5();
            Console.ReadLine();
        }
    }
}
