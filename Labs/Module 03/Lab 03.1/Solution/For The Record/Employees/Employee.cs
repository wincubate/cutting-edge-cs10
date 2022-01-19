namespace Wincubate.CS9.Data
{
    public record Employee(string FirstName, string LastName)
    {
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString() => $"{FullName} [{this.GetType().Name}]";
    }
}
