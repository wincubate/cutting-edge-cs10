using System;
using System.Diagnostics;

[Conditional("DEBUG")]
static void PrintInfo(string s) => Console.WriteLine($"Debug: {s}");

PrintInfo("Start");
Console.WriteLine("Info: Program is running...");
PrintInfo("Stop");
