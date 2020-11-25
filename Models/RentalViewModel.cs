using System;
using System.ComponentModel.DataAnnotations;
namespace rentManagementMVC.Models
{
    public class RentalViewModel
    {
        [Required]
        public int Apartment { get; set; }
        [Required]
        public int Unit { get; set; }
        [Required]
        public double NumberOfRoom { get; set; }
        [Required]
        public double Cost { get; set; } 

        public bool IsAssigned { get; set; } 
    }
}
