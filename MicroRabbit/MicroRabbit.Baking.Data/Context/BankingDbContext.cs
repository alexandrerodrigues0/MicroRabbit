using MicroRabbit.Baking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Baking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}