using System;
using System.ComponentModel.DataAnnotations;
namespace rentManagementMVC.Models
{
    public class RentalViewModel
    {
        public int Apartment { get; set; }
        
        public int Unit { get; set; }
        
        public double NumberOfRoom { get; set; }
        
        public double Cost { get; set; } 

        public bool IsAssigned { get; set; } 
    }
}
