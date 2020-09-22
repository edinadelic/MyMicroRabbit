using MediatR;
using MyMicroRabbit.Banking.Domain.Commands;
using MyMicroRabbit.Banking.Domain.Events;
using MyMicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyMicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Ammount));

            //Publish event to RabbitMQ
            return Task.FromResult(true);
        }
    }
}
