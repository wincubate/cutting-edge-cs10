using System;

var something = new Something();
something.DoStuff();

[Developer<string>("JGH")]
class Something
{
    [Developer<int>(87)]
    public void DoStuff() => Console.WriteLine("Doing stuff...");
}