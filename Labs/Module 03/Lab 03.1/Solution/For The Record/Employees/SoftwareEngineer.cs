namespace Wincubate.CS9.Data
{
    public record SoftwareEngineer(
        string FirstName,
        string LastName,
        Level? Level = default,
        int CodeLinesProduced = 0)
    : Employee(FirstName,LastName)
    {
        public override string ToString() => base.ToString();
    }
}