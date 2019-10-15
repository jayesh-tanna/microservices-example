using System;

namespace CalculatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServer server = new CalculatorServer();
            server.Listen();
            Console.WriteLine("Calculator service is listening...");
        }
    }
}
