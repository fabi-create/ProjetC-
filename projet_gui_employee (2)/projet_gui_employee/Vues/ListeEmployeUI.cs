using projet_gui_employee.Controller;
using projet_gui_employee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gui_employee.Vues
{
    public partial class ListeEmployeUI : Form
    {
        private List<Employe> liste;
        public ListeEmployeUI()
        {
            liste = new List<Employe>();
            InitializeComponent();
        }

        private void ListeEmployeUI_Load(object sender, EventArgs e)
        {

        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            AddCommissaire addCommissaire = new AddCommissaire();
           List<Commissaire> commissaire = addCommissaire.getListCommaires();

            AddJournalierUI addJournaliste = new AddJournalierUI();
            List<Journalier> journaliers = addJournaliste.getListJournaliste();


            AddPermanentUI addPermanent = new AddPermanentUI();
            List<Permanent> permanents = addPermanent.getListPermanent();

            
            Traitement traitement = new Traitement();
            liste = traitement.liste(permanents, journaliers, commissaire);
            dataGridView1.DataSource = liste;


        }
    }
    
}
