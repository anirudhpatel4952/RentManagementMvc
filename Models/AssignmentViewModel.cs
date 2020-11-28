using System;
using rentManagement;
using rentManagement.Models;
using rentManagement.Storage;
using System.ComponentModel.DataAnnotations;

namespace rentManagementMVC.Models
{
    public class AssignmentViewModel
    {
        [Required]
        public Guid TenantId { get; set; }

        [Required]
        public int Unit { get; set; }

        public string FullName { get; set; }
    }
}