using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Model
{
    public class Employe
    {
        private string matricule;
        private string nom;
        private string prenom;
        private string sexe;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }

        public Employe(string matricule, string nom, string prenom, string sexe)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
        }
        public Employe()
        {
           
        }
    }
}
