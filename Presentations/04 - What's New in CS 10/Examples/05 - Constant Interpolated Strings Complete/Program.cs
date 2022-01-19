var handler = new Handler();
handler.DoStuff();

[Developer(DeveloperInfoConstants.Message)]
class Handler
{
    public void DoStuff() => Console.WriteLine("Doing stuff...");
}