using Grpc.Core;
using SummationService.ServiceImplementation;
using System.Threading.Tasks;

namespace SummationService.ServerImpl
{
    public class SummationServiceServer
    {
        private readonly Server _server;

        public SummationServiceServer()
        {
            _server = new Server()
            {
                Services = { Generated.SummationService.BindService(new SummationServiceImpl()) },
                Ports = { new ServerPort("localhost", 33333, ServerCredentials.Insecure) }
            };
        }

        public void Start()
        {
            _server.Start();
        }

        public async Task ShutdownAsync()
        {
            await _server.ShutdownAsync();
        }
    }
}