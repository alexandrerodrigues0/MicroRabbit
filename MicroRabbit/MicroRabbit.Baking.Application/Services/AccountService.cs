using System.Collections.Generic;
using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Baking.Application.Models;
using MicroRabbit.Baking.Domain.Commands;
using MicroRabbit.Baking.Domain.Interfaces;
using MicroRabbit.Baking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Baking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public Account GetAccount(int id)
        {
            return _accountRepository.GetAccount(id);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Update(Account account)
        {
            _accountRepository.Update(account);
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var accountFrom = GetAccount(accountTransfer.FromAccount);
            accountFrom.AccountBalance -= accountTransfer.TransferAmount;

            Update(accountFrom);

            var accountTo = GetAccount(accountTransfer.ToAccount);
            accountTo.AccountBalance += accountTransfer.TransferAmount;

            Update(accountTo);

            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount);

            _bus.SendCommand(createTransferCommand);
        }
    }
}