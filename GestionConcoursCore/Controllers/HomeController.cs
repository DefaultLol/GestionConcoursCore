using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionConcoursCore.Models;
using Microsoft.AspNetCore.Http;

namespace GestionConcoursCore.Controllers
{
    public class HomeController : Controller
    {
        private bool isCandidat()
        {
            string cne = HttpContext.Session.GetString("cne");
            if (cne != null)
            {
                return true;
            }
            return false;
        }

        public IActionResult Index()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Acceuil()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult ModifierPersonnel()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult ModifierBac()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult ModifierDiplome()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }
        
        public IActionResult FichierScanne()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult ModifierFiliere()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Fiche()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Epreuve()
        {
            if (isCandidat())
            {
                return View();
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Deconnexion()
        {
            return View();
        }
    }
}
