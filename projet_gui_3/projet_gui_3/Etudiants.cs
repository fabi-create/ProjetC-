/*
 *
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace projet_gui_3
{
	/// <summary>
	/// Description of Etudiants.
	/// </summary>
	public partial class Etudiants : Form
	{
		private MySqlConnection connection;
        private MySqlCommand command;
        private Etudiant etudiantSelectionne = null;
        private List<Etudiant> listeEtudiant = new List<Etudiant>();
        
		public Etudiants()
		{
			
			InitializeComponent();
			InitializeDatabaseConnection();
//			LoadEtudiantsData();
			listeEtudiant = LoadEtudiantsData();
			tableauEtudiant.DataSource = listeEtudiant;
			
			tableauEtudiant.SelectionChanged += tableauEtudiant_SelectionChanged;
			searchBox.TextChanged += RechercheTextBoxTextChanged;
		}
		
		private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL.
           string connectionString = "Server=localhost;Database=etudiant_db;UID=root;PASSWORD=";
            
            
            connection = new MySqlConnection(connectionString);
        }
		
		private List<Etudiant> LoadEtudiantsData()
        {
            try
		    {
		        string query = "SELECT * FROM t_etudiants";
		        command = new MySqlCommand(query, connection);
		        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
		        DataTable dataTable = new DataTable();
		        adapter.Fill(dataTable);
		
		        foreach (DataRow row in dataTable.Rows)
		        {
		            Etudiant etudiant = new Etudiant
		            {
		                matricule = Convert.ToInt32(row["matricule"]),
		                nom = row["nom"].ToString(),
		                prenom = row["prenom"].ToString(),
		                classe = row["classe"].ToString(),
		                moyenne = Convert.ToDouble(row["moyenne"]),
		                nationalite = row["nationalite"].ToString()
		            };
		            
		            listeEtudiant.Add(etudiant);
		        }
		        
		    }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            return listeEtudiant;
        }
		
		private void RechercheTextBoxTextChanged(object sender, EventArgs e)
			{
			    string rechercheText = searchBox.Text.Trim().ToLower(); // Convertissez le texte en minuscules pour la comparaison
			    List<Etudiant> etudiantsFiltres = new List<Etudiant>();
			
			    foreach (Etudiant etudiant in listeEtudiant)
			    {
			    	if (etudiant.nom.ToLower().Contains(rechercheText)  || etudiant.prenom.ToLower().Contains(rechercheText) || etudiant.nationalite.ToLower().Contains(rechercheText) )
			        {
			            etudiantsFiltres.Add(etudiant);
			        }
			    }
			
			    tableauEtudiant.DataSource = etudiantsFiltres;
			}
		
		void tableauEtudiant_SelectionChanged(object sender, EventArgs e)
			{
			    if(tableauEtudiant.SelectedRows.Count > 0)
			    {
			        etudiantSelectionne = tableauEtudiant.SelectedRows[0].DataBoundItem as Etudiant;
			    }
			}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			var formulaire = new FormEtudiant();
			formulaire.Show();
			this.Hide();
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
			
			if (etudiantSelectionne != null)
			{
			    var formulaire = new PreviewEtudiant(connection);
			    formulaire.etudiant = etudiantSelectionne;
			    formulaire.populate();
			    formulaire.Show();
			    this.Hide();
			}
			else
			{
			    MessageBox.Show("Veuillez sélectionner un étudiant avant de mettre à jour.");
			}
		}
		
		void QuitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
		   if (etudiantSelectionne != null)
            {
//                string mat = tableauEtudiant.SelectedRows[0].Cells["Matricule"].Value.ToString();

                try
                {
                    string query = "DELETE FROM t_etudiants WHERE Matricule = @Matricule";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricule", etudiantSelectionne.matricule);
					
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet étudiant ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes){
                    	connection.Open();
	                    cmd.ExecuteNonQuery();
	                    MessageBox.Show("Étudiant supprimé avec succès !");
	                    connection.Close();
	
//	                    LoadEtudiantsData();
	                    
	                    listeEtudiant.Clear(); // Vider la liste actuelle 
			            listeEtudiant = LoadEtudiantsData(); // Recharger les données
			            tableauEtudiant.DataSource = null; // Reset la dataSource
			            tableauEtudiant.DataSource = listeEtudiant;
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
                MessageBox.Show("Sélectionnez un étudiant à supprimer.");
            }

		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void EtudiantsLoad(object sender, EventArgs e)
		{
	
		}
		
	}
}
