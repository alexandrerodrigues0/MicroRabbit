using System.Collections.Generic;
using MicroRabbit.Baking.Domain.Models;

namespace MicroRabbit.Baking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Account GetAccount(int id);

        IEnumerable<Account> GetAccounts();

        void Update(Account account);
    }
}