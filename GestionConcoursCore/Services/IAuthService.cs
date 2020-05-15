using GestionConcoursCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services
{
    public interface IAuthService
    {
        void Step1Get();
        void Step1Post(InfoPersoModel candidat);
        void Step2Get();
        void Step2Post(Baccalaureat bac);
        void Step3Get();
        void Step3Post(DiplomeNote diplome);
        void registerPost(Candidat candidat);
    }
}
