using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

[AsyncMethodBuilder(typeof(AsyncTaskMethodBuilder))]
record class R(string S)
{
}

class C
{
    [AsyncMethodBuilder(typeof(AsyncTaskMethodBuilder<>))]
    public async Task<R> ComputeAsync()
    {
        await Task.Delay(1000);
        return new R("Yay!");
    }
}