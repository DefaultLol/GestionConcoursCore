using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using GestionConcoursCore.Models;

namespace GestionConcoursCore.Data
{
    public class Generer
    {
        //###################################### CANDIDATS ###################################

        public static IEnumerable<Candidat> GenererCandidats()
        {

            List<Candidat> list = new List<Candidat>()
            {
                new Candidat()
                {
                    Cne = "R147778136",
                    Cin = "BL146789",
                    Nom = "Khalis",
                    Prenom = "Zineb",
                    Email = "zineb.khalis@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 0,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A123",
                    Presence = false,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R45698310",
                    Cin = "BE890936",
                    Nom = "Abdennour",
                    Prenom = "Imane",
                    Email = "imane.abdennour@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 0,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89700",
                    Presence = false,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R264797",
                    Cin = "BL7946",
                    Nom = "Zineddine",
                    Prenom = "Ayoub",
                    Email = "yassin97@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 451,
                    Sexe = "Homme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89710",
                    Presence = true,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R98567893",
                    Cin = "BE74546",
                    Nom = "Ouhamou",
                    Prenom = "Tarik",
                    Email = "hicham@gmail.com",
                    Ville = "Agadir",
                    Nationalite = "Marocaine",
                    Num_dossier = 452,
                    Sexe = "Homme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89720",
                    Presence = true,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14078593",
                    Cin = "BL144243",
                    Nom = "Kfifat",
                    Prenom = "Abir",
                    Email = "abdelkarim@gmail.com",
                    Ville = "Essaouira",
                    Nationalite = "Marocaine",
                    Num_dossier = 453,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89730",
                    Presence = true,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R1478562",
                    Cin = "BE144894",
                    Nom = "Khorchaly",
                    Prenom = "Imane",
                    Email = "yasmin@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 454,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89740",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14456325",
                    Cin = "BL185895",
                    Nom = "Dariaoui",
                    Prenom = "Oussama",
                    Email = "ousama@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 455,
                    Sexe = "Homme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89750",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R96341839",
                    Cin = "BL145996",
                    Nom = "bakhta",
                    Prenom = "yasmin",
                    Email = "yasmine@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 456,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89760",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14128897",
                    Cin = "BL157890",
                    Nom = "Khalis",
                    Prenom = "zineb",
                    Email = "zineb@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 457,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89770",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14777313",
                    Cin = "BL144810",
                    Nom = "salim",
                    Prenom = "yahya",
                    Email = "salim@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 459,
                    Sexe = "Homme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89790",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14778001",
                    Cin = "BL148901",
                    Nom = "amina",
                    Prenom = "anahcham",
                    Email = "amina@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 461,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A89810",
                    Presence = true,
                    Conforme = false,
                    ID = 2,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
                new Candidat()
                {
                    Cne = "R14777891",
                    Cin = "BL144891",
                    Nom = "Moutrib",
                    Prenom = "Nissrin",
                    Email = "nisrin@gmail.com",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 151,
                    Sexe = "Femme",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A8971",
                    Presence = true,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },
            };

            return list;
        }


        //###################################### ANNEE UNIVERSITAIRE ###################################
        public static IEnumerable<AnneeUniversitaire> GenererAnneeUniversitaire()
        {

            List<AnneeUniversitaire> list = new List<AnneeUniversitaire>()
            {
                new AnneeUniversitaire()
                {
                    Cne = "R147778136",
                    Semestre1 = 14.2,
                    Semestre2 = 14.8,
                    Semestre3 = 15,
                    Semestre4 = 17,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R45698310",
                    Semestre1 = 15.3,
                    Semestre2 = 14.5,
                    Semestre3 = 16,
                    Semestre4 = 16.5,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R264797",
                    Semestre1 = 15.6,
                    Semestre2 = 16.8,
                    Semestre3 = 15,
                    Semestre4 = 14.5,
                    Semestre5 = 17,
                    Semestre6 = 14.5,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R98567893",
                    Semestre1 = 14.3,
                    Semestre2 = 14.9,
                    Semestre3 = 15.6,
                    Semestre4 = 15.5,
                    Semestre5 = 17.6,
                    Semestre6 = 15.5,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14078593",
                    Semestre1 = 16.3,
                    Semestre2 = 13.9,
                    Semestre3 = 14.6,
                    Semestre4 = 15.9,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R1478562",
                    Semestre1 = 14.5,
                    Semestre2 = 14.9,
                    Semestre3 = 14.7,
                    Semestre4 = 14.9,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14456325",
                    Semestre1 = 12.5,
                    Semestre2 = 13.9,
                    Semestre3 = 14.9,
                    Semestre4 = 15.9,
                    Semestre5 = 16.9,
                    Semestre6 = 16.9,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R96341839",
                    Semestre1 = 13.5,
                    Semestre2 = 14.9,
                    Semestre3 = 15.9,
                    Semestre4 = 16.9,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14128897",
                    Semestre1 = 13.6,
                    Semestre2 = 15.9,
                    Semestre3 = 16.9,
                    Semestre4 = 14.8,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14777313",
                    Semestre1 = 13.8,
                    Semestre2 = 16.8,
                    Semestre3 = 15.6,
                    Semestre4 = 14.8,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14778001",
                    Semestre1 = 14.8,
                    Semestre2 = 16.9,
                    Semestre3 = 14.6,
                    Semestre4 = 14.7,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },
                new AnneeUniversitaire()
                {
                    Cne = "R14777891",
                    Semestre1 = 14.6,
                    Semestre2 = 14.8,
                    Semestre3 = 15,
                    Semestre4 = 14.5,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2015/2016",
                    AnneUni2 = "2016/2017"
                },

            };

            return list;
        }

        //###################################### BACCALAUREAT ###################################
        public static IEnumerable<Baccalaureat> GenererBaccalaureat()
        {

            List<Baccalaureat> list = new List<Baccalaureat>()
            {
                new Baccalaureat()
                {
                    Cne = "R147778136",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R45698310",
                    TypeBac = "SMA",
                    DateObtentionBac = "2015",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R264797",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R98567893",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14078593",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 17,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R1478562",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14456325",
                    TypeBac = "SMB",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R96341839",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 15,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14128897",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 15,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14777313",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 15,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14778001",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 15,
                    MentionBac = "Bien"
                },
                new Baccalaureat()
                {
                    Cne = "R14777891",
                    TypeBac = "SMA",
                    DateObtentionBac = "2016",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },
            };

            return list;
        }

        //###################################### CONCOURS ECRIT ###################################

        public static IEnumerable<ConcourEcrit> GenererConcoursEcrit()
        {

            List<ConcourEcrit> list = new List<ConcourEcrit>()
            {
                new ConcourEcrit()
                {
                    Cne = "R147778136",
                    NoteMath = 15,
                    NoteSpecialite = 15.5
                },
                new ConcourEcrit()
                {
                    Cne = "R45698310",
                    NoteMath = 15,
                    NoteSpecialite = 15.5
                },
                new ConcourEcrit()
            {
                Cne = "R264797",
                NoteMath = 17,
                NoteSpecialite = 16
            },
                new ConcourEcrit()
                {
                    Cne = "R98567893",
                    NoteMath = 15,
                    NoteSpecialite = 16
                },
                new ConcourEcrit()
            {
                Cne = "R14078593",
                NoteMath = 15,
                NoteSpecialite = 14
            },
                new ConcourEcrit()
                {
                    Cne = "R1478562",
                    NoteMath = 14,
                    NoteSpecialite = 14
                },
                new ConcourEcrit()
                {
                    Cne = "R14456325",
                    NoteMath = 16,
                    NoteSpecialite = 16
                },
                new ConcourEcrit()
                {
                    Cne = "R96341839",
                    NoteMath = 14,
                    NoteSpecialite = 14
                },
                new ConcourEcrit()
                {
                    Cne = "R14128897",
                    NoteMath = 15,
                    NoteSpecialite = 14.6
                },
                new ConcourEcrit()
                {
                    Cne = "R14777313",
                    NoteMath = 15,
                    NoteSpecialite = 14.6
                },
                new ConcourEcrit()
                {
                    Cne = "R14778001",
                    NoteMath = 15,
                    NoteSpecialite = 14.6
                },
                new ConcourEcrit()
                {
                    Cne = "R14777891",
                    NoteMath = 14,
                    NoteSpecialite = 16
                },
            };

            return list;
        }

        //######################################  CONCOURS ORAL ###################################

        public static IEnumerable<ConcourOral> GenererConcoursOral()
        {

            List<ConcourOral> list = new List<ConcourOral>()
            {
                new ConcourOral()
                {
                    Cne = "R147778136"
                },
                new ConcourOral()
                {
                    Cne = "R45698310"
                },
                new ConcourOral()
                {
                    Cne = "R264797"
                },
                new ConcourOral()
                {
                    Cne = "R98567893"
                },
                new ConcourOral()
                {
                    Cne = "R14078593"
                },
                new ConcourOral()
                {
                    Cne = "R1478562"
                },
                new ConcourOral()
                {
                    Cne = "R14456325"
                },
                new ConcourOral()
                {
                    Cne = "R96341839"
                },
                new ConcourOral()
                {
                    Cne = "R14128897"
                },
                new ConcourOral()
                {
                    Cne = "R14777313"
                },
                new ConcourOral()
                {
                    Cne = "R14778001"
                },
                new ConcourOral()
                {
                    Cne = "R14777891"
                },
            };

            return list;
        }

        //###################################### DIPLOME ###################################

        public static IEnumerable<Diplome> GenererDiplome()
        {

            List<Diplome> list = new List<Diplome>()
            {
                new Diplome()
                {
                    Cne = "R147778136",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "safi",
                    NoteDiplome = 16.42,
                    Specialite = "Informatique"
                },
                new Diplome()
                {
                    Cne = "R45698310",
                    Type = "DUT",
                    Etablissement = "FP",
                    VilleObtention = "safi",
                    NoteDiplome = 16.42,
                    Specialite = "Informatique"
                },
                new Diplome()
                {
                    Cne = "R264797",
                    Type = "Lic.pro-DUT",
                    Etablissement = "EST",
                    VilleObtention = "safi",
                    NoteDiplome = 16,
                    Specialite = "Informatique"
                },
                new Diplome()
                {
                    Cne = "R98567893",
                    Type = "Lic.pro-DUT",
                    Etablissement = "EST",
                    VilleObtention = "Essaouira",
                    NoteDiplome = 15.25,
                    Specialite = "Informatique"
                },
                new Diplome()
                {
                    Cne = "R14078593",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "mohamadia",
                    NoteDiplome = 15,
                    Specialite = "Reseau"
                },
                new Diplome()
                {
                    Cne = "R1478562",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "mohamadia",
                    NoteDiplome = 16.5,
                    Specialite = "Reseau"
                },
                new Diplome()
                {
                    Cne = "R14456325",
                    Type = "Lic.pro-DUT",
                    Etablissement = "EST",
                    VilleObtention = "settat",
                    NoteDiplome = 15.5,
                    Specialite = "Reseau"
                },
                new Diplome()
                {
                    Cne = "R96341839",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "casablanca",
                    NoteDiplome = 16.5,
                    Specialite = "mecanique"
                },
                new Diplome()
                {
                    Cne = "R14128897",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "casablanca",
                    NoteDiplome = 15.4,
                    Specialite = "gtr"
                },
                new Diplome()
                {
                    Cne = "R14777313",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "casablanca",
                    NoteDiplome = 15.5,
                    Specialite = "chimie"
                },
                new Diplome()
                    {
                        Cne = "R14778001",
                        Type = "DUT",
                        Etablissement = "EST",
                        VilleObtention = "casablanca",
                        NoteDiplome = 15.4,
                        Specialite = "chimie"
                    },
                new Diplome()
                {
                    Cne = "R14777891",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "safi",
                    NoteDiplome = 15,
                    Specialite = "Informatique"
                },
            };

            return list;
        }


    }



        
    
}
