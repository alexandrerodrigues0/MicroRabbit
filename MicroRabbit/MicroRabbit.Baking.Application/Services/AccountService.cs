using System.Collections.Generic;
using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;

namespace MicroRabbit.Baking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}