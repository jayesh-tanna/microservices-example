using CalculatorService.ServerImpl;
using System;

namespace CalculatorService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculatorServer server = new CalculatorServer();
            server.Start();
            Console.WriteLine("Calculator service is listening...");
        }
    }
}