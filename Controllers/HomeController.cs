using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            ViewBag.allDishes = AllDishes;
            return View();
        }

        [HttpGet]
        [Route("new")]
        public IActionResult newDish_Form()
        {
            return View("createDish");
        }

        [HttpGet]
        [Route("{dish_id}")]
        public IActionResult dishpage(int dish_id)
        {
            List<Dish> DishPage = dbContext.Dishes.Where(dish => dish.DishId == dish_id).ToList();
            ViewBag.dishpage = DishPage;
            return View("DishPage");
        }

        [HttpGet]
        [Route("edit/{dish_id}")]
        public IActionResult showeditpage(int dish_id)
        {
            Dish retrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dish_id);
            ViewBag.dishpage = retrievedDish;
            return View("EditDish");
        }

        [HttpGet]
        [Route("delete/{dish_id}")]
        public IActionResult delete_dish(Dish deleted_dish, int dish_id)
        {
            Dish retrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dish_id);
            dbContext.Dishes.Remove(retrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost("edit/{dish_id}")]
        [Route("edit/{dish_id}")]
        public IActionResult editdish(Dish edited_dish, int dish_id)
        {
            Dish retrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dish_id);
            ViewBag.dishpage = retrievedDish;

            if(ModelState.IsValid)
            {
                retrievedDish = edited_dish;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return View("EditDish");
            }
            
        }

        [HttpPost]
        [Route("create")]
        public IActionResult create(Dish dish)
        {
            if(ModelState.IsValid)
            {

                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("createDish");
            }
        }
        

    }
}
