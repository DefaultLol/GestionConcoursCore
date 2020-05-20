using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionConcoursCore.Models;
using Microsoft.AspNetCore.Http;
using GestionConcoursCore.Data;
using GestionConcoursCore.Services_User;
using GestionConcoursCore.ViewModels;

namespace GestionConcoursCore.Controllers
{
    public class HomeController : Controller
    {
        ICandidatService candidat_service;

        public HomeController(ICandidatService candidat_service)
        {
            this.candidat_service = candidat_service;
        }

        public IActionResult Index()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }
            return RedirectToAction(nameof(Accueil), "Home");
        }

        //####################################################  ACCUEIL  ##################################################

        public IActionResult Accueil()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            Candidat candidat = candidat_service.getTotalCandidat(cne);
            HttpContext.Session.SetString("photo", candidat.Photo);
            HttpContext.Session.SetString("prenom", candidat.Prenom);
            HttpContext.Session.SetString("nom", candidat.Nom);
            HttpContext.Session.SetInt32("niveau", candidat.Niveau);

            string message = candidat_service.checkConformity(cne);

            ViewBag.error = message;

            return View(candidat);
        }

        //##############################################  MODIFIER  PERSONNEL  ##################################################
        
        public IActionResult ModifierPersonnel()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }
            Debug.WriteLine("################################################ tttttttttttt " + HttpContext.Session.GetString("photo"));
            CandidatModel info = candidat_service.getInfoPersonnel(cne);
            ViewBag.photo = info.Photo ;

            return View(info);
        }

        [HttpPost]
        public IActionResult ModifierPersonnel(CandidatModel info)
        {
            if (ModelState.IsValid)
            {
                candidat_service.setInfoPersonnel(info);
                TempData["message"] = "Profil Personel Modified succefully";
                return RedirectToAction("Index");
            }
            return View(info);
        }

        //##############################################  BACCALAUREAT  ##################################################

        public IActionResult ModifierBac()
        {            

            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");
            
            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            BaccalaureatModel bac = candidat_service.getBaccalaureat(cne);      

            return View(bac);
        }

        [HttpPost]
        public IActionResult ModifierBac(BaccalaureatModel bac)
        {            
            if (ModelState.IsValid)
            {
                candidat_service.setBaccalaureat(bac);
                TempData["message"] = "Bac Modified succefully";
                return RedirectToAction("Index");
            }
            return View(bac);
        }

        //##############################################  DIPLOME  ##################################################

        public IActionResult ModifierDiplome()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }
            ViewBag.niveau = HttpContext.Session.GetInt32("niveau");
            Debug.WriteLine("============================ " + HttpContext.Session.GetInt32("niveau"));
            DiplomeModel diplome = candidat_service.getDiplome(cne);
            
            return View(diplome);
        }

        [HttpPost]
        public IActionResult ModifierDiplome(DiplomeModel diplome)
        {
            if (ModelState.IsValid)
            {
                candidat_service.setDiplome(diplome);
                TempData["message"] = "Diplome Modified succefully";
                return RedirectToAction("Index");
            }
            return View(diplome);
        }

        public IActionResult FichierScanne()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            return View();
        }

        public IActionResult ModifierFiliere()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            return View();
        }

        public IActionResult Fiche()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            return View();
        }

        public IActionResult Epreuve()
        {
            if (!isCandidat())
            {
                return RedirectToAction("Login", "Auth");
            }

            string cne = HttpContext.Session.GetString("cne");
            int? verified = HttpContext.Session.GetInt32("verified");

            if (verified == 0)
            {
                return RedirectToAction("Step1", "Auth");
            }

            return View();
        }


        //##############################################  FONCTIONS  ##################################################
             
        private bool isCandidat()
        {
            string cne = HttpContext.Session.GetString("cne");
            if (cne != null)
            {
                return true;
            }
            return false;
        }

    }
}
