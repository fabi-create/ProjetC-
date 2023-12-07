/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 24/08/2023
 * Time: 00:41
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
	/// Description of Produits.
	/// </summary>
	public partial class Produits : Form
	{
		
		
		
		private MySqlConnection connection;
        private MySqlCommand command;
        private Produit produitSelectionne = null;
        private List<Produit> listeProduit = new List<Produit>();
        
        
		public Produits()
		{
			 InitializeComponent();
    InitializeDatabaseConnection();

    listeProduit = LoadProduitsData();
    


    // Suppression de l'auto-génération des colonnes
    tableauProduit.AutoGenerateColumns = false;

    // Configuration manuelle des colonnes pour les champs de Produit
    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
    idColumn.DataPropertyName = "id";
    idColumn.HeaderText = "ID";
    tableauProduit.Columns.Add(idColumn);

    DataGridViewTextBoxColumn libelleColumn = new DataGridViewTextBoxColumn();
    libelleColumn.DataPropertyName = "libelle";
    libelleColumn.HeaderText = "Libellé";
    tableauProduit.Columns.Add(libelleColumn);

    DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
    descriptionColumn.DataPropertyName = "categorie";
    descriptionColumn.HeaderText = "categorie";
    tableauProduit.Columns.Add(descriptionColumn);

    DataGridViewTextBoxColumn prixColumn = new DataGridViewTextBoxColumn();
    prixColumn.DataPropertyName = "prix";
    prixColumn.HeaderText = "Prix";
    tableauProduit.Columns.Add(prixColumn);


    
    
   
    DataGridViewTextBoxColumn quantiteColumn = new DataGridViewTextBoxColumn();
    quantiteColumn.DataPropertyName = "quantite";
    quantiteColumn.HeaderText = "Quantité";
    tableauProduit.Columns.Add(quantiteColumn);

    // Configuration terminée, définissez la source de données
    tableauProduit.DataSource = listeProduit;

    tableauProduit.SelectionChanged += tableauProduit_SelectionChanged;
    searchBox.TextChanged += RechercheTextBoxTextChanged;
//     
		}
		
		
	
		
		private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL. "Server=localhost;Database=test;UID=root;Pwd=";
          
            
           
         string connectionString =  "Database=projetC#;Data source=localhost;port=3308;User Id=root;password=;Integrated "+
					"security = true;Allow Zero Datetime=True;default command timeout=120";
            
            connection = new MySqlConnection(connectionString);
        }
		
		 
		
		
		 
		 
		
		private List<Produit> LoadProduitsData()
        {
            try
		    {
		        string query = "SELECT * FROM produits";
		        command = new MySqlCommand(query, connection);
		        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
		        DataTable dataTable = new DataTable();
		        adapter.Fill(dataTable);
		
		        foreach (DataRow row in dataTable.Rows)
		        {
		            Produit produit = new Produit 
		            {
		                id = Convert.ToInt32(row["id"]),
		                libelle = row["libelle"].ToString(),
		                categorie = row["categorie"].ToString(),
		                prix = Convert.ToDecimal(row["prix"]),
		                
		                quantite = Convert.ToInt32(row["quantite"])
		            };
		            
		            
		            listeProduit.Add(produit);
		        }
		        
		    }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            return listeProduit;
        }
		
		
		
		private void RechercheTextBoxTextChanged(object sender, EventArgs e)
			{
			    string rechercheText = searchBox.Text.Trim().ToLower(); // Convertissez le texte en minuscules pour la comparaison
			    List<Produit> produitsFiltres = new List<Produit>();
			
			    foreach (Produit produit in listeProduit)
			    {
			    	if (produit.libelle.ToLower().Contains(rechercheText)  || produit.categorie.ToLower().Contains(rechercheText) || produit.prix.ToString().ToLower().Contains(rechercheText) )
			        {
			           produitsFiltres.Add(produit);
			        }
			    }
			
			    tableauProduit.DataSource = produitsFiltres;
			}
		
	
		
		
		void tableauProduit_SelectionChanged(object sender, EventArgs e)
			{
			    if(tableauProduit.SelectedRows.Count > 0)
			    {
			        produitSelectionne = tableauProduit.SelectedRows[0].DataBoundItem as Produit;
			    }
			}
		void AddButtonClick(object sender, EventArgs e)
		{
	var formulaire = new FormProduit();
			formulaire.Show();
			this.Hide();
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
	
			if (produitSelectionne != null)
			{
			    var formulaire = new PreviewProduit(connection);
			    formulaire.produit = produitSelectionne;
			    formulaire.populate();
			    formulaire.Show();
			    this.Hide();
			}
			else
			{
			    MessageBox.Show("Veuillez sélectionner un utilisateur avant de mettre à jour.");
			}
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
	if (produitSelectionne != null)
            {
//                string mat = tableauUtilisateur.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    string query = "DELETE FROM produits WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", produitSelectionne.id);
					
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet produit ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes){
                    	connection.Open();
	                    cmd.ExecuteNonQuery();
	                    MessageBox.Show("produit supprimé avec succès !");
	                    connection.Close();
	
//	                    LoadEtudiantsData();
	                    
	                    listeProduit.Clear(); // Vider la liste actuelle 
			            listeProduit = LoadProduitsData(); // Recharger les données
			            tableauProduit.DataSource = null; // Reset la dataSource
			            tableauProduit.DataSource= listeProduit;
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
                MessageBox.Show("Sélectionnez un Produit à supprimer.");
            }

		}
		void QuitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			
			
				var pro = new ChefCuisinier();
			 pro.Show();
			this.Hide();
		}
		
	}
}
