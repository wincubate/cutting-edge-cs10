Money m1 = new(87, 25);
Money m2 = m1 with { Cents = 87 };
Console.WriteLine(m2);

var p1 = new { FirstName = "Bruce", LastName = "Wayne" };
var p2 = p1 with { LastName = "Campbell" };

Console.WriteLine(p2);

//Person person1 = new Person();
//Person person2 = person1 with { FirstName = "Dude" };
//class Person
//{
//    public string? FirstName { get; set; }
//    public string? LastName { get; set; }
//}