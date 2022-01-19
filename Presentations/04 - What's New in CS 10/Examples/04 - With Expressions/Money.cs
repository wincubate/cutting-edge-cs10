
struct Money
{
    public int Euro { get; set; }
    public int Cents { get; set; }
    public int TotalCents => Euro * 100 + Cents;

    public override string ToString() => $"EUR {Euro}.{Cents:d2}";

    public Money()
    {
        Euro = 1;
        Cents = 0;
    }

    public Money(int euro, int cents)
    {
        Euro = euro;
        Cents = cents;
    }
}