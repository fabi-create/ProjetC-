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
    public partial class AddCommissaire : Form
    {
        public List<Commissaire> commissaireList;

        public AddCommissaire()
        {
            commissaireList = new List<Commissaire>();
            InitializeComponent();
        }
        public List<Commissaire> getListCommaires()
        {
            return commissaireList;
        }
        private void button_addCommissaire_Click(object sender, EventArgs e)
        {
            if (textBox1_matricule.Text != null && textBox1_matricule.Text != "" && textBox2_nom.Text != null && textBox2_nom.Text != "" && textBox3_prenom.Text != null && textBox3_prenom.Text != "" && comboBox1_sexe.Text != null && comboBox1_sexe.Text != "" && textBox5_tauxCommission.Text != "" && textBox5_tauxCommission.Text != null && textBox6_montantContrat.Text != null && textBox6_montantContrat.Text != "")
            {

                string matricule = textBox1_matricule.Text,
                  nom = textBox2_nom.Text,
                  prenom = textBox3_prenom.Text;
                string sexe = comboBox1_sexe.Text.Trim();





                float tauxCommission = float.Parse(textBox5_tauxCommission.Text);
                double montantContrat = double.Parse(textBox6_montantContrat.Text);


                Commissaire p = new Commissaire(tauxCommission, montantContrat, matricule, nom, prenom, sexe);


                commissaireList.Add(p);


                afficherListe();

                MessageBox.Show("Ajout reussi");

                textBox6_montantContrat.Text = "";
                textBox5_tauxCommission.Text = "";
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
            dataGridView1.DataSource = commissaireList;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
