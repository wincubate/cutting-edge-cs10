using FileStream inStream = File.OpenRead(@"..\..\..\Files\devs.compressed");
using MemoryStream outStream = new();
using DeflateStream uncompress = new(inStream, CompressionMode.Decompress);

int i = 0;
while ((i = uncompress.ReadByte()) != -1)
{
    outStream.WriteByte((byte)i);
}

outStream.Position = 0;
using StreamReader sr = new(outStream);

var devs = JsonSerializer
    .Deserialize<List<Developer>>(await sr.ReadToEndAsync())
    ?? new();

foreach (Developer dev in devs
    .OrderByDescending(d => d.Amount.TotalCentipedes))
{
    WriteLine(dev);
}
