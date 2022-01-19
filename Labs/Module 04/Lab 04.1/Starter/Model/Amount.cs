namespace Wincubate.Labs04.Model
{
    readonly struct Amount
    {
        public int DevDollars { get; init; }
        public int Centipedes { get; init; }

        public override string ToString() => $"DEV$ {DevDollars}.{Centipedes:d2}";

        public void Deconstruct(out int devDollars, out int centipedes)
        {
            devDollars = DevDollars;
            centipedes = Centipedes;
        }

        public int TotalCentipedes => 100 * DevDollars + Centipedes;
    }
}