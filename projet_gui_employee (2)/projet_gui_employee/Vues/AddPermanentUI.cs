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
    public partial class AddPermanentUI : Form
    {
        public List<Permanent> permaList = new List<Permanent>();
        public AddPermanentUI()
        {
            
            InitializeComponent();
        }
        public List<Permanent> getListPermanent()
        {
            return permaList;
        }

        private void AddPermanentUI_Load(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_addPermanent_Click(object sender, EventArgs e)
        {
           

            if (textBox1_matricule.Text != null && textBox1_matricule.Text != "" && textBox2_nom.Text != null && textBox2_nom.Text != "" && textBox3_prenom.Text != null && textBox3_prenom.Text != "" && comboBox1_sexe.Text != null && comboBox1_sexe.Text != "" && textBox5_salaire.Text != "" && textBox5_salaire.Text != null && textBox6_prime.Text != null && textBox6_prime.Text != "" && textBox7_retenue.Text != null && textBox7_retenue.Text != "")
            {
               
                    string matricule = textBox1_matricule.Text,
                      nom = textBox2_nom.Text,
                      prenom = textBox3_prenom.Text;
                    string sexe = comboBox1_sexe.Text.Trim();



                    DateTime date = DateTime.Parse(dateTimePicker1.Text);

                    double salaire = double.Parse(textBox5_salaire.Text),
                       prime = double.Parse(textBox6_prime.Text),
                       retenue = double.Parse(textBox7_retenue.Text);


                Permanent p = new Permanent(salaire, prime, retenue, date, matricule, nom, prenom, sexe);


                permaList.Add(p);

               
                afficherListe();
          
                MessageBox.Show("Ajout reussi");
                    textBox7_retenue.Text = "";
                    textBox6_prime.Text = "";
                    textBox5_salaire.Text = "";
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
            dataGridView1.DataSource = permaList;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }                                                                                                                                                                                                   
}
