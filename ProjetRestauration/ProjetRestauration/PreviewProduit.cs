/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 15/08/2023
 * Time: 14:00
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
	/// Description of PreviewProduit.
	/// </summary>
	public partial class PreviewProduit : Form
	{
		private MySqlConnection connection;
		
		public Produit produit {set;get;}
        
        public void populate()
        {
        	if(produit != null){
        		textBoxId.Text =produit.id.ToString();
	        	textBoxLibelle.Text = produit.libelle;
	        	textBoxDescription.Text = produit.categorie;
	        
	        	textBoxPrix.Text = produit.prix.ToString();
	        	textBox1.Text = produit.quantite.ToString();
	        	
        	}
        }
		public PreviewProduit(MySqlConnection connection)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.connection = connection;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void UpdateProduit(string id)
		{
		   try
		    {
		        string query = "UPDATE produits SET libelle = @libelle, categorie = @categorie, prix = @prix, quantite  = @quantite  WHERE id = @id";
		        MySqlCommand cmd = new MySqlCommand(query, connection);
		        cmd.Parameters.AddWithValue("@id", textBoxId.Text);
		        cmd.Parameters.AddWithValue("@libelle", textBoxLibelle.Text);
		        cmd.Parameters.AddWithValue("@categorie", textBoxDescription.Text);
		     
		        // Assurez-vous que la conversion est correcte
		       cmd.Parameters.AddWithValue("@prix", Convert.ToDecimal(textBoxPrix.Text));
		       cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(textBox1.Text));
		
		        connection.Open();
		        cmd.ExecuteNonQuery();
		        MessageBox.Show("Produit mis à jour avec succès !");
		        connection.Close();
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
		        connection.Close();
		    }
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
	var produits = new Produits();
			produits.Show();
			this.Close();
		}
		void ConfirmButtonClick(object sender, EventArgs e)
		{
			string id = textBoxId.Text;
			UpdateProduit(id);
			
			var produits = new Produits();
			produits.Show();
			this.Close();
	
		}
		void ComboBoxCategorieSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
	}
}
