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
using Microsoft.AspNetCore.Mvc.Rendering;


namespace rentManagementMVC.Controllers
{
    public class AssignmentController : Controller
    {
        private RentManagementSystem _rentManagementSystem;
        public AssignmentController(RentManagementSystem rentManagementSystem)
        {
            _rentManagementSystem = rentManagementSystem;
        }

        public IActionResult Index(){
            var assignments = _rentManagementSystem.PrintAllAssignments();
            return View("Index", assignments);
        }

        // public IActionResult CreateForm(int unit){
        //     ViewBag.IsCreating = true;
        //     return View();
        // }
        // working on this

        public IActionResult CreateForm(int unit){
            
            var tenants = _rentManagementSystem.PrintAllTenants();
            var tenantList = tenants.Select(x => new {x.TenantId, x.FullName}).ToList();
            var selectList = new SelectList(tenantList, "TenantId", "FullName");
        
            var rental = _rentManagementSystem.SearchForUnits(unit);
            var assignmentViewModel = new AssignmentViewModel(){
                Unit = unit,
                TenantList = selectList,
            };
            ViewBag.IsCreating = true;
            return View(assignmentViewModel);

        }
        public IActionResult RemoveForm(int unit){
            _rentManagementSystem.UnassignmentByUnit(unit);
            ViewBag.IsCreating = false;
            return RedirectToAction("Index", "Rental");
        }

        [HttpPost]

        public IActionResult Create(AssignmentViewModel newAssignment)
        {
            if (ModelState.IsValid){
                _rentManagementSystem.CreateAssignment(newAssignment.TenantId, newAssignment.Unit);
                ViewBag.IsCreating = true;
                return RedirectToAction("Index", "Rental");
            }
            else {
                return View("CreateForm");
            }
        }
        
        // [HttpPost]

        //  public IActionResult Remove(AssignmentViewModel oldAssignment){
        //     if (ModelState.IsValid){
        //         _rentManagementSystem.Unassignment(oldAssignment.TenantId, oldAssignment.Unit);
        //         ViewBag.IsCreating = false;
        //         return RedirectToAction("Index", "Rental");
        //     }
        //     else {
        //         return View("CreateForm");
        //     }
        // }
            
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
