using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace GestionConcoursCore.Services
{
    public class EpreuveServicceImp
    {

        GestionConcourCoreDbContext db;
        public EpreuveServicceImp(GestionConcourCoreDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<DiplomeFichierModel> diplomeFile(string cne, int niveau)
        {
            var x = (from f in db.Fichiers
                     join c in db.Candidats on f.Cne equals c.Cne
                     where f.Cne == cne
                     where c.Niveau == niveau
                     select new DiplomeFichierModel
                     {
                         ID = f.ID,
                         nom = f.nom
                     }).ToList();
            return x;
        }

       
    }
}
