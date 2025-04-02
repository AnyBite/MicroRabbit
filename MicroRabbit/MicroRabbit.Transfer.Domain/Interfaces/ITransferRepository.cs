using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Intefaces
{
    public interface ITransferRepository
    {
        void Add(TransferLog transferLog);
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
