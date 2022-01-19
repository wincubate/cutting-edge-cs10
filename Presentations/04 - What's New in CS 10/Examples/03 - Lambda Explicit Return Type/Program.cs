Func<bool,object> choose = (bool b) => b ? 1 : "two";

Console.WriteLine(choose(false));


