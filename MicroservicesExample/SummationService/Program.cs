using SummationService.ServerImpl;
using System;

namespace SummationService
{
    class Program
    {
        static void Main(string[] args)
        {
            SummationServiceServer server = new SummationServiceServer();
            server.Start();
            Console.WriteLine("Summation service is running...");
        }
    }
}
