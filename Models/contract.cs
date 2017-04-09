using System;
using System.ComponentModel.DataAnnotations;

namespace BestBidEnergy.Models
{
    public class contract
    {
        [Required]
        [MaxLength(1000000)]        
        public int ContractId { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyerUsername { get; set; }
        public string SupplierUsername { get; set; }
        [Required]
        public decimal Price { get; set; }
         [Required]
        [StringLength(255)]
        public string Street { get; set; }
       [Required]
       [StringLength(255)]
        public string City {get; set;}
        [Required]
        [StringLength(40)]
        public string State {get; set;}
       [Required]
       [StringLength(40)]
        public string Zip {get; set;}
        [Required]
        [StringLength(5)]
        public string UtilityArea{get; set;}
        [Required]
        [StringLength(255)]
        public DateTime StartDate {get; set;}
        [Required]
        public DateTime EndDate {get; Set;}
        [Required]
        public decimal AvgkWh {get; set;}
        [Required]
        [StringLength(255)]
        public string UtilityAccount {get; set;}
        
    }   
}