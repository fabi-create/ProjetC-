using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Model
{
    public class Journalier:Employe
    {
        private float tauxJournalier;
        private int nbJour;

        public Journalier(float tauxJournalier, int nbJour,string matricule,string nom,string prenom,string sexe):base(matricule,nom,prenom,sexe)
        {
            this.TauxJournalier = tauxJournalier;
            this.NbJour = nbJour;
        }
        public Journalier()
        {
           
        }

        public float TauxJournalier { get => tauxJournalier; set => tauxJournalier = value; }
        public int NbJour { get => nbJour; set => nbJour = value; }
    }
}
