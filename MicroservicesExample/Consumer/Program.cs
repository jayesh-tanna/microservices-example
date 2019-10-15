using Consumer.Clients;
using System;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Calc().GetAwaiter().GetResult();
            Console.WriteLine(res);
        }

        static async Task<int> Calc()
        {
            CalcServiceClient client = new CalcServiceClient();
            var result = await client.CalcAsync(new CalculatorService.Generated.NumberRequest() { Number = 5, Calcoption = CalculatorService.Generated.CalculationOption.Sum });
            return result.Number;
        }
    }
}
