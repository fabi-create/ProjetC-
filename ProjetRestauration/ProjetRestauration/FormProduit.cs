/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 14/08/2023
 * Time: 01:22
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
	/// Description of FormProduit.
	/// </summary>
	public partial class FormProduit : Form
	{
		
		private MySqlConnection connection;
        private MySqlCommand command;
        public Produit produit {set;get;}
        
        public void populate()
        {
        	if(produit != null){
        		textBoxId.Text =produit.id.ToString();
	        	textBoxLibelle.Text = produit.libelle;
	        	textBoxDescription.Text = produit.categorie;
	        	textBoxPrix.Text = produit.prix.ToString();
	        
	        	textBox1.Text =produit.quantite.ToString();
	        
        	}
        	
        }
		public FormProduit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			
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
			string idProduit = textBoxId.Text;
			string libelle = textBoxLibelle.Text;
			string categorie= textBoxDescription.Text;
		
			Decimal prix = decimal.Parse(textBoxPrix.Text);
			int quantite = int.Parse(textBox1.Text);
			
			
			
			 try
            {
                connection.Open();
                string query = "INSERT INTO produits (id, libelle, categorie, prix, quantite) " +
                               "VALUES (@id, @libelle, @categorie, @prix, @quantite)";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idProduit);
                command.Parameters.AddWithValue("@libelle", libelle);
                command.Parameters.AddWithValue("@categorie", categorie);
                
                command.Parameters.AddWithValue("@prix", prix);
               command.Parameters.AddWithValue("@quantite", quantite);

                command.ExecuteNonQuery();
                MessageBox.Show("Produit enregistré avec succès !");

                // Effacer les champs après l'enregistrement
                textBoxId.Text = "";
                textBoxLibelle.Text = "";
                textBoxDescription.Text = "";
               
            
               textBoxPrix.Text = "";
                textBox1.Text = "";
              
//                var previewEtudiant = new PreviewEtudiant();
//                previewEtudiant.Show();
				
				var produits = new Produits();
				produits.Show();
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
			var cuisinier = new ChefCuisinier();
			cuisinier.Show();
			this.Hide();
		}
		
		void FormProduitLoad(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			ImageProduit nouvelleFenetre = new ImageProduit();

            // Affichez la nouvelle fenêtre
            nouvelleFenetre.Show();	          
				
			
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
