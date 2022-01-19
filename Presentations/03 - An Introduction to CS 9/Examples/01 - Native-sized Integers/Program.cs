using System;

int x = 42;
Console.WriteLine(x);
Console.WriteLine(sizeof(int));

Console.WriteLine();

unsafe
{
    nint y = 87;
    Console.WriteLine(y);
    Console.WriteLine(sizeof(nint));
}
