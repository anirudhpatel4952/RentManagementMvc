using System;
using System.ComponentModel.DataAnnotations;
namespace rentManagementMVC.Models
{
    public class TenantViewModel
    {
        
        public Guid TenantId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        
        public string LastName { get; set; }
        
        public string FullName { get { return FirstName + " " + LastName; } }
        
        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string IdProof { get; set; }
        
        [Required]
        public double Deposit { get; set; }
        

        public bool IsAssigned { get; set; }
    }
}
