using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDevises
{
   

    public class Traitement
    {
        private double montant;
        private double resultat;

        public double Montant { get => montant; set => montant = value; }
        public double Resultat { get => resultat; set => resultat = value; }

        public Traitement(double montant,double resultat)
        {
            this.Montant = montant;
            this.Resultat = resultat;
        }

        public Traitement()
        {
        }

        //Conversion Euro Vers ----------------
        public double conversionEuroVersDollar()
        {
            resultat = montant * 1.09;
            return resultat;
        }
        public double conversionEuroVersEuro()
        {
            resultat = montant;
            return resultat;
        }
        public double conversionEuroVersCfa()
        {
            resultat = montant * 655.78;
            return resultat;
        }
        public double conversionEuroVersYen()
        {
            resultat = montant * 158.33;
            return resultat;
        }
        public double conversionEuroVersUae()
        {
            resultat = montant * 4.00;
            return resultat;
        }

        //Conversion dollar vers ---------
        public double conversionDollarVersEuro()
        {
            resultat = montant * 0.92;
            return resultat;
        }
        public double conversionDollarVersDollar()
        {
            resultat = montant;
            return resultat;
        }
        public double conversionDollarVersCfa()
        {
            resultat = montant * 601.35;
            return resultat;
        }
        public double conversionDollarVersYen()
        {
            resultat = montant * 145.26;
            return resultat;
        }
        public double conversionDollarVersUae()
        {
            resultat = montant * 3.67;
            return resultat;
        }

        //Conversion de CFA vers *************
        public double conversionCfaVersEuro()
        {
            resultat = montant * 0.0015;
            return resultat;
        }
        public double conversionCfaVersDollar()
        {
            resultat = montant * 0.0016;
            return resultat;
        }
        public double conversionCfaVersCfa()
        {
            resultat = montant;
            return resultat;
        }
        public double conversionCfaVersYen()
        {
            resultat = montant * 0.24;
            return resultat;
        }

        public double conversionCfaVersUae()
        {
            resultat = montant * 0.0061050863;
            return resultat;
        }

        //Conversion de yen vers *********

        public double conversionYenVersEuro()
        {
            resultat = montant * 0.0063;
            return resultat;
        }
        public double conversionYenVersDollar()
        {
            resultat = montant * 0.0069;
            return resultat;
        }
        public double conversionYenVersCfa()
        {
            resultat = montant * 4.14;
            return resultat;
        }
        public double conversionYenVersYen()
        {
            resultat = montant;
            return resultat;
        }
        public double conversionYenVersUae()
        {
            resultat = montant * 0.025;
            return resultat;
        }

        //Conversion de UAE vers ********
        public double conversionUaeVersEuro()
        {
            resultat = montant * 0.25;
            return resultat;
        }
        public double conversionUaeVersDollar()
        {
            resultat = montant * 0.27;
            return resultat;
        }
        public double conversionUaeVersCfa()
        {
            resultat = montant * 163.58672;
            return resultat;
        }
        public double conversionUaeVersUae()
        {
            resultat = montant;
            return resultat;
        }
        public double conversionUaeVersYen()
        {
            resultat = montant * 39.56;
            return resultat;
        }








    }
}
