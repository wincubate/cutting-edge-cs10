namespace Wincubate.CS9.Data
{
    public record ProjectManager(
        string FirstName,
        string LastName,
        Level? Level = default,
        string? Team = default
    ) : Employee(FirstName,LastName)
    {
        public override string ToString() => base.ToString();
    }
}