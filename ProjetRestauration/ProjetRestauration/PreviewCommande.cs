/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/08/2023
 * Time: 22:11
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
	/// Description of PreviewCommande.
	/// </summary>
	public partial class PreviewCommande : Form
	{
		
		private MySqlConnection connection;
		
		public Commande commande {set;get;}
        
         public void populate()
        {
        	if(commande != null){
         		textBox4.Text = commande.id.ToString();
	        	textBox1.Text = commande.libelleCommande;
	        	textBox2.Text = commande.nomPrenomClient;
	        	textBox3.Text = commande.telephoneClient.ToString();
	        	comboBox1.Text = commande.etatCommande.ToString();
	        
        	}
		
         }
		public PreviewCommande(MySqlConnection connection)
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
		
		void UpdateCommande(string id)
		{
		    try
		    {
		        string query = "UPDATE commandes SET libelleCommande = @libelleCommande, nomPrenomClient = @nomPrenomClient, telephoneClient = @telephoneClient, etatCommande = @etatCommande WHERE id = @id";
		        MySqlCommand cmd = new MySqlCommand(query, connection);
		      cmd.Parameters.AddWithValue("@id", textBox4.Text);
		        cmd.Parameters.AddWithValue("@libelleCommande", textBox1.Text);
		        cmd.Parameters.AddWithValue("@nomPrenomClient", textBox2.Text);
		        cmd.Parameters.AddWithValue("@telephoneClient", textBox3.Text);
		        cmd.Parameters.AddWithValue("@etatCommande",comboBox1.Text); // Assurez-vous que la conversion est correcte
		  
		
		        connection.Open();
		        cmd.ExecuteNonQuery();
		        MessageBox.Show("Commande mise à jour avec succès !");
		        connection.Close();
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
		        connection.Close();
		    }
		}
		void Button1Click(object sender, EventArgs e)
		{
	 string id = textBox4.Text;
			UpdateCommande(id);
			
			var Form = new FormCommande();
    Form.ShowPanel(); // Rendre le panneau visible
    Form.Show();
    this.Hide();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			
			var formulaire = new FormCommande();
			formulaire.Show();
			this.Hide();
		}
	}
}
