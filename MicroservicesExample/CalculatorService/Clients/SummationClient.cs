using Grpc.Core;
using SummationService.Generated;
using System;
using System.Threading.Tasks;
using static SummationService.Generated.SummationService;

namespace CalculatorService.Clients
{
    public class SummationClient : IDisposable
    {
        private SummationServiceClient _client;
        private Channel _channel;

        public SummationClient() : this("localhost", 33333)
        {
        }

        public SummationClient(string host, int port)
        {
            _channel = new Channel(host, port, ChannelCredentials.Insecure);
            _client = new SummationServiceClient(_channel);
        }

        public async Task<NumberRes> GetSumAsync(NumberReq req)
        {
            return await _client.SumAsync(req);
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

        ~SummationClient()
        {
            Dispose(false);
        }
    }
}