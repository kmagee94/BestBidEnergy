using System;
using System.ComponentModel.DataAnnotations;

namespace BestBidEnergy.Models
{
    public class supplier
    {
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string AccountNum { get; set; }
        [Required]
        [StringLength(255)]
        public string Company { get; set; }
        
    }
}