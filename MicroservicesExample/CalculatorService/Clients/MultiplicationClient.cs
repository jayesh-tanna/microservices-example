using Grpc.Core;
using MultiplicationService.Generated;
using System.Threading.Tasks;
using static MultiplicationService.Generated.MultiplicationService;

namespace CalculatorService.Clients
{
    //IDisposable
    public class MultiplicationClient
    {
        private readonly MultiplicationServiceClient _client;
        private readonly Channel _channel;

        //parameterized constructor
        public MultiplicationClient()
        {
            _channel = new Channel("localhost", 22222, ChannelCredentials.Insecure);
            _client = new MultiplicationServiceClient(_channel);
        }

        public async Task<NumberRes> GetMultiplicationAsync(NumberReq numberReq)
        {
            return await _client.MultiplyAsync(numberReq);
        }
    }
}