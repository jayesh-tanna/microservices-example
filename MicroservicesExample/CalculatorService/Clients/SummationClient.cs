using Grpc.Core;
using SummationService.Generated;
using System.Threading.Tasks;
using static SummationService.Generated.SummationService;

namespace CalculatorService
{
    public class SummationClient
    {
        private readonly SummationServiceClient _client;
        private readonly Channel _channel;

        public SummationClient()
        {
            _channel = new Channel("localhost", 33333, ChannelCredentials.Insecure);
            _client = new SummationServiceClient(_channel);
        }

        public async Task<NumberRes> GetSumAsync(NumberReq req)
        {
            return await _client.SumAsync(req);
        }
    }
}