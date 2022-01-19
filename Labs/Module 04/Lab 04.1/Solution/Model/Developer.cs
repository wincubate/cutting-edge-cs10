namespace Wincubate.Labs04.Model;

record class Developer(string FirstName, string LastName, Amount Amount)
{
    public string FullName => $"{FirstName} {LastName}";
    public override string ToString() => $"{FullName} [{Amount}]";
}
