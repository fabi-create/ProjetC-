/*

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
	/// Description of PreviewEtudiant.
	/// </summary>
	public partial class PreviewEtudiant : Form
	{
		private MySqlConnection connection;
		
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
        
		public PreviewEtudiant(MySqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			var etudiants = new Etudiants();
			etudiants.Show();
			this.Close();
		}
		
		void UpdateEtudiant(string matricule)
		{
		    try
		    {
		        string query = "UPDATE t_etudiants SET Nom = @Nom, Prenom = @Prenom, Classe = @Classe, Moyenne = @Moyenne, Nationalite = @Nationalite WHERE Matricule = @Matricule";
		        MySqlCommand cmd = new MySqlCommand(query, connection);
		        cmd.Parameters.AddWithValue("@Matricule", matricule);
		        cmd.Parameters.AddWithValue("@Nom", nomBox.Text);
		        cmd.Parameters.AddWithValue("@Prenom", prenomBox.Text);
		        cmd.Parameters.AddWithValue("@Classe", classeBox.Text);
		        cmd.Parameters.AddWithValue("@Moyenne", Convert.ToDouble(moyenneBox.Text)); // Assurez-vous que la conversion est correcte
		        cmd.Parameters.AddWithValue("@Nationalite", nationaliteBox.Text);
		
		        connection.Open();
		        cmd.ExecuteNonQuery();
		        MessageBox.Show("Étudiant mis à jour avec succès !");
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
            string matricule = matriculeBox.Text;
			UpdateEtudiant(matricule);
			
			var etudiants = new Etudiants();
			etudiants.Show();
			this.Close();
		}
		
	}
}
