using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PE_PRN211_FA22_Q2.Models;

namespace PE_PRN211_FA22_Q2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Producer_Movie(int pid)
        {
           using (var db = new PePrnFall22B1Context())
            {
                ViewBag.producerList = db.Producers.ToList();
                ViewBag.MovieList = db.Movies.Include("Genres").Include("Producer").Include("Director").ToList();
            }
            return View();
        }
    }
}
