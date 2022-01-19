using System;

var handler = new Handler();
handler.DoStuff();

[Developer("JGH / Wincubate ApS")] // <--- Argh!?
class Handler
{
    public void DoStuff() => Console.WriteLine("Doing stuff...");
}