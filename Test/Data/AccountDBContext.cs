using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
    public class AccountDBContext : DbContext{
        public AccountDBContext (DbContextOptions<AccountDBContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account {get; set;}

    }
}