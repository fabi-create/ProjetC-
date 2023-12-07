using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeDevises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_dollar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1_euro.Checked && radioButton_dollar.Checked)
            {
                double resultat = 0;
                double montant;
                montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant,resultat);
                resultat = traiter.conversionEuroVersDollar();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton2_dollar.Checked && radioButton_dollar.Checked)
            {
                double resultat = 0;
                double montant;
                montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionDollarVersDollar();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }else if(radioButton3_cfa.Checked && radioButton_dollar.Checked)
            {
                double resultat = 0;
                double montant;
                montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionCfaVersDollar();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton4_yen.Checked && radioButton_dollar.Checked)
            {
                double resultat = 0;
                double montant;
                montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionYenVersDollar();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else
            {
                double resultat = 0;
                double montant;
                montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionUaeVersDollar();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
        }

        private void radioButton_euro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_euro.Checked && radioButton_euro.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionEuroVersEuro();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }else if(radioButton2_dollar.Checked && radioButton_euro.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionDollarVersEuro();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }else if(radioButton3_cfa.Checked && radioButton_euro.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionCfaVersEuro();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }else if(radioButton4_yen.Checked && radioButton_euro.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionYenVersEuro();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionUaeVersEuro();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }

        }

        private void radioButton_cfa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_euro.Checked && radioButton_cfa.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionEuroVersCfa();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton2_dollar.Checked && radioButton_cfa.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionDollarVersCfa();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton3_cfa.Checked && radioButton_cfa.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionCfaVersCfa();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }else if(radioButton4_yen.Checked && radioButton_cfa.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionYenVersCfa();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionUaeVersCfa();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
        }

        private void radioButton_yen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_euro.Checked && radioButton_yen.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionEuroVersYen();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton2_dollar.Checked && radioButton_yen.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionDollarVersYen();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton3_cfa.Checked && radioButton_yen.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionCfaVersYen();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else if(radioButton4_yen.Checked && radioButton_yen.Checked)
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionYenVersYen();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            else
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionUaeVersYen();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
        }

        private void radioButton_uae_CheckedChanged(object sender, EventArgs e)
        {
            
                if (radioButton1_euro.Checked && radioButton_uae.Checked)
                {
                    double resultat = 0;
                    double montant = double.Parse(textBox_montant.Text);
                    Traitement traiter = new Traitement(montant, resultat);
                    resultat = traiter.conversionEuroVersUae();
                    textBox1_resultat.Text = resultat.ToString("0.00");
                }
                else if(radioButton2_dollar.Checked && radioButton_uae.Checked)
                {
                    double resultat = 0;
                    double montant = double.Parse(textBox_montant.Text);
                    Traitement traiter = new Traitement(montant, resultat);
                    resultat = traiter.conversionDollarVersUae();
                    textBox1_resultat.Text = resultat.ToString("0.00");
                  }
                else if(radioButton3_cfa.Checked && radioButton_uae.Checked)
                {
                    double resultat = 0;
                    double montant = double.Parse(textBox_montant.Text);
                    Traitement traiter = new Traitement(montant, resultat);
                    resultat = traiter.conversionCfaVersUae();
                    textBox1_resultat.Text = resultat.ToString("0.00");
                }
                else if(radioButton4_yen.Checked && radioButton_uae.Checked)
                 {
                    double resultat = 0;
                    double montant = double.Parse(textBox_montant.Text);
                    Traitement traiter = new Traitement(montant, resultat);
                    resultat = traiter.conversionYenVersUae();
                    textBox1_resultat.Text = resultat.ToString("0.00");

            }
            else
            {
                double resultat = 0;
                double montant = double.Parse(textBox_montant.Text);
                Traitement traiter = new Traitement(montant, resultat);
                resultat = traiter.conversionUaeVersUae();
                textBox1_resultat.Text = resultat.ToString("0.00");
            }
            
        }

        private void radioButton4_yen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_effacer_Click(object sender, EventArgs e)
        {
            radioButton1_euro.Checked = false;
            radioButton2_dollar.Checked = false;
            radioButton3_cfa.Checked = false;
            radioButton4_yen.Checked = false;
            radioButton5_uae.Checked = false;
            radioButton_euro.Checked = false;
            radioButton_dollar.Checked = false;
            radioButton_cfa.Checked = false;
            radioButton_yen.Checked = false;
            radioButton_uae.Checked = false;
            textBox_montant.Text = "";
            textBox1_resultat.Text = "";
        }

        private void button1_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
