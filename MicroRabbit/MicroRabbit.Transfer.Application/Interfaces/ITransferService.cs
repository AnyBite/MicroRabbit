using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
