Person person = new("Bruce", "Campbell");

//// Declaration and initialization of all new variables
//(string f, string l) = person;

//// ...or...

//// Assignment to all existing variables
//string f = string.Empty;
//string l = string.Empty;

//(f, l) = person;

//string f = string.Empty;
//(f, string l) = person;

record Person(string FirstName, string LastName)
{
    public string FullName => $"{FirstName} {LastName}";
}