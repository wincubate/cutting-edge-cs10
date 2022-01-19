List<Company> companies = new()
{
    new("Patterns Inc.",
        new("Expressions 'r Us",
            new("Sharp10")
        )
    ),
    new("Funky Rules Ltd.",
        new("Full Contact Code",
            new("Javanese Script")
        )
    ),
    new("World Records Structs",
        new("Ooooooh-bject Oriented Goodies",
            new("Sharp10")
        )
    )
};

//var query = companies
//    .Where(c => c is { OwnedBy: { OwnedBy: { Name: "Sharp10" } } })
//    ;

//foreach (var company in query)
//{
//    Console.WriteLine(company.Name);
//}

record class Company(string Name, Company? OwnedBy = default);