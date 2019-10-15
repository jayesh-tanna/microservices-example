using Grpc.Core;
using MultiplicationService.Generated;
using System;
using System.Threading.Tasks;
using static MultiplicationService.Generated.MultiplicationService;

namespace CalculatorService.Clients
{
    public class MultiplicationClient : IDisposable
    {
        private MultiplicationServiceClient _client;
        private Channel _channel;

        public MultiplicationClient() : this("localhost", 22222)
        {
        }

        public MultiplicationClient(string host, int port)
        {
            _channel = new Channel(host, port, ChannelCredentials.Insecure);
            _client = new MultiplicationServiceClient(_channel);
        }

        public async Task<NumberRes> GetMultiplicationAsync(NumberReq numberReq)
        {
            return await _client.MultiplyAsync(numberReq);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool state)
        {
            if (state)
                _client = null;
            ShutdownAsync().Wait();
        }

        private async Task ShutdownAsync()
        {
            if (_channel != null)
            {
                await _channel.ShutdownAsync();
                _channel = null;
            }
        }

        ~MultiplicationClient()
        {
            Dispose(false);
        }
    }
}