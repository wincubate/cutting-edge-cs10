var parseToInt = (string s) => int.Parse(s);
int i = parseToInt("87");
Console.WriteLine(i);

var writeInt = (int i) => Console.WriteLine(i);
//var writeInt = (ref int i) => Console.WriteLine(i);
writeInt(i);
