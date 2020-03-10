using System.Collections.Generic;
using MicroRabbit.Baking.Application.Models;
using MicroRabbit.Baking.Domain.Models;

namespace MicroRabbit.Baking.Application.Interfaces
{
    public interface IAccountService
    {
        Account GetAccount(int id);

        IEnumerable<Account> GetAccounts();

        void Update(Account account);

        void Transfer(AccountTransfer accountTransfer);
    }
}