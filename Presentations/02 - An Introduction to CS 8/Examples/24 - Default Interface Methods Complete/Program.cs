using System;

namespace Wincubate.CS8.Slide24
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger(@"C:\Tmp\log.txt");

            logger.Log(LogLevel.Info, "Program started!");
            logger.Log(LogLevel.Debug, "Not really exciting");
            logger.Log(LogLevel.Error, "Houston, we have a problem...");

            try
            {
                Console.WriteLine(int.Parse("Argh!"));
            }
            catch(Exception exception)
            {
                logger.Log(exception);
            }

            logger.Log(LogLevel.Info, "Stopping program");
        }
    }
}
