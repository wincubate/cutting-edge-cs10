Money m = new(87, 25);
//m.Euro = 176;

record Money(int Euro, int Cents)
{
    public int TotalCents => Euro * 100 + Cents;
}
