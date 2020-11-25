using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rentManagementMVC.Models;
using rentManagement;
using rentManagement.Models;
using rentManagement.Storage;

namespace rentManagementMVC.Controllers
{
    public class TenantController : Controller
    {
        private RentManagementSystem _rentManagementSystem;
        public TenantController(RentManagementSystem rentManagementSystem)
        {
            _rentManagementSystem = rentManagementSystem;
        }

        //Get tenants/Index
        public IActionResult Index()
        {
            var tenants = _rentManagementSystem.PrintAllTenants();
            //call the RentManagementSytem
            //Get the list of all tenants
            //Pass it to the view
            return View(tenants);
        }
        public IActionResult Form(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(TenantViewModel newTenant)
        {
            if(ModelState.IsValid){
            var tenantToAdd = new Tenant(){
                TenantId = newTenant.TenantId,
                FirstName = newTenant.FirstName,
                LastName = newTenant.LastName,
                Address = newTenant.Address,
                PostalCode = newTenant.PostalCode,
                City = newTenant.City,
                IdProof = newTenant.IdProof,
                Deposit = newTenant.Deposit,
                IsAssigned = false
            };
            _rentManagementSystem.AddTenant(tenantToAdd);
            return RedirectToAction("Index");
            }
            else {
                return View("Form", newTenant);
            }
            //redirect to the index action
        }
        public IActionResult Details(Guid id){
            var tenants = _rentManagementSystem.PrintAllTenants();
            var tenantToView = tenants.Find(x => x.TenantId == id);
            return View(tenantToView);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
