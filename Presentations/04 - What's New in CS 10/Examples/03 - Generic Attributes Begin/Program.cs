using System;

var something = new Something();
something.DoStuff();

[Developer("JGH")]
class Something
{
    public void DoStuff() => Console.WriteLine("Doing stuff...");
}