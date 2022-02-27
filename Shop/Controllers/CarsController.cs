using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "DOSHAN Motors";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.GetAllCars;
            obj.CurrentCategory = "Electro cars";
            return View(obj);
        }
    }
}
