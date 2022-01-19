using System;

[AttributeUsage(AttributeTargets.All)]
public class DeveloperAttribute : Attribute
{
    public string Info { get; init; }
    
    public DeveloperAttribute(string info)
    {
        Info = info;
    }
}
