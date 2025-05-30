﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Intefaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
