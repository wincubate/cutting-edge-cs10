using System;

Func<int, int, int?> add = (x, y) => x + y;
Func<int, int, int?> nullFunction = (_, _) => 0;

Console.WriteLine(add(42, 87));
Console.WriteLine(nullFunction(42, 87));
