using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionConcoursCore.Models;

namespace GestionConcoursCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly GestionConcourCoreDbContext _context;

        public AdminController(GestionConcourCoreDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Recherche3()
        {
            return View();
        }

        public IActionResult Recherche4()
        {
            return View();
        }

        public IActionResult Corbeil3()
        {
            return View();
        }

        public IActionResult Corbeil4()
        {
            return View();
        }

        public IActionResult Preselection3()
        {
            return View();
        }

        public IActionResult Preselection4()
        {
            return View();
        }

        public IActionResult Statistique3()
        {
            return View();
        }

        public IActionResult Statistique4()
        {
            return View();
        }

        public IActionResult Correction3()
        {
            return View();
        }

        public IActionResult Correction4()
        {
            return View();
        }

        public IActionResult Selection3()
        {
            return View();
        }

        public IActionResult Selection4()
        {
            return View();
        }

        public IActionResult ListeFinale3()
        {
            return View();
        }

        public IActionResult ListFinale4()
        {
            return View();
        }

        public IActionResult Statistique3ApresConcours()
        {
            return View();
        }

        public IActionResult Statistique4ApresConcours()
        {
            return View();
        }

        public IActionResult FichierScanne3()
        {
            return View();
        }

        public IActionResult FichierScanne4()
        {
            return View();
        }

    }
}
