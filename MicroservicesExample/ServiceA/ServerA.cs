using Grpc.Core;
using ServiceA.Generated;
using System.Threading.Tasks;

namespace ServiceA
{
    public class ServerA
    {
        private readonly Server _server;

        public ServerA()
        {
            _server = new Server()
            {
                Services = { AReqResService.BindService(new ServiceAImpl()) },
                Ports = { new ServerPort("localhost", 1234, ServerCredentials.Insecure) }
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