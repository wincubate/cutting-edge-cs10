using System.Diagnostics;

int i = 0;

while( i < 100 )
{
    Console.Write(".");

    // Does not compute string if not necessary
    Debug.Assert(i >= 0, $"{DateTime.Now} - {Utility.GetLogMessage()}");
    
    i++;
}

static class Utility
{
    public static string GetLogMessage()
    {
        Thread.Sleep(1000);
        return "Yaaarh!";
    }
}