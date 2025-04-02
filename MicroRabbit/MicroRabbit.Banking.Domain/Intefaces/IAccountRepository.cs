using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Intefaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
