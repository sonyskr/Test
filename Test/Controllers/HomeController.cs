using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Test.Models;
using Test.Data;

namespace Test.Controllers
{
    public class HomeController : Controller
    {

        private readonly AccountDBContext _context;

        private readonly ILogger<HomeController> _logger;


        public HomeController(AccountDBContext context, ILogger<HomeController> logger)
        { 
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var acc = from m in _context.Account
                        select m;
            
            int id = 2;
            var ac = _context.Account.FindAsync(id);
            

            return View(ac);
            
            
        



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
