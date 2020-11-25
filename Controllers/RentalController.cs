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
    public class RentalController : Controller
    {
        private RentManagementSystem _rentManagementSystem;
        public RentalController(RentManagementSystem rentManagementSystem)
        {
            _rentManagementSystem = rentManagementSystem;
        }

        //Get units/Index
        public IActionResult Index()
        {
            var units = _rentManagementSystem.PrintAllUnitsInApartn();
                        return View(units);
        }
        public IActionResult Form(){
            return View();
        }

        [HttpPost]

        public IActionResult Create(Rental rental)
        {
            if(ModelState.IsValid){
            var unit = new Rental(){
                Apartment = rental.Apartment,
                Unit = rental.Unit,
                NumberOfRoom = rental.NumberOfRoom,
                Cost = rental.Cost,
                IsAssigned = false
            };
            var newUnit = _rentManagementSystem.AddUnit(unit);
            return RedirectToAction("Index");
            }
            else{
                return View("Form", rental);
            }
        }
         public IActionResult Details(int unit){
            var units = _rentManagementSystem.PrintAllUnitsInApartn();
            var unitToView = units.Find(x => x.Unit == unit);
            return View(unitToView);
         }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
