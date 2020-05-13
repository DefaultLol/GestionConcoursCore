using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Models
{
    public class GestionConcourCoreDbContext: DbContext
    {
        public GestionConcourCoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AnneeUniversitaire> AnneeUniversitaires { get; set; }
        public DbSet<Baccalaureat> Baccalaureats { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<ConfigurationPreselection> ConfigurationPreselections { get; set; }
        public DbSet<ConfigurationSelection> ConfigurationSelections { get; set; }
        public DbSet<Corbeille> Corbeilles { get; set; }
        public DbSet<ConcourEcrit> CouncourEcrits { get; set; }
        public DbSet<ConcourOral> CouncourOrals { get; set; }
        public DbSet<Diplome> Diplomes { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Epreuves> Epreuves { get; set; }
        public DbSet<Fichier> Fichiers { get; set; }
    }
}
