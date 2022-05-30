using HomeTask.DAL;
using HomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HomeTask.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeTask.Controllers
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
                banners = await db.Banners.ToListAsync(),
                mainContexts = await db.MainContexts.ToListAsync(),
                cities = await db.Cities.ToListAsync(),
                testMonials = await db.TestMonials.ToListAsync(),
                news = await db.News.ToListAsync(),
                projects = await db.Projects.ToListAsync()
            };
            return View(hvm);
        }

    }
}
