using Grpc.Core;
using MultiplicationService.Generated;
using System;
using System.Threading.Tasks;
using static MultiplicationService.Generated.MultiplicationService;

namespace MultiplicationService.ServiceImplementation
{
    public class MultiplicationServiceImpl : MultiplicationServiceBase
    {
        public override Task<NumberRes> Multiply(NumberReq request, ServerCallContext context)
        {
            var numberResponse = new NumberRes
            {
                Number = (int)Math.Pow(request.Number, 2)
            };

            return Task.FromResult(numberResponse);
        }
    }
}