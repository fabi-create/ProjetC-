/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 14/08/2023
 * Time: 00:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of PreviewEtudiant.
	/// </summary>
	public partial class PreviewUtilisateur : Form
	{
		private MySqlConnection connection;
		
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
        
		public PreviewUtilisateur(MySqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			var utilisateurs = new Utilisateurs();
			utilisateurs.Show();
			this.Close();
		}
		
		void UpdateUtilisateur(string id)
		{
		    try
		    {
		        string query = "UPDATE utilisateurs SET nom_utilisateur = @nom_utilisateur, mot_de_passe = @mot_de_passe, type_utilisateur = @type_utilisateur, email = @email, Number = @Number WHERE id = @id";
		        MySqlCommand cmd = new MySqlCommand(query, connection);
		        cmd.Parameters.AddWithValue("@id", idBox.Text);
		        cmd.Parameters.AddWithValue("@nom_utilisateur", nomBox.Text);
		        cmd.Parameters.AddWithValue("@mot_de_passe", passeBox.Text);
		        cmd.Parameters.AddWithValue("@type_utilisateur", typecomboBox.Text);
		        cmd.Parameters.AddWithValue("@email",emailBox.Text); // Assurez-vous que la conversion est correcte
		        cmd.Parameters.AddWithValue("@Number", numberBox.Text);
		
		        connection.Open();
		        cmd.ExecuteNonQuery();
		        MessageBox.Show("Utilisateur mis à jour avec succès !");
		        connection.Close();
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
		        connection.Close();
		    }
		}
		
		
		void ConfirmButtonClick(object sender, EventArgs e)
		{
            string id = idBox.Text;
			UpdateUtilisateur(id);
			
			var utilisateurs = new Utilisateurs();
			utilisateurs.Show();
			this.Close();
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			    string id = idBox.Text;
			UpdateUtilisateur(id);
			
			var utilisateurs = new Utilisateurs();
			utilisateurs.Show();
			this.Close();
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		
	}
}
