using Bank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bank.Utils;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Bank.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Contexts
{
    public class BankDbContext : IdentityDbContext<Worker>
    {
        DbSet<Worker> WorkerSet{get; set;}
        DbSet<Client> ClientSet{get; set;}
        DbSet<Deposit> DepositSet{get; set;}
        DbSet<Credit> CreditSet{get; set;}
        
        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                foreach (var property in entityType.GetProperties())
                    if (property.ClrType == typeof(bool) || property.ClrType == typeof(Boolean))
                        property.SetValueConverter(new BoolToZeroOneConverter<Int16>());
                    else if (property.ClrType == typeof(Nullable<bool>) || property.ClrType == typeof(Nullable<Boolean>))
                        property.SetValueConverter(new BoolToZeroOneConverter<Nullable<Int16>>());
        }

        public async Task AddClient(Client client)
        {
            client.Id = await ClientSet.CountAsync() + 1;
            ClientSet.Add(client);
            SaveChanges();
        }

        public async Task<List<Client>> GetAllClients()
        {
            List<Client> clients = await ClientSet.Where(i => (!i.Deleted)).ToListAsync();
            return clients; 
        }

        public async Task<Client> GetClientById(int id)
        {
            return await ClientSet.FindAsync(id);
        }

        public void UpdateClient(Client client)
        {
            ClientSet.Update(client);
            SaveChanges();
        }

        public async Task AddDeposit(Deposit dep)
        {
            dep.Id = await DepositSet.CountAsync() + 1;
            DepositSet.Add(dep);
            SaveChanges();
        }

        public async Task<List<Deposit>> GetUserDeposits(int id)
        {
            List<Deposit> deps = await DepositSet.Where(i => (!i.Closed && i.IdClient == id)).ToListAsync();
            return deps;
        }

        public async Task AddCredit(Credit cr)
        {
            cr.Id = await CreditSet.CountAsync() + 1;
            CreditSet.Add(cr);
            SaveChanges();
        }

        public async Task<List<Credit>> GetUserCredits(int id)
        {
            List<Credit> crs = await CreditSet.Where(i => (!i.Closed && i.IdClient == id)).ToListAsync();
            return crs;
        }
    }
}