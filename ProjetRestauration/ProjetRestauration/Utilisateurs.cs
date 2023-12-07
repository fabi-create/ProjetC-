/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 13/08/2023
 * Time: 23:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace ProjetRestauration
{
	
	/// <summary>
	/// Description of Utilisateurs.
	/// </summary>
	public partial class Utilisateurs : Form
	{
		private MySqlConnection connection;
        private MySqlCommand command;
        private Utilisateur utilisateurSelectionne = null;
        private List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
        
		public Utilisateurs()
		{
			
			InitializeComponent();
			InitializeDatabaseConnection();
//			LoadEtudiantsData();
			listeUtilisateur = LoadUtilisateursData();
		
			
			tableauUtilisateur.DataSource = listeUtilisateur;
			
			tableauUtilisateur.SelectionChanged += tableauUtilisateur_SelectionChanged;
			searchBox.TextChanged += RechercheTextBoxTextChanged;
			
		}
		
		private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL. "Server=localhost;Database=test;UID=root;Pwd=";
          
            
           
         string connectionString =  "Database=projetC#;Data source=localhost;port=3308;User Id=root;password=;Integrated "+
					"security = true;Allow Zero Datetime=True;default command timeout=120";
            
            connection = new MySqlConnection(connectionString);
        }
		
		private List<Utilisateur> LoadUtilisateursData()
        {
            try
		    {
		        string query = "SELECT * FROM utilisateurs";
		        command = new MySqlCommand(query, connection);
		        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
		        DataTable dataTable = new DataTable();
		        adapter.Fill(dataTable);
		
		        foreach (DataRow row in dataTable.Rows)
		        {
		            Utilisateur utilisateur = new Utilisateur 
		            {
		                id = Convert.ToInt32(row["id"]),
		                nom_utilisateur = row["nom_utilisateur"].ToString(),
		                mot_de_passe = row["mot_de_passe"].ToString(),
		                type_utilisateur = row["type_utilisateur"].ToString(),
		                email = row["email"].ToString(),
		                Number = row["Number"].ToString()
		            };
		            
		            
		            listeUtilisateur.Add(utilisateur);
		        }
		        
		    }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            return listeUtilisateur;
        }
		
		
		
		private void RechercheTextBoxTextChanged(object sender, EventArgs e)
			{
			    string rechercheText = searchBox.Text.Trim().ToLower(); // Convertissez le texte en minuscules pour la comparaison
			    List<Utilisateur> utilisateursFiltres = new List<Utilisateur>();
			
			    foreach (Utilisateur utilisateur in listeUtilisateur)
			    {
			    	if (utilisateur.nom_utilisateur.ToLower().Contains(rechercheText)  || utilisateur.type_utilisateur.ToLower().Contains(rechercheText) || utilisateur.email.ToLower().Contains(rechercheText) )
			        {
			           utilisateursFiltres.Add(utilisateur);
			        }
			    }
			
			    tableauUtilisateur.DataSource = utilisateursFiltres;
			}
		
	
		
		
		void tableauUtilisateur_SelectionChanged(object sender, EventArgs e)
			{
			    if(tableauUtilisateur.SelectedRows.Count > 0)
			    {
			        utilisateurSelectionne = tableauUtilisateur.SelectedRows[0].DataBoundItem as Utilisateur;
			    }
			}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			var formulaire = new FormUtilisateur();
			formulaire.Show();
			this.Hide();
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
			
			if (utilisateurSelectionne != null)
			{
			    var formulaire = new PreviewUtilisateur(connection);
			    formulaire.utilisateur = utilisateurSelectionne;
			    formulaire.populate();
			    formulaire.Show();
			    this.Hide();
			}
			else
			{
			    MessageBox.Show("Veuillez sélectionner un utilisateur avant de mettre à jour.");
			}
		}
		
		void QuitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
		   if (utilisateurSelectionne != null)
            {
//                string mat = tableauUtilisateur.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    string query = "DELETE FROM utilisateurs WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", utilisateurSelectionne.id);
					
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes){
                    	connection.Open();
	                    cmd.ExecuteNonQuery();
	                    MessageBox.Show("Utilisateur supprimé avec succès !");
	                    connection.Close();
	
//	                    LoadEtudiantsData();
	                    
	                    listeUtilisateur.Clear(); // Vider la liste actuelle 
			            listeUtilisateur = LoadUtilisateursData(); // Recharger les données
			            tableauUtilisateur.DataSource = null; // Reset la dataSource
			            tableauUtilisateur.DataSource= listeUtilisateur;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un utilisateur à supprimer.");
            }

		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void UtilisateursLoad(object sender, EventArgs e)
		{
	
		}
		void SearchBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void TableauUtilisateurCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
	}
}
