using MicroRabbit.Banking.Domain.Intefaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository) 
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Ammount
            });
            return Task.CompletedTask;
        }
    }
}
