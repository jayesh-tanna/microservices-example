using Grpc.Core;
using SummationService.Generated;
using System.Threading.Tasks;
using static SummationService.Generated.SummationService;

namespace SummationService.ServiceImplementation
{
    public class SummationServiceImpl : SummationServiceBase
    {
        public override Task<NumberRes> Sum(NumberReq request, ServerCallContext context)
        {
            var response = new NumberRes() { Number = request.Number * 2 };

            return Task.FromResult(response);
        }
    }
}