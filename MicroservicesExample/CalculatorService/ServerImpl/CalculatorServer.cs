using Grpc.Core;
using System.Threading.Tasks;

namespace CalculatorService.ServerImpl
{
    public class CalculatorServer
    {
        private readonly Server _server;

        public CalculatorServer()
        {
            _server = new Server()
            {
                Services = { Generated.CalculatorService.BindService(new CalculatorServiceImpl()) },
                Ports = { new ServerPort("localhost", 11111, ServerCredentials.Insecure) }
            };
        }

        public void Listen()
        {
            _server.Start();
        }

        public async Task ShutDownAsync()
        {
            await _server.ShutdownAsync();
        }
    }
}