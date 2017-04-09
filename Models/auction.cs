using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestBidEnergy.Models
{
    [Table("AUCTION")]
    public class auction
    {
        [Required]
        [Key]
        public int AuctionID { get; set; }
    
        public DateTime AuctionTime {get; set; }
        [Required]
        public int ContractID { get; set; }
    }
}