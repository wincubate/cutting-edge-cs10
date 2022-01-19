using System.Collections.Generic;

Dictionary<string, List<int>> field = new()
{
    { "item1", new() { 1, 2, 3 } } 
};

//var c1 = new Customer();
//Customer c2 = new()
//{
//    FirstName = "Jonas",
//    LastName = "Kahnwald"
//};



interface IPerson
{
    public string FullName { get; }
}

record Customer : IPerson
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public string FullName => $"{FirstName} {LastName}";
}