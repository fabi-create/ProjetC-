using projet_gui_employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_gui_employee.Controller
{
   
    public class Traitement
    {
        private List<Employe> employeLis = new List<Employe>();

        public List<Employe> liste(List<Permanent> permanents,List<Journalier> journaliers,List<Commissaire> commissaires)
        {
            employeLis.AddRange(commissaires);
            employeLis.AddRange(journaliers);
            employeLis.AddRange(permanents);
            return employeLis;

        }
    }
}
