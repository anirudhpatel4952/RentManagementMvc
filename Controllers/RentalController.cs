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
            ViewBag.IsEditing = false;
            return View();
        }

        public IActionResult Details(int unit)
        {
            var units = _rentManagementSystem.SearchForUnits(unit);
            return View(units);
        }

        public IActionResult Edit(int unit){
            var unitToEdit = _rentManagementSystem.SearchForUnits(unit);
            var unitViewModel = new RentalViewModel(){
                Apartment = unitToEdit.Apartment,
                Unit = unitToEdit.Unit,
                Cost = unitToEdit.Cost,
                NumberOfRoom = unitToEdit.NumberOfRoom,
                IsAssigned = false
            };
            ViewBag.IsEditing = true;
            return View("Form", unitViewModel);
        }

        [HttpPost]

        public IActionResult Create(Rental rental)
        {
            
            var unit = new Rental(){
                Apartment = rental.Apartment,
                Unit = rental.Unit,
                NumberOfRoom = rental.NumberOfRoom,
                Cost = rental.Cost,
                IsAssigned = false
            };
            var newUnit = _rentManagementSystem.AddUnit(unit);
            ViewBag.IsEditing = false;
            return RedirectToAction("Index");
        }

        [HttpPost]    
        public IActionResult Update(RentalViewModel rentalToUpdate){
            var rental = new Rental(){
                Apartment = rentalToUpdate.Apartment,
                Unit = rentalToUpdate.Unit,
                NumberOfRoom = rentalToUpdate.NumberOfRoom,
                Cost = rentalToUpdate.Cost,
                IsAssigned = false
            };
            ViewBag.IsEditing = true;
            _rentManagementSystem.UpdateUnit(rental);
            return RedirectToAction("Index");
        }  
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
