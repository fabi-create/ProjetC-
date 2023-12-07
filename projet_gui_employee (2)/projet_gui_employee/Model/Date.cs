using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Model
{
    public class Date
    {
        private int jour;
        private int mois;
        private int annee;

        public int Jour { get => jour; set => jour = value; }
        public int Mois { get => mois; set => mois = value; }
        public int Annee { get => annee; set => annee = value; }

        public Date(int jour, int mois, int annee)
        {
            this.Jour = jour;
            this.Mois = mois;
            this.Annee = annee;
        }
        public Date()
        {
           
        }
    }
}
