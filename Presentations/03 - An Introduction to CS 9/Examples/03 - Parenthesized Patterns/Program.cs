using System;

C c = new();
Console.WriteLine(c.WhatIsIt("Hello world"));
Console.WriteLine(c.WhatIsIt(42));
Console.WriteLine(c.WhatIsIt(8.7));


class C
{
    public string WhatIsIt(object o) =>
        o switch
        {
            (((string))) => "string",
            (((int))) => "int",
            _ => "Something else :-)",
        };
}
