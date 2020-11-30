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
            ViewBag.IsEditing = false;
            return View();
        }

        public IActionResult Details(Guid id){
            var tenants = _rentManagementSystem.SearchForTenants(id);
            return View(tenants);
        }

        public IActionResult Edit(Guid id){
            //get the tenant from rentmanagement
            var tenant = _rentManagementSystem.SearchForTenants(id);
            //build the viewmodel
            var tenantViewModel = new TenantViewModel(){
                TenantId = tenant.TenantId,
                FirstName = tenant.FirstName,
                LastName = tenant.LastName,
                Address = tenant.Address,
                City = tenant.City,
                PostalCode = tenant.PostalCode,
                IdProof = tenant.IdProof,
                Deposit = tenant.Deposit,
                IsAssigned = false
            };
            //send the view model
            ViewBag.IsEditing = true;
            return View("Form", tenantViewModel);
        }

        public IActionResult Remove(Guid id){
            var tenant = _rentManagementSystem.SearchForTenants(id);
            var tenantViewModel = new TenantViewModel(){
                TenantId = tenant.TenantId,
                FirstName = tenant.FirstName,
                LastName = tenant.LastName,
                Address = tenant.Address,
                City = tenant.City,
                PostalCode = tenant.PostalCode,
                IdProof = tenant.IdProof,
                Deposit = tenant.Deposit,
                IsAssigned = tenant.IsAssigned
            };
            return View("Delete", tenantViewModel);
        }

        [HttpPost]
        public IActionResult Update(TenantViewModel updatedTenant){
            //convert it to rentManagement.models.tenant
                var tenant = new Tenant(){
                    TenantId = updatedTenant.TenantId,
                    FirstName = updatedTenant.FirstName,
                    LastName = updatedTenant.LastName,
                    Address = updatedTenant.Address,
                    City = updatedTenant.City,
                    PostalCode = updatedTenant.PostalCode,
                    IdProof = updatedTenant.IdProof,
                    Deposit = updatedTenant.Deposit,
                    IsAssigned = false
                };
                ViewBag.IsEditing = true;
                _rentManagementSystem.UpdateTenant(tenant);
                //call edit on the tenant
                //redirect to index page
                return RedirectToAction("Index");
            
            }

        [HttpPost]
        public IActionResult Create(TenantViewModel newTenant)
        {
           //removed ModelState.IsValid since it returns false, it keeps going to else statement
            var tenantToAdd = new Tenant(){
                TenantId = Guid.NewGuid(),
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
            ViewBag.IsEditing = false;
            return RedirectToAction("Index");
            //redirect to the index action
        }
        
        [HttpPost]

        public IActionResult Delete(TenantViewModel tenantViewModel){
            var tenant = new Tenant(){
                TenantId = tenantViewModel.TenantId,
                FirstName = tenantViewModel.FirstName,
                LastName = tenantViewModel.LastName,
                Address = tenantViewModel.Address,
                PostalCode = tenantViewModel.PostalCode,
                City = tenantViewModel.City,
                Deposit = tenantViewModel.Deposit,
                IsAssigned = tenantViewModel.IsAssigned
            };
            if(tenant.IsAssigned == true){
                return View("Details");
            }
            else{
            _rentManagementSystem.DeleteATenant(tenant.TenantId);
            return RedirectToAction("Index");}
        }
        public IActionResult Search(){
            var search = new SearchViewModel(){
                FirstName = "",
                SearchResults = new List<Tenant>()
            };
            return View(search);
        }
        

        [HttpPost]

        public IActionResult SearchTenant(SearchViewModel searchViewModel){
            searchViewModel.SearchResults = _rentManagementSystem.SearchForTenantByName(searchViewModel.FirstName);

            return View("search", searchViewModel);
        }
            

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
