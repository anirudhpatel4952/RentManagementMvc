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

        public IActionResult CreateForm(int unit){
            ViewBag.IsCreating = true;
            return View();
        }

        public IActionResult RemoveForm(int unit){
            ViewBag.IsCreating = false;
            return View("CreateForm");
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
        
        [HttpPost]

        public IActionResult Remove(AssignmentViewModel oldAssignment){
            if (ModelState.IsValid){
                _rentManagementSystem.Unassignment(oldAssignment.TenantId, oldAssignment.Unit);
                ViewBag.IsCreating = false;
                return RedirectToAction("Index", "Rental");
            }
            else {
                return View("CreateForm");
            }
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
