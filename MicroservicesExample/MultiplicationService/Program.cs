using MultiplicationService.ServerImpl;
using System;

namespace MultiplicationService
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationServiceServer server = new MultiplicationServiceServer();
            server.Start();
            Console.WriteLine("Multiplication service is running");
        }
    }
}
