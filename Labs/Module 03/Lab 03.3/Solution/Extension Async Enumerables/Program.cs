using System;
using System.Collections.Generic;
using Wincubate.CS9.ExtensionAsyncEnumerableLab;

List<string> urls = new()
{
    "http://www.dr.dk",
    "http://www.jp.dk",
    "http://www.bold.dk"
};

await foreach (var urlResult in urls)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"=== [{urlResult.Url}] ===");
    Console.ResetColor();

    Console.WriteLine( urlResult.Contents.Substring(0, 240));
}
