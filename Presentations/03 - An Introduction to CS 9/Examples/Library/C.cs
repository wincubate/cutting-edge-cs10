using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Library
{
    public class C
    {
        private static string _fileName = @"C:\Tmp\Demo.txt";

        [ModuleInitializer]
        internal static void InitializeLogFile()
        {
            File.Delete(_fileName);
        }

        public static void Log(string s)
        {
            var log = $"{DateTime.Now}:\t{s}";
            File.AppendAllText(_fileName, log);
        }
    }
}