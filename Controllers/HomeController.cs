using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private ChefsNDishesContext db;

        public HomeController(ChefsNDishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Chefs()
        {
            List<Chef> allChefs = db.Chefs
                .Include(chef => chef.CreatedDishes)
                .ToList();
            return View("Chefs", allChefs);
        }

        [HttpGet("/new")]
        public IActionResult NewChefPage()
        {
            return View("NewChef");
        }

        [HttpPost("/chef/create")]
        public IActionResult CreateChef(Chef newChef)
        {
            if(ModelState.IsValid == false)
            {
                return NewChefPage();
            }

            db.Chefs.Add(newChef);
            db.SaveChanges();
            return RedirectToAction("Chefs");
        }

        [HttpGet("/dishes")]
        public IActionResult Dishes()
        {
            List<Dish> allDishes = db.Dishes
                .Include(dish => dish.DishCreator)
                .ToList();
            return View("Dishes", allDishes);
        }

        [HttpGet("/dish/new")]
        public IActionResult NewDishPage()
        {
            List<Chef> allChefs = db.Chefs.ToList();
            ViewBag.AllChefs = allChefs;

            return View("NewDish");
        }

        [HttpPost("/dish/create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid == false)
            {
                return NewDishPage();
            }

            db.Dishes.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Dishes");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
