/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 00:45
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
	/// Description of FormCommande.
	/// </summary>
	public partial class FormCommande : Form
	{

		private List<Commande> listeCommande= new List<Commande>();
		private Commande commandeSelectionne = null;
		private MySqlConnection connection;
        private MySqlCommand command;
        public Commande commande {set;get;}
        
        public void populate()
        {
        	if(commande != null){
        		textBox1.Text =commande.id.ToString();
	        	textBox2.Text = commande.libelleCommande;
	        	textBox3.Text = commande.nomPrenomClient;
	        	textBox4.Text = commande.telephoneClient.ToString();
	        	comboBox1.Text = commande.etatCommande.ToString();
	        
        	}
        	
        	
        	
        }
		public FormCommande()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			
		listeCommande = LoadCommandesData();
		
			
			tableauCommande.DataSource = listeCommande;
			
			tableauCommande.SelectionChanged += tableauCommande_SelectionChanged;
			searchBox.TextChanged += RechercheTextBoxTextChanged;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL.
            string connectionString = "Server=localhost;Database=projetC#;Uid=root; port=3308;Pwd=";
            connection = new MySqlConnection(connectionString);
        }

		
		
		void Button1Click(object sender, EventArgs e)
{
    string id = textBox1.Text;
    string libelleCommande = textBox2.Text;
    string nomPrenomClient = textBox3.Text;
    int etatCommande = int.Parse(comboBox1.Text);
    int telephoneClient = int.Parse(textBox4.Text);

    try
    {
        connection.Open();
        string query = "INSERT INTO commandes (id, libelleCommande, nomPrenomClient, telephoneClient, etatCommande) " +
                       "VALUES (@id, @libelleCommande, @nomPrenomClient ,@telephoneClient, @etatCommande)";
        command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", id);
        command.Parameters.AddWithValue("@libelleCommande", libelleCommande);
        command.Parameters.AddWithValue("@nomPrenomClient", nomPrenomClient);
        command.Parameters.AddWithValue("@telephoneClient", telephoneClient);
        command.Parameters.AddWithValue("@etatCommande", etatCommande);

        command.ExecuteNonQuery();
        MessageBox.Show("Commande enregistré avec succès !");

        // Ajouter la nouvelle commande à la liste
        Commande nouvelleCommande = new Commande
        {
            id = Convert.ToInt32(id),
            libelleCommande = libelleCommande,
            nomPrenomClient = nomPrenomClient,
            telephoneClient = telephoneClient,
            etatCommande = etatCommande
        };
        listeCommande.Add(nouvelleCommande);

        // Mise à jour de la source de données du tableau
        tableauCommande.DataSource = null; // Réinitialise la source de données
        tableauCommande.DataSource = listeCommande; // Met à jour la source de données

        // Rendre le panneau visible
        panel2.Visible = true;
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

		
		public void ShowPanel()
{
    panel2.Visible = true;
}
		
		
		private List<Commande> LoadCommandesData()
        {
            try
		    {
		        string query = "SELECT * FROM commandes";
		        command = new MySqlCommand(query, connection);
		        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
		        DataTable dataTable = new DataTable();
		        adapter.Fill(dataTable);
		
		        foreach (DataRow row in dataTable.Rows)
		        {
		            Commande commande = new Commande 
		            {
		                id = Convert.ToInt32(row["id"]),
		               libelleCommande = row["libelleCommande"].ToString(),
		                nomPrenomClient = row["nomPrenomClient"].ToString(),
		                telephoneClient = Convert.ToInt32(row["telephoneClient"]),
		                 etatCommande = Convert.ToInt32(row["etatCommande"])
		            };
		            
		            
		            listeCommande.Add(commande);
		        }
		        
		    }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            return listeCommande;
        }
		
		
		
		private void RechercheTextBoxTextChanged(object sender, EventArgs e)
			{
			    string rechercheText = searchBox.Text.Trim().ToLower(); // Convertissez le texte en minuscules pour la comparaison
			    List<Commande> commandesFiltres = new List<Commande>();
			
			    foreach (Commande commande in listeCommande)
			    {
			    	if (commande.libelleCommande.ToLower().Contains(rechercheText)  || commande.nomPrenomClient.ToLower().Contains(rechercheText) || commande.etatCommande.ToString().ToLower().Contains(rechercheText) )
			        {
			          commandesFiltres.Add(commande);
			        }
			    }
			
			    tableauCommande.DataSource = commandesFiltres;
			}
		
	
		
		
		void tableauCommande_SelectionChanged(object sender, EventArgs e)
			{
			    if(tableauCommande.SelectedRows.Count > 0)
			    {
			        commandeSelectionne = tableauCommande.SelectedRows[0].DataBoundItem as Commande;
			    }
			}
		
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			
    panel1.Visible =true; // Cacher le panel1
    panel2.Visible = true; 
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			var listecommande = new ListeCommandes();
			listecommande.Show();
			this.Hide();
		}
		void UpdateButtonClick(object sender, EventArgs e)
		{
	
			if (commandeSelectionne != null)
			{
			    var formulaire = new PreviewCommande(connection);
			    formulaire.commande = commandeSelectionne;
			    formulaire.populate();
			    formulaire.Show();
			    this.Hide();
			}
			else
			{
			    MessageBox.Show("Veuillez sélectionner un utilisateur avant de mettre à jour.");
		}
			
		}
		void Button4Click(object sender, EventArgs e)
		{
	if (commandeSelectionne != null)
            {
//                string mat = tableauUtilisateur.SelectedRows[0].Cells["id"].Value.ToString();

                try
                {
                    string query = "DELETE FROM commandes WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", commandeSelectionne.id);
					
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette commande ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes){
                    	connection.Open();
	                    cmd.ExecuteNonQuery();
	                    MessageBox.Show("Commande supprimée avec succès !");
	                    connection.Close();
	
//	                    LoadEtudiantsData();
	                    
	                    listeCommande.Clear(); // Vider la liste actuelle 
			            listeCommande = LoadCommandesData(); // Recharger les données
			            tableauCommande.DataSource = null; // Reset la dataSource
			            tableauCommande.DataSource= listeCommande;
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
	}
}
