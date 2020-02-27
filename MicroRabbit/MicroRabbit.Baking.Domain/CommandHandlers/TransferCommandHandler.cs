using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Baking.Domain.CommandHandlers
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
            //Publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));

            return Task.FromResult(true);
        }
    }
}