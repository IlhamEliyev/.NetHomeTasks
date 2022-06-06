using _03._06._2022HomeTask.DAL;
using _03._06._2022HomeTask.Models;
using _03._06._2022HomeTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03._06._2022HomeTask.Controllers
{
    public class DetailsController : Controller
    {
        private readonly AppDbContext db;

        public DetailsController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Details()
        {
            DetailsViewModel dvm = new DetailsViewModel()
            {
                newsDetails = await db.NewsDetails.Include(x => x.News).ToListAsync()
            };
            return View(dvm);
        }
    }
}
