using System;
using System.IO;
using System.IO.Compression;

namespace Wincubate.CS8.Slide36
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Tmp\log.txt";
            string destinationFilePath = $"{sourceFilePath}.compressed";

            // Compress
            using FileStream inStream = File.OpenRead(sourceFilePath);
            using FileStream outStream = File.Create(destinationFilePath);
            using DeflateStream compress = new DeflateStream(outStream, CompressionMode.Compress);
            for (int i = 0; i < inStream.Length; i++)
            {
                compress.WriteByte((byte)inStream.ReadByte());
            }

            Console.WriteLine("Operation completed!");
        }
    }
}