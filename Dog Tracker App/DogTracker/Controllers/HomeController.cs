using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogTracker.Business;
using DogTracker.WebSite.Models;

namespace DogTracker.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDogManager dogManager;

        public HomeController(IDogManager dogManager)
        {
            this.dogManager = dogManager;
        }
        
        public IActionResult Index()
        {
            var dogs = dogManager.Dogs
                .Select(t => new DogTracker.WebSite.Models.DogModel(t.BusinessDogId, t.BusinessDogName))
                .ToArray();

            var model = new DogTrackerModel { Dogs = dogs };
            
            
            
            return View(model);
        }
    }
}
