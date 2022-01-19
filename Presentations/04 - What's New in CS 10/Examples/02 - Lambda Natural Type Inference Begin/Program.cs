using System;

Func<string, int> parseToInt = (string s) => int.Parse(s);
int i = parseToInt("87");
Console.WriteLine(i);

Action<int> writeInt = (int i) => Console.WriteLine(i);
writeInt(176);