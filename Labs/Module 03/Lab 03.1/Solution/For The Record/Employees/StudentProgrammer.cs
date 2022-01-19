namespace Wincubate.CS9.Data
{
    public record StudentProgrammer(
        string FirstName,
        string LastName,
        Employee MentoredBy
    ) : Employee(FirstName,LastName)
    {
        public override string ToString() =>
            base.ToString() + ($" / Mentor: {MentoredBy}");
    }
}
