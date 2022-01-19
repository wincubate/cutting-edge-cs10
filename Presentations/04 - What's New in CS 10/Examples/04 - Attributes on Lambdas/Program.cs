// Attribute on lambda expression itself
Func<string, int> parse =[Developer("JGH")] (s) => int.Parse(s);

// Attribute on parameter
Action<string?> info = ([Developer("JGH")] s) => Console.WriteLine(s);

// Attribute on return type
Func<int, int> compute =[return: Developer("JGH")] (i) => i + 87;
