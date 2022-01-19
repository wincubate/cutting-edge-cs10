[AttributeUsage(AttributeTargets.All)]
public class DeveloperAttribute<T> : Attribute
{
    public T Info { get; init; }
    
    public DeveloperAttribute(T info)
    {
        Info = info;
    }
}
