/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/08/2023
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			
			InitializeComponent();
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
string connectionString =  "Database=projetC#;Data source=localhost;port=3308;User Id=root;password=;Integrated "+
					"security = true;Allow Zero Datetime=True;default command timeout=120";
		
	
	
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void LoginTextChanged(object sender, EventArgs e)
		{
	
		}
		void ConnectionClick(object sender, EventArgs e)
		{
	
		 string username = login.Text;
	 	string password = motdepasse.Text;
            string userType = UserType.SelectedItem.ToString(); // Récupère le type d'utilisateur sélectionné dans le ComboBox
            
             motdepasse.UseSystemPasswordChar = true;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM utilisateurs WHERE nom_utilisateur = @username AND mot_de_passe = @password AND type_utilisateur = @userType";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@userType", userType);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Authentification réussie !");

                        
                          switch (userType)
                {
                    case "Administrateur":
                        Administrateur adminForm = new Administrateur();
                        adminForm.Show();
                        break;

                    case "ChefCuisinier":
                        ChefCuisinier chefForm = new ChefCuisinier();
                        chefForm.Show();
                        break;

                    case "Restaurateur":
                        Restaurateur restoForm = new Restaurateur();
                        restoForm.Show();
                        break;

                    default:
                        MessageBox.Show("Type d'utilisateur non reconnu.");
                        break;
                }
            }
                        
            
                    else
                    {
                        MessageBox.Show("Échec de l'authentification. Vérifiez vos informations.");
                    }
                }
            }	
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void MotdepasseTextChanged(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}
