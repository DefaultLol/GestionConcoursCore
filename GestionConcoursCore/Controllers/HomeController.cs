using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionConcoursCore.Models;

namespace GestionConcoursCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Acceuil()
        {
            return View();
        }

        public IActionResult ModifierPersonnel()
        {
            return View();
        }

        public IActionResult ModifierBac()
        {
            return View();
        }

        public IActionResult ModifierDiplome()
        {
            return View();
        }
        
        public IActionResult FichierScanne()
        {
            return View();
        }

        public IActionResult ModifierFiliere()
        {
            return View();
        }

        public IActionResult Fiche()
        {
            return View();
        }

        public IActionResult Epreuve()
        {
            return View();
        }

        public IActionResult Deconnexion()
        {
            return View();
        }
    }
}
