using System.Runtime.CompilerServices;

Entity e = new();
e.DoStuff(out var x);

[SkipLocalsInit]
unsafe class Entity
{
    public void DoStuff(out int a)
    {
        // a will contain "non-zero'ed" memory if read here
        a = 87;
    }
}
