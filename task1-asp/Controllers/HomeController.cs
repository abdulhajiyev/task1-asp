using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using task1_asp.Entities;
using task1_asp.Models;
using task1_asp.Entities;
using task1_asp.Models;

namespace task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink { Id = 1, Name = "Coca-Cola", Price = 1.5 },
                new Drink { Id = 2, Name = "Fanta", Price = 1.5 },
                new Drink { Id = 3, Name = "Sprite", Price = 1.5 },
            };

            var viewModel = new MealsViewModel
            {
                Drinks = drinks
            };
            return View(viewModel);
        }

        public IActionResult Burgers()
        {
            List<Burger> burgers = new List<Burger>
            {
                new Burger { Id = 1, Name = "Hamburger", Price = 2.5 },
                new Burger { Id = 2, Name = "Cheeseburger", Price = 2.5 },
                new Burger { Id = 3, Name = "Chickenburger", Price = 2.5 },
            };

            var viewModel = new MealsViewModel
            {
                Burgers = burgers
            };
            return View(viewModel);
        }

        public IActionResult Sandwiches()
        {
            List<Sandwich> sandwiches = new List<Sandwich>
            {
                new Sandwich { Id = 1, Name = "Ham Sandwich", Price = 2.5 },
                new Sandwich { Id = 2, Name = "Cheese Sandwich", Price = 2.5 },
                new Sandwich { Id = 3, Name = "Chicken Sandwich", Price = 2.5 },
            };

            var viewModel = new MealsViewModel
            {
                Sandwiches = sandwiches
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink { Id = 1, Name = "Coca-Cola", Price = 1.5 },
                new Drink { Id = 2, Name = "Fanta", Price = 1.5 },
                new Drink { Id = 3, Name = "Sprite", Price = 1.5 },
            };

            List<Burger> burgers = new List<Burger>
            {
                new Burger { Id = 1, Name = "Hamburger", Price = 2.5 },
                new Burger { Id = 2, Name = "Cheeseburger", Price = 2.5 },
                new Burger { Id = 3, Name = "Chickenburger", Price = 2.5 },
            };

            List<Sandwich> sandwiches = new List<Sandwich>
            {
                new Sandwich { Id = 1, Name = "Ham Sandwich", Price = 2.5 },
                new Sandwich { Id = 2, Name = "Cheese Sandwich", Price = 2.5 },
                new Sandwich { Id = 3, Name = "Chicken Sandwich", Price = 2.5 },
            };

            var viewModel = new MealsViewModel
            {
                Drinks = drinks,
                Burgers = burgers,
                Sandwiches = sandwiches
            };

            return View(viewModel);
        }
    }
}

