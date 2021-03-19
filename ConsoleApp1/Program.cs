using Grpc.Net.Client;
using GrpcHandsOn.Protos;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("http:localhost:5000");
            var client = new Brooker.BrookerClient(channel);
            var response = client.SendEmail(new Brookerequest());
        }
    }
}
