using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using rentManagement;
using rentManagement.Models;
using rentManagement.Storage;
namespace rentManagementMVC.Models
{
    public class SearchViewModel
    {
        public List<Tenant> SearchResults { get; set; }
        
        public string FirstName { get; set; }
    }
}
