using Microsoft.EntityFrameworkCore;
using BestBidEnergy.Models;

namespace BestBidEnergy.Data
{ public class BestBidEnergyContext : DbContext  
   {    

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connection = "User ID=bbe-admin;Password=BestBidEnergy3610 ;Server=bestbidenergy.database.windows.net;Port=1433;Database=BestBidEnergy;Pooling=true;";
            string connection = "Server=tcp:bestbidenergy.database.windows.net,1433;Initial Catalog=BestBidEnergy;Persist Security Info=False;User ID=bbe-admin;Password=BestBidEnergy3610;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<auction> Auction { get; set; }
        public DbSet<buyer> Buyer {get; set;}
        public DbSet<contracts> Contracts {get;set;}
        public DbSet<supplier> Supplier {get; set;}
    }
   }