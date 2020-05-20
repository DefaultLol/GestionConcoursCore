using GestionConcoursCore.Models;
using GestionConcoursCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services_User
{
    public interface ICandidatService
    {
        Candidat getTotalCandidat(string cne);

        BaccalaureatModel getBaccalaureat(string cne);
        void setBaccalaureat(BaccalaureatModel bac);

        CandidatModel getInfoPersonnel(string cne);
        void setInfoPersonnel(CandidatModel saisi);

        DiplomeModel getDiplome(string cne);
        void setDiplome(DiplomeModel saisi);

        string checkConformity(string cne);


    }
}
