/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 20/08/2023
 * Time: 20:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace ProjetRestauration
{
	/// <summary>
	/// Description of ImageProduit.
	/// </summary>
	public partial class ImageProduit : Form
	{
	private MySqlConnection connection;

		public ImageProduit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
//			server = "localhost";
//			database ="projetC#";
//			uid ="root";
//			password = "";
//			string connectionString;
//			
//			connectionString = 
			
			
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
		
		
		private void affichage()
		{
			
			try
            {
                connection.Open();
                
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT *FROM images",connection);
               
 
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                
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
		
		
		void ImageProduitLoad(object sender, EventArgs e)
		{
			affichage();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	OpenFileDialog Ouvrir = new OpenFileDialog();
Ouvrir.Filter = "image Only. |*.jpg; *.jpeg; *.png; *.gif;";
DialogResult dr = Ouvrir.ShowDialog();
pictureBox1.Image = Image.FromFile(Ouvrir.FileName);

string chemin = Ouvrir.FileName;
textBox2.Text = new System.IO.FileInfo(chemin).Name;
textBox3.Text = new System.IO.FileInfo(chemin).Extension;
long tailleOctets = new System.IO.FileInfo(chemin).Length;
int tailleKiloOctets = (int)(tailleOctets / 1024);
textBox1.Text = tailleKiloOctets.ToString();

		}
		
		
		void Button1Click(object sender, EventArgs e)
{
    MemoryStream ms = new MemoryStream();
    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
    byte[] img = ms.ToArray();

    try
    {
        // Ouvrir la connexion à la base de données
        connection.Open();

        string query = "INSERT INTO images(imageNom, imageType, imageTaille, imageBlob) VALUES (@nom, @type, @taille, @img)";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", textBox2.Text);
        cmd.Parameters.AddWithValue("@type", textBox3.Text);
        cmd.Parameters.AddWithValue("@taille", Convert.ToInt32(textBox1.Text));
        cmd.Parameters.AddWithValue("@img", img);

        if (cmd.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Insertion effectuée !");
        }

        // Fermer la connexion à la base de données
        connection.Close();

        // Appeler la fonction d'affichage
        affichage();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
        MessageBox.Show(ex.ToString()); // Affiche les détails de l'exception

    }
    finally
    {
        // S'assurer de toujours fermer la connexion en fin d'exécution
        if (connection.State == ConnectionState.Open)
            connection.Close();
    }
}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void LableClick(object sender, EventArgs e)
		{
	
		}

	}
}
