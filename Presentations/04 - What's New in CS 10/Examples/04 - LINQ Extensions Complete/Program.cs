using Wincubate.CS10.Data;

//IEmployeeRepository repository = new EmployeeRepository();

//var query = repository
//    .GetAll()
//    .Where(e => e is SoftwareEngineer)
//    .ToList();
//    ;


//if (query.TryGetNonEnumeratedCount(out int count))
//{
//    Console.WriteLine( $"We could figure out the count without evaluating: {count}");
//}
//else
//{
//    Console.WriteLine("Need to evaluate :-(");
//}

string[] players = { "Salah", "de Bruyne", "Ødegaard", "Nørgaard" };
string[] clubs = { "Liverpool", "Manchester City", "Arsenal", "Brentford" };
int[] rating = { 9, 8, 4, 7 };

IEnumerable<(string player, string club, int rating)> query = players.Zip(clubs, rating);
foreach (var t in query)
{
    Console.WriteLine($"{t.player} from {t.club} has a rating of {t.rating}");
}
