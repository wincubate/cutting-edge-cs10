Money m1 = new(87, 25);
//Money m2 = new(87, 25);
//Console.WriteLine(m1 == m2);
//Console.WriteLine(ReferenceEquals(m1,m2));

Money m3 = m1 with { Cents = 0 };

Console.WriteLine(m3.TotalCents);

(int euro, int cents) = m3;
Console.WriteLine(euro);

record struct Money(int Euro, int Cents)
{
    public int TotalCents => Euro * 100 + Cents;
}
