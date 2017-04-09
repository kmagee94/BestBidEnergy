using System;
using System.ComponentModel.DataAnnotations;

namespace BestBidEnergy.Models
{
    public class auction
    {
        [Required]
        public int AuctionID { get; set; }
    
        public DateTime AuctionTime {get; set; }
        [Required]
        public int ContractID { get; set; }
    }
}