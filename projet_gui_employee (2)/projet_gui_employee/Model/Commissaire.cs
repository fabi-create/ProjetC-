using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Model
{
    public class Commissaire:Employe
    {
        private float tauxCommission;
        private double montantContrat;

        public float TauxCommission { get => tauxCommission; set => tauxCommission = value; }
        public double MontantContrat { get => montantContrat; set => montantContrat = value; }

        public Commissaire(float tauxCommission, double montantContrat,string matricule,string nom,string prenom,string sexe):base(matricule,nom,prenom,sexe)
        {
            this.TauxCommission = tauxCommission;
            this.MontantContrat = montantContrat;
        }
        public Commissaire()
        {
           

        }
    }
}
