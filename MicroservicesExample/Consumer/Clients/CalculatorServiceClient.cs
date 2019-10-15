using CalculatorService.Generated;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using static CalculatorService.Generated.CalculatorService;

namespace Consumer.Clients
{
    public class CalcServiceClient : IDisposable
    {
        private CalculatorServiceClient _client;
        private Channel _channel;

        public CalcServiceClient() : this("localhost", 11111)
        {
        }

        public CalcServiceClient(string host, int port)
        {
            _channel = new Channel(host, port, ChannelCredentials.Insecure);
            _client = new CalculatorServiceClient(_channel);
            
        }

        public async Task<NumberResponse> CalcAsync(NumberRequest req)
        {
            return await _client.CalculateAsync(req);
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
            ShutdownAsync();
        }

        private async Task ShutdownAsync()
        {
            if (_channel != null)
            {
                await _channel.ShutdownAsync();
                _channel = null;
            }
        }

        ~CalcServiceClient()
        {
            Dispose(false);
        }
    }
}