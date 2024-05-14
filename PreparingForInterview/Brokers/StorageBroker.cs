using Microsoft.EntityFrameworkCore;
using PreparingForInterview.Models;
using STX.EFxceptions.SQLite;

namespace PreparingForInterview.Brokers
{
    public class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public DbSet<Client> Client { get; set; }

        public StorageBroker() =>
            this.Database.EnsureCreated();

        public async ValueTask<Client> InsertClientAsync(Client client)
        {
            await this.Client.AddAsync(client);
            await this.SaveChangesAsync();

            return client;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = Test");
        }
    }
}
