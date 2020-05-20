using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using GestionConcoursCore.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GestionConcoursCore.Services_User
{
    public class CandidatServiceImp : ICandidatService
    {
        GestionConcourCoreDbContext db;

        public CandidatServiceImp(GestionConcourCoreDbContext db)
        {
            this.db = db;
        }

        public Candidat getTotalCandidat(string cne)
        {
            return db.Candidats.Find(cne);
        }

        //############################################ BACCALAUREAT  #########################################

        public BaccalaureatModel getBaccalaureat(string cne)
        {
            var bac = (from b in db.Baccalaureats
                       where b.Cne.Equals(cne)
                       select new BaccalaureatModel
                       {
                           Cne = b.Cne,
                           DateObtentionBac = b.DateObtentionBac,
                           MentionBac = b.MentionBac,
                           NoteBac = b.NoteBac,
                           TypeBac = b.TypeBac
                       }).SingleOrDefault();

            return bac;
        }

        public void setBaccalaureat(BaccalaureatModel bac_saisi)
        {
            Baccalaureat bac = db.Baccalaureats.Find(bac_saisi.Cne);
            bac.DateObtentionBac = bac_saisi.DateObtentionBac;
            bac.MentionBac = bac_saisi.MentionBac;
            bac.NoteBac = bac_saisi.NoteBac;
            bac.TypeBac = bac_saisi.TypeBac;

            db.Update(bac);
            db.SaveChanges();
        }

        //############################################ Informations Personnelles  #########################################

        public CandidatModel getInfoPersonnel(string cne)
        {
            var info = (from c in db.Candidats
                       where c.Cne.Equals(cne)
                       select new CandidatModel
                       {
                           Cne = c.Cne,
                           Cin = c.Cin,
                           Nom = c.Nom,
                           Prenom = c.Prenom,
                           Email = c.Email,
                           Password = c.Password,
                           Sexe = c.Sexe,
                           Ville=c.Ville,
                           Adresse = c.Adresse,
                           LieuNaissance = c.LieuNaissance,
                           Gsm = c.Gsm,
                           Telephone = c.Telephone,
                           DateNaissance = c.DateNaissance,
                           Nationalite = c.Nationalite,
                           Photo = c.Photo
                           
                       }).SingleOrDefault();

            return info;
        }

        public void setInfoPersonnel(CandidatModel saisi)
        {
            Candidat candidat = db.Candidats.Find(saisi.Cne);
            candidat.Cin = saisi.Cin;
            candidat.Nom = saisi.Nom;
            candidat.Prenom = saisi.Prenom;
            candidat.Email = saisi.Email;
            candidat.Password = saisi.Password;
            candidat.Sexe = saisi.Sexe;
            candidat.Ville = saisi.Ville;
            candidat.Adresse = saisi.Adresse;
            candidat.LieuNaissance = saisi.LieuNaissance;
            candidat.Gsm = saisi.Gsm;
            candidat.Telephone = saisi.Telephone;
            candidat.DateNaissance = saisi.DateNaissance;
            candidat.Nationalite = saisi.Nationalite;

            db.Update(candidat);
            db.SaveChanges();
        }

        //#################################################  DIPLOME  #########################################

        public DiplomeModel getDiplome(string cne)
        {
            var data = (from d in db.Diplomes
                        join a in db.AnneeUniversitaires on d.Cne equals a.Cne
                        where d.Cne.Equals(cne)
                        select new DiplomeModel
                        {
                            Cne = d.Cne,
                            Type = d.Type,
                            Etablissement = d.Etablissement,
                            VilleObtention = d.VilleObtention,
                            NoteDiplome = d.NoteDiplome,
                            Specialite = d.Specialite,
                            Semestre1 = a.Semestre1,
                            Semestre2 = a.Semestre2,
                            Semestre3 = a.Semestre3,
                            Semestre4 = a.Semestre4,
                            Semestre5 = a.Semestre5,
                            Semestre6 = a.Semestre6,
                            Redoublant1 = a.Redoublant1,
                            Redoublant2 = a.Redoublant2,
                            Redoublant3 = a.Redoublant3,
                            AnneUni1 = a.AnneUni1,
                            AnneUni2 = a.AnneUni2,
                            AnneUni3 = a.AnneUni3

                        });

            return data.First();
        }

        public void setDiplome(DiplomeModel saisi)
        {
            var diplome = db.Diplomes.Find(saisi.Cne);
            diplome.Type = saisi.Type;
            diplome.Etablissement = saisi.Etablissement;
            diplome.VilleObtention = saisi.VilleObtention;
            diplome.NoteDiplome = saisi.NoteDiplome;
            diplome.Specialite = saisi.Specialite;
            db.SaveChanges();

            var annee = db.AnneeUniversitaires.Find(saisi.Cne);
            annee.Semestre1 = saisi.Semestre1;
            annee.Semestre2 = saisi.Semestre2;
            annee.Semestre3 = saisi.Semestre3;
            annee.Semestre4 = saisi.Semestre4;
            annee.Semestre5 = saisi.Semestre5;
            annee.Semestre6 = saisi.Semestre6;
            annee.Redoublant1 = saisi.Redoublant1;
            annee.Redoublant2 = saisi.Redoublant2;
            annee.Redoublant3 = saisi.Redoublant3;
            annee.AnneUni1 = saisi.AnneUni1;
            annee.AnneUni2 = saisi.AnneUni2;
            annee.AnneUni3 = saisi.AnneUni3;

            db.SaveChanges();
        }

        public string checkConformity(string cne)
        {
            string msg = "";
            var diplome = db.Diplomes.Find(cne);
            var anne = db.AnneeUniversitaires.Find(cne);
            var bac = db.Baccalaureats.Find(cne);
            string type_dip = diplome.Type;
            int k = 0;
            if (isNull(diplome))
            {
                msg += "Diplôme Info, ";
                k = 1;
            }
            if (isNull(anne))
            {
                if (type_dip == null)
                {
                    msg += "Année Univertsitaire, ";
                    k = 1;
                }
                else if (type_dip.Contains("Lic"))
                {
                    msg += "Année Univertsitaire, ";
                    k = 1;
                }
            }
            if (isNull(bac))
            {
                msg += "Bac Info, ";
                k = 1;
            }
            if (k == 1)
            {
                msg += "still need editing";
            }
            return msg;
        }

        public bool isNull(Object obj)
        {
            bool isNull = obj.GetType().GetProperties().All(p => p.GetValue(obj, null) == null); 
            return isNull;
        }

       
    }
}
