using Grpc.Core;
using ServiceA.Generated;
using System.Threading.Tasks;
using static ServiceA.Generated.AReqResService;

namespace ServiceA
{
    public class ServiceAImpl : AReqResServiceBase
    {
        public override Task<AResponse> GetADetails(ARequest request, ServerCallContext context)
        {
            return base.GetADetails(request, context);
        }
    }
}