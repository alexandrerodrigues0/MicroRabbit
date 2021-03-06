﻿using System.Collections;
using System.Collections.Generic;
using MicroRabbit.Baking.Data.Context;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;

namespace MicroRabbit.Baking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public Account GetAccount(int id)
        {
            return _ctx.Accounts.Find(id);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }

        public void Update(Account account)
        {
            _ctx.Update(account);
            _ctx.SaveChanges();
        }
    }
}