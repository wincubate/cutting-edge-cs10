using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using Wincubate.Labs04.Model;

namespace Wincubate.Labs04.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Developer> devs;

            // Uncompress
            using (FileStream inStream = File.OpenRead(@"..\..\..\Files\devs.compressed"))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    using (DeflateStream uncompress = new DeflateStream(inStream, CompressionMode.Decompress))
                    {
                        int i = 0;
                        while ((i = uncompress.ReadByte()) != -1)
                        {
                            outStream.WriteByte((byte)i);
                        }
                    }

                    outStream.Position = 0;
                    using (StreamReader sr = new StreamReader(outStream))
                    {
                        var json = sr.ReadToEndAsync().Result;
                        devs = JsonSerializer.Deserialize<List<Developer>>(json);
                    }
                }
            }

            var query = devs
                .OrderByDescending(d => d.Amount.TotalCentipedes)
                ;
            foreach (Developer dev in query)
            {
                System.Console.WriteLine(dev);
            }
        }
    }
}