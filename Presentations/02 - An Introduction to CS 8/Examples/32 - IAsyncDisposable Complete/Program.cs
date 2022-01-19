using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Wincubate.CS8.Slide32
{
    class Connection : IAsyncDisposable
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

        public async ValueTask DisposeAsync()
        {
            if (_isConnected)
            {
                await DisconnectAsync();
            }
        }
    }

    class Program
    {
        static async Task Main()
        {
            await using (var connection = new Connection())
            {
                await connection.ConnectAsync();

                // Do stuff...
            }
        }
    }
}
