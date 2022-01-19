using System;

string? representation = "N/A";
Company? c = new("Assignment Inc", "Yay!");

if ((c != null && c.GetValue(out object obj1)) == true)
{
    representation = obj1.ToString(); // Undesired error
}
Console.WriteLine(representation);

// Or, using ?.
if (c?.GetValue(out object obj2) == true)
{
    representation = obj2.ToString(); // Undesired error
}

// Or, using ??
if (c?.GetValue(out object obj3) ?? false)
{
    representation = obj3.ToString(); // Undesired error
}

record Company(string Name, object AdditionalInfo)
{
    public bool GetValue(out object obj)
    {
        obj = AdditionalInfo;

        return true;
    }
}