using Grpc.Core;
using MultiplicationService.ServiceImplementation;
using System.Threading.Tasks;

namespace MultiplicationService.ServerImpl
{
    public class MultiplicationServiceServer
    {
        private readonly Server _server;

        public MultiplicationServiceServer()
        {
            _server = new Server()
            {
                Services = { Generated.MultiplicationService.BindService(new MultiplicationServiceImpl()) },
                Ports = { new ServerPort("localhost", 22222, ServerCredentials.Insecure) }
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