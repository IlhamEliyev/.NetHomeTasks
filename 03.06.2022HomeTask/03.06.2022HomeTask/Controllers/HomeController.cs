using _03._06._2022HomeTask.DAL;
using _03._06._2022HomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _03._06._2022HomeTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                news = await db.News.ToListAsync()
            };
            return View(hvm);
        }
    }
}
