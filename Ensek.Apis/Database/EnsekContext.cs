using Ensek.Apis.Models;
using Microsoft.EntityFrameworkCore;

namespace Ensek.Apis
{

    public class EnsekContext : DbContext
    {
        public EnsekContext(DbContextOptions<EnsekContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }

    }
}
