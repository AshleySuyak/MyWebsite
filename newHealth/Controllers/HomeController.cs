using Microsoft.AspNetCore.Mvc;
using newHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newHealth.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;
    
        public HomeController(IBookRepository temp)
        {
            repo = temp;
        }
        

        public IActionResult Index(int pageNum = 1)
        {
            int numResults = 3;
            int specialResults = 3; 
            if (pageNum == 6)
                specialResults = 4;
            var blah = repo.Books.Skip((pageNum-1) * numResults).Take(specialResults);
            return View(blah);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}
