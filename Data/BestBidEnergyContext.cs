using Microsoft.EntityFrameworkCore;
using BestBidEnergy.Models;

namespace BestBidEnergy.Data
{ public class BestBidEnergyContext : DbContext  
   {    

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
  {            
      string connection = "User ID=bbe-admin;Password=admin ;Host=localhost;Port=5432;Database=<YOUR DATABASE NAME HERE>;Pooling=true;";
    optionsBuilder.UseNpgsql(connection); 
            }
public DbSet<auction> Auction { get; set; }

   }}