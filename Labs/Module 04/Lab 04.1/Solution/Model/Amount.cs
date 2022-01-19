namespace Wincubate.Labs04.Model;

readonly record struct Amount(int DevDollars, int Centipedes)
{
    public override string ToString() => $"DEV$ {DevDollars}.{Centipedes:d2}";

    public int TotalCentipedes => 100 * DevDollars + Centipedes;
}
