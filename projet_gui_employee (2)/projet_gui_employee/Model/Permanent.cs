using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Model
{
    public class Permanent:Employe
    {
        private double salaireBase;
        private double prime;
        private double retenue;
        private DateTime dateEmbauche;

        List<Permanent> permaList;

        public Permanent(double salaireBase, double prime, double retenue, DateTime dateEmbauche,string matricule,string nom,string prenom,string sexe):base(matricule,nom,prenom,sexe)
        {
            this.SalaireBase = salaireBase;
            this.Prime = prime;
            this.Retenue = retenue;
            this.DateEmbauche = dateEmbauche;
        }

        public Permanent()
        {
           
        }

        public double SalaireBase { get => salaireBase; set => salaireBase = value; }
        public double Prime { get => prime; set => prime = value; }
        public double Retenue { get => retenue; set => retenue = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
    
        public  List<Permanent> list(Permanent p)
        {
            permaList = new List<Permanent>();
            permaList.Add(p);
            return permaList;

        }
    }
}
