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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace GestionConcoursCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandidatService candidat_service;
        private readonly IEpreuveService epreuve;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ICandidatService candidat_service, IEpreuveService epreuve, IHostingEnvironment hostingEnvironment)
        {
            this.candidat_service = candidat_service;
            this.epreuve = epreuve;
            this.hostingEnvironment = hostingEnvironment;
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

        public JsonResult Image(IFormFile file)
        {
            string response = " ";
            string cne = HttpContext.Session.GetString("cne");
            if (file != null)
            {
                response=candidat_service.uploadPicture(file, cne);
                HttpContext.Session.SetString("photo", response);
            } 
            else
            {
                response = "icon.jpg";
            }
            return Json(response);
        }

        [HttpPost]
        public ActionResult FichierScanne(IFormFile[] files)
        {
            string cne = HttpContext.Session.GetString("cne");
            if (ModelState.IsValid)
            {
                candidat_service.uploadFichierScanne(files, cne);
                ViewBag.UploadStatus = files.Count().ToString() + " files uploaded successfully.";
            }
            return View();
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


        //##############################################  EPREUVE  ##################################################

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
            
            return View(epreuve.getEpreuves().ToList());
        }

        public IActionResult Download(string filename)
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

            if (filename == null)
                return null;

            var path0 = Path.Combine(hostingEnvironment.WebRootPath, "epreuves");
            var path = Path.Combine(path0, filename);

            var ext = Path.GetExtension(filename).ToLowerInvariant();
            try
            {
                if (ext == ".pdf")
                {
                    /*var stream = new FileStream(path, FileMode.Open);
                    return File(stream, "application/pdf");*/
                    byte[] fileBytes = System.IO.File.ReadAllBytes(path);
                    string mimeType = "application/pdf";
                    Response.Headers.Append("Content-Disposition", "inline; filename=" + filename);
                    return File(fileBytes, mimeType);
                }
                else
                {
                    byte[] fileBytes = System.IO.File.ReadAllBytes(path);
                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
                }
            }
            catch (Exception ex)
            {
                TempData["download"] = "Une erreur a été rencontrée lors du téléchargement";
                return RedirectToAction(nameof(Epreuve));
            }
            
                        
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
