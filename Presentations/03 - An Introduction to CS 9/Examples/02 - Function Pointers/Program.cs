using System;

Console.WriteLine( "Something...");

unsafe class Example
{
    public void Compute(Action<int> a, delegate*<int, void> f)
    {
        a(42);
        f(42);
    }
}

