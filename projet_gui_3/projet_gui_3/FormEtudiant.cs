/*
 * Created by SharpDevelop.
 * User: Yvan GBAFFONOU
 * Date: 04/08/2023
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace projet_gui_3
{
	/// <summary>
	/// Description of FormEtudiant.
	/// </summary>
	public partial class FormEtudiant : Form
	{
		private MySqlConnection connection;
        private MySqlCommand command;
        public Etudiant etudiant {set;get;}
        
        public void populate()
        {
        	if(etudiant != null){
        		matriculeBox.Text = etudiant.matricule.ToString();
	        	nomBox.Text = etudiant.nom;
	        	prenomBox.Text = etudiant.prenom;
	        	classeBox.Text = etudiant.classe;
	        	moyenneBox.Text = etudiant.moyenne.ToString();
	        	nationaliteBox.Text = etudiant.nationalite;
        	}
        	
        }
        
		public FormEtudiant()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();

		}
		
		private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL.
            string connectionString = "Server=localhost;Database=etudiant_db;Uid=root;Pwd=";
            connection = new MySqlConnection(connectionString);
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			string matricule = matriculeBox.Text;
			string nom = nomBox.Text;
			string prenom = prenomBox.Text;
			string classe = classeBox.Text;
			double moyenne = double.Parse(moyenneBox.Text);
			string nationalite = nationaliteBox.Text;
			
			 try
            {
                connection.Open();
                string query = "INSERT INTO t_etudiants (Matricule, Nom, Prenom, Classe, Moyenne, Nationalite) " +
                               "VALUES (@Matricule, @Nom, @Prenom, @Classe, @Moyenne, @Nationalite)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Matricule", matricule);
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@Classe", classe);
                command.Parameters.AddWithValue("@Moyenne", moyenne);
                command.Parameters.AddWithValue("@Nationalite", nationalite);

                command.ExecuteNonQuery();
                MessageBox.Show("Étudiant enregistré avec succès !");

                // Effacer les champs après l'enregistrement
                matriculeBox.Text = "";
                nomBox.Text = "";
                prenomBox.Text = "";
                classeBox.Text = "";
                moyenneBox.Text = "";
                nationaliteBox.Text = "";
                
//                var previewEtudiant = new PreviewEtudiant();
//                previewEtudiant.Show();
				
				var etudiants = new Etudiants();
				etudiants.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
				
		}
		void Button2Click(object sender, EventArgs e)
		{
			var montraitement = new MonTraitement();
			montraitement.Show();
			this.Hide();
		}

	}
}
