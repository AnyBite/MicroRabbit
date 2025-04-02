using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Intefaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Repository
{
    public class TransferRepository :  ITransferRepository
    {
        private TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.Add(transferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
