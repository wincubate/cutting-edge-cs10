﻿using System;
using System.IO;

namespace Wincubate.CS8.Slide25
{
    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void Log(LogLevel level, string message)
        {
            switch (level)
            {
                case LogLevel.Error:
                    WriteToFile("ERROR -- ", message);
                    break;
                case LogLevel.Info:
                    WriteToFile("INFO  -- ", message);
                    break;
                default:
                case LogLevel.Debug:
                    WriteToFile("      -- ", message);
                    break;
            }
        }

        private void WriteToFile(string prepend, string message)
        {
            File.AppendAllText(_path, $"{prepend}{message}{Environment.NewLine}");
        }
    }
}
