/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 13/08/2023
 * Time: 23:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetRestauration
{/// <summary>
	/// Description of FormUtilisateur.
	/// </summary>
	public partial class FormUtilisateur : Form
	{
		private MySqlConnection connection;
        private MySqlCommand command;
        public Utilisateur utilisateur {set;get;}
        
        public void populate()
        {
        	if(utilisateur != null){
        		idBox.Text =utilisateur.id.ToString();
	        	nomBox.Text = utilisateur.nom_utilisateur;
	        	passeBox.Text = utilisateur.mot_de_passe;
	        	typecomboBox.Text = utilisateur.type_utilisateur;
	        	emailBox.Text = utilisateur.email;
	        	numberBox.Text = utilisateur.Number;
        	}
        	
        }
        
		public FormUtilisateur()
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
            string connectionString = "Server=localhost;Database=projetC#;Uid=root; port=3308;Pwd=";
            connection = new MySqlConnection(connectionString);
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			string id = idBox.Text;
			string nom = nomBox.Text;
			string passe = passeBox.Text;
			string email = emailBox.Text;
			string number = numberBox.Text;
			string type = typecomboBox.Text;
	
			 try
            {
                connection.Open();
                string query = "INSERT INTO utilisateurs (id, nom_utilisateur,mot_de_passe, type_utilisateur, email, Number) " +
                               "VALUES (@id, @nom, @passe, @type, @email, @number)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@passe", passe);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@number", number);

                command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur enregistré avec succès !");

                // Effacer les champs après l'enregistrement
                idBox.Text = "";
                nomBox.Text = "";
                passeBox.Text = "";
                emailBox.Text = "";
                numberBox.Text = "";
                typecomboBox.Text = "";
                
             
                
                
//                var previewEtudiant = new PreviewEtudiant();
//                previewEtudiant.Show();
				
				var utilisateurs = new Utilisateurs();
				utilisateurs.Show();
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
			var Administrateur = new Administrateur();
			Administrateur.Show();
			this.Hide();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void FormUtilisateurLoad(object sender, EventArgs e)
		{
	
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}

	}
}
