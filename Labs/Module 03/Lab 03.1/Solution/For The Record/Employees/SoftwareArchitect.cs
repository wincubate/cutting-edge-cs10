namespace Wincubate.CS9.Data
{
    public record SoftwareArchitect(
        string FirstName,
        string LastName,
        Level? Level = default,
        int VisioDrawingsProduced = 0
    ) : Employee(FirstName,LastName)
    {
        public override string ToString() => base.ToString();
    }
}
