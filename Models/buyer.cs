using System;
using System.ComponentModel.DataAnnotations;

namespace BestBidEnergy.Models
{
    public class buyer
    {
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    
        [StringLengthAttribute(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Company { get; set; }
        [Required]
        [StringLengthAttribute(255)]
        public string AccountNum { get; set; }
        [Required]
        [StringLengthAttribute(255)]
        public string AccountType {get; }
        public int CreditRating {get; set;}
         [Required]
        [StringLengthAttribute(150)]
        public string ContactName {get; set;}
    }
}