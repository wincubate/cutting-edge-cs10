Money m = new(87, 25);

record struct Money(int Euro, int Cents)
{
    public int TotalCents => Euro * 100 + Cents;
}