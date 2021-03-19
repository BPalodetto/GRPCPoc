using Grpc.Core;
using GrpcHandsOn.DomainService;
using GrpcHandsOn.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcHandsOn.Services
{
    public class BrookerServiceGrpc : Brooker.BrookerBase
    {
        private readonly IEmailService _emailService;
        public BrookerServiceGrpc(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async override Task<Protos.HelloReply> SendEmail(Brookerequest request, ServerCallContext context)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }

        }
    }
}
