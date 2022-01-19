using System;

namespace Wincubate.CS8.Slide26
{
    interface I
    {
        public static void M() => Console.WriteLine("I.M()");

        void DoStuff() => M();
    }

    class A : I
    {
        public void DoStuff() => Console.WriteLine("A.Dostuff()");
    }

    class B : I
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            I obj = new B();
            obj.DoStuff();

            I.M();
        }
    }
}
