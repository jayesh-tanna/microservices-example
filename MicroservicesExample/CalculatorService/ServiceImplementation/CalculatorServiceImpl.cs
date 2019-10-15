using CalculatorService.Clients;
using CalculatorService.Generated;
using Grpc.Core;
using System.Threading.Tasks;
using static CalculatorService.Generated.CalculatorService;

namespace CalculatorService
{
    public class CalculatorServiceImpl : CalculatorServiceBase
    {
        public override async Task<NumberResponse> Calculate(NumberRequest request, ServerCallContext context)
        {
            var response = new NumberResponse();
            if (request.Calcoption == CalculationOption.Sum)
            {
                //DI
                var sumClient = new SummationClient();
                var result = await sumClient.GetSumAsync(new SummationService.Generated.NumberReq() { Number = request.Number });
                response.Number = result.Number;
            }
            else
            {
                //DI
                var multiplyClient = new MultiplicationClient();
                var result = await multiplyClient.GetMultiplicationAsync(new MultiplicationService.Generated.NumberReq() { Number = request.Number });
                response.Number = result.Number;
            }
            return response;
        }
    }
}