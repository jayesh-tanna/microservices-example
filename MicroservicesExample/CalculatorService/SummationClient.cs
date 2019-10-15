using Grpc.Core;
using System.Threading.Tasks;
using static SummationService.Generated.SummationService;
using SummationService.Generated;

namespace CalculatorService
{
    public class SummationClient
    {
        private SummationServiceClient _client;
        private Channel _channel;

        public void Connect()
        {
            _channel = new Channel("localhost", 22222, ChannelCredentials.Insecure);
            _client = new SummationServiceClient(_channel);
        }

        public async Task<NumberRes> Sum(int id)
        {
            var res = (await _client.Sum(new NumberReq() { Number = id })).Number;

        }

        public async Task ShutDownAsync()
        {
            await _channel.ShutdownAsync();
        }
    }
}