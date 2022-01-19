using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Wincubate.CS8.Slide32
{
    class Connection : IDisposable
    {
        private bool _isConnected;

        public Task ConnectAsync()
        {
            // Do stuff...
            _isConnected = true;

            return Task.CompletedTask;
        }

        public Task DisconnectAsync()
        {
            // Do stuff...
            _isConnected = false;

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            if( _isConnected )
            {
                // Argh!!!
                DisconnectAsync()
                    .GetAwaiter()
                    .GetResult()
                    ;
            }
        }
    }

    class Program
    {
        static async Task Main()
        {
            using( var connection = new Connection())
            {
                await connection.ConnectAsync();

                // Do stuff...
            }
        }
    }
}
