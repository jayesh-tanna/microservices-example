using CalculatorService.Generated;
using Grpc.Core;
using System.Threading.Tasks;
using static CalculatorService.Generated.CalculatorService;

namespace CalculatorService
{
    public class CalculatorServiceImpl : CalculatorServiceBase
    {
        public override Task<NumberResponse> Calculate(NumberRequest request, ServerCallContext context)
        {
            if (request.Calcoption == CalculationOption.Sum)
            {

            }
            return base.Calculate(request, context);
        }
    }
}