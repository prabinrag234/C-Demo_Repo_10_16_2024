using System;

namespace OverridingandHiding.PRTK
{
    public class Child : Parent
    {
        public override void ParentMethod1()
        {
            Console.WriteLine("Child Method 1");
        }
        public new void ParentMethod2()
        {
            Console.WriteLine("Child Method 2");
        }
        public void ParentCall()
        {
            base.ParentMethod1 ();
            base.ParentMethod2 ();
        }
        static void Main()
        {
            Child child = new Child();
            Parent parent = child;
            child.ParentMethod1();
            child.ParentMethod2();
            parent.ParentMethod1();
            parent.ParentMethod2();
            child.ParentCall();
            Console.ReadLine();
        }
    }
}
