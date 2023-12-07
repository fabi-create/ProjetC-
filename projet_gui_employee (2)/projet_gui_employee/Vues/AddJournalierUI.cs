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
    public partial class AddJournalierUI : Form
    {
        public List<Journalier> journalierList;
        public AddJournalierUI() 
        {
            journalierList = new List<Journalier>();
            InitializeComponent();
        }
        public List<Journalier> getListJournaliste()
        {
            return journalierList;
        }
        private void button_addJournalier_Click(object sender, EventArgs e)
        {
            if (textBox1_matricule.Text != null && textBox1_matricule.Text != "" && textBox2_nom.Text != null && textBox2_nom.Text != "" && textBox3_prenom.Text != null && textBox3_prenom.Text != "" && comboBox1_sexe.Text != null && comboBox1_sexe.Text != "" && textBox5_tauxjournalier.Text != "" && textBox5_tauxjournalier.Text != null && textBox6_nombrejours.Text != null && textBox6_nombrejours.Text != "")
            {

                string matricule = textBox1_matricule.Text,
                  nom = textBox2_nom.Text,
                  prenom = textBox3_prenom.Text;
                string sexe = comboBox1_sexe.Text.Trim();





                float tauxJournalier = float.Parse(textBox5_tauxjournalier.Text);
                 int nombreJours = int.Parse(textBox6_nombrejours.Text);
                   


                Journalier p = new Journalier(tauxJournalier, nombreJours, matricule,nom,prenom,sexe);


                journalierList.Add(p);


                afficherListe();

                MessageBox.Show("Ajout reussi");
               
                textBox6_nombrejours.Text = "";
                textBox5_tauxjournalier.Text = "";
                textBox3_prenom.Text = "";
                textBox2_nom.Text = "";
                textBox1_matricule.Text = "";
                comboBox1_sexe.Text = "";



            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }

        }
        public void afficherListe()
        {



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = journalierList;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
