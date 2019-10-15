using CalculatorService.Generated;
using Grpc.Core;
using System.Threading.Tasks;
using static CalculatorService.Generated.CalculatorService;

namespace Consumer.Clients
{
    //IDisposable
    public class CalcServiceClient
    {
        private readonly CalculatorServiceClient _client;
        private readonly Channel _channel;

        public CalcServiceClient()
        {
            _channel = new Channel("localhost", 11111, ChannelCredentials.Insecure);
            _client = new CalculatorServiceClient(_channel);
        }

        public async Task<NumberResponse> CalcAsync(NumberRequest req)
        {
            return await _client.CalculateAsync(req);
        }
    }
}