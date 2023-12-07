/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/08/2023
 * Time: 16:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Paiements.
	/// </summary>
	public partial class Paiements : Form
	{
		
		
		private MySqlConnection connection;
	
        private MySqlCommand command;
    
		
		public listeCommande listecommande {set;get;}
        
        public void populate()
        {
        	if(listecommande != null){
        		textBox1.Text =listecommande.idCommande.ToString();
	        	textBox2.Text = listecommande.idProduit.ToString();
	        	textBox3.Text = listecommande.etatCommande.ToString();
	        	textBox4.Text = listecommande.idRestaurateur.ToString();
	        	textBox5.Text = listecommande.quantite.ToString();
	        	textBox6.Text = listecommande.prixUnitaire.ToString();
	        	
	        	decimal total = listecommande.quantite * listecommande.prixUnitaire;
        textBox7.Text = total.ToString();
	        	
        	}
        }
		
   
        
        
		
		
		public Paiements(MySqlConnection connection)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			this.connection = connection;
			fillComboBox1();
			fillComboBox2();
			fillComboBox3();
			fillComboBox4();
			fillComboBox5();
			
			
			
			
			for (int day = 1; day <= 31; day++)
				{
				    comboBoxJour.Items.Add(day.ToString("00"));
				}
				
				for (int month = 1; month <= 12; month++)
				{
				    comboBoxMois.Items.Add(month.ToString("00"));
				}
				
				
				for (int year = 2000; year <= 2023; year++)
				{
				    comboBoxAnnee.Items.Add(year.ToString()); 
				}




			
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
		

private string connectionString = "Database=projetC#;Data source=localhost;port=3308;User Id=root;password=;Integrated security=true;Allow Zero Datetime=True;default command timeout=120";


void Button1Click(object sender, EventArgs e)
{
    int idCommande = int.Parse(textBox1.Text);
    int idProduit = int.Parse(textBox2.Text);
    int etatCommande = int.Parse(textBox3.Text);
    int idRestaurateur = int.Parse(textBox4.Text);
    Decimal prixUnitaire = decimal.Parse(textBox6.Text);
    int quantite = int.Parse(textBox5.Text);
    Decimal total = decimal.Parse(textBox7.Text);
    Decimal montantVerse = decimal.Parse(textBox8.Text);
    Decimal montantRemis = decimal.Parse(textBox9.Text);

    // Nouveau code pour la date de paiement
    DateTime datePaiement = new DateTime(
        int.Parse(comboBoxAnnee.Text),
        int.Parse(comboBoxMois.Text),
        int.Parse(comboBoxJour.Text)
    );

    try
    {
        using (connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // Vérification de l'état de la commande

            // Vérification si la commande existe déjà dans la table paiements
            string checkQuery = "SELECT COUNT(*) FROM paiements WHERE idCommande = @idCommande AND idProduit = @idProduit";
            using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@idCommande", idCommande);
                checkCommand.Parameters.AddWithValue("@idProduit", idProduit);

                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingCount > 0)
                {
                    MessageBox.Show("Attention : Vous êtes en train de payer la même commande deux fois avec le meme produit.");
                }
                else
                {
                    string query = "INSERT INTO paiements (idCommande, etatCommande, idProduit, idRestaurateur, prixUnitaire, quantite, total, montantVerse, montantRemis, date_paiement) " +
                                   "VALUES (@idCommande, @etatCommande, @idProduit, @idRestaurateur, @prixUnitaire, @quantite, @total, @montantVerse, @montantRemis, @datePaiement)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCommande", idCommande);
                        command.Parameters.AddWithValue("@etatCommande", etatCommande);
                        command.Parameters.AddWithValue("@idProduit", idProduit);
                        command.Parameters.AddWithValue("@idRestaurateur", idRestaurateur);
                        command.Parameters.AddWithValue("@prixUnitaire", prixUnitaire);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@total", total);
                        command.Parameters.AddWithValue("@montantVerse", montantVerse);
                        command.Parameters.AddWithValue("@montantRemis", montantRemis);
                        command.Parameters.AddWithValue("@datePaiement", datePaiement);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Paiement enregistré avec succès !");
                      

                        // Effacer les champs après l'enregistrement
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";

                        // Rafraîchir les comboBox
                        RefreshComboBox1();
                        RefreshComboBox2();
                        RefreshComboBox3();
                        RefreshComboBox4();
                        RefreshComboBox5();
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
    }
    
    finally
{

    	
    
          connection.Close(); // Assurez-vous que la connexion est fermée en cas d'exception
    
}


}








		void TextBox8TextChanged(object sender, EventArgs e)
		{
	
       // Gestion des exceptions pour la conversion des valeurs
    try
    {
        decimal montantVerse = decimal.Parse(textBox8.Text);
        decimal total = decimal.Parse(textBox7.Text);

        // Calcul du montant restant
        decimal montantRestant = montantVerse - total;

        // Affichage du montant restant dans textBox9
        textBox9.Text = montantRestant.ToString();
    }
    catch (FormatException)
    {
        // Réinitialisation si les valeurs ne sont pas valides
        textBox9.Text = "";
    }
   
		}
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{

			var listeCommandesForm = new ListeCommandes();
    listeCommandesForm.ShowPanel(); // Rendre le panneau visible
    listeCommandesForm.Show();
    this.Hide();

		
		}
		
		
	HashSet<string> commandesAjoutees = new HashSet<string>(); // Créer un HashSet pour stocker les commandes ajoutées

void fillComboBox1()
{
    try
    {
        connection.Open();
        string query = "SELECT * FROM paiements";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string sname = myreader.GetString(1);
            
            if (!commandesAjoutees.Contains(sname)) // Vérifier si la commande n'a pas déjà été ajoutée
            {
                comboBox1.Items.Add(sname);
                commandesAjoutees.Add(sname); // Ajouter la commande au HashSet
            }
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

		 
		 
		 
//		 void fillComboBox2()
//{
//    try
//    {
//        connection.Open();
//        string query = "SELECT * FROM paiements";
//       MySqlCommand command = new MySqlCommand(query, connection);
//        MySqlDataReader myreader;
//        myreader = command.ExecuteReader();
//        while (myreader.Read())
//        {
//            string sname = myreader.GetString(2);
//            comboBox2.Items.Add(sname);
//        }
//        myreader.Close(); // N'oubliez pas de fermer le lecteur de données après utilisation
//    }
//    catch (Exception ex) // Utilisez "ex" au lieu de "Exception" pour attraper l'exception
//    {
//        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
//    }
//    finally
//    {
//        connection.Close(); // Assurez-vous de fermer la connexion même en cas d'exception
//    }
//}

void fillComboBox2()
{
    HashSet<string> itemsAdded = new HashSet<string>(); // Créer un HashSet pour garder une trace des éléments ajoutés

    try
    {
        connection.Open();
        string query = "SELECT * FROM paiements";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string sname = myreader.GetString(3);

            if (!itemsAdded.Contains(sname)) // Vérifier si l'élément n'a pas déjà été ajouté
            {
                comboBox2.Items.Add(sname);
                itemsAdded.Add(sname); // Ajouter l'élément au HashSet
            }
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}



void fillComboBox3()
{
    HashSet<string> itemsAdded = new HashSet<string>(); // Créer un HashSet pour garder une trace des éléments ajoutés

    try
    {
        connection.Open();
        string query = "SELECT * FROM paiements";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            DateTime datePaiement = myreader.GetDateTime("date_paiement");
            string formattedDate = datePaiement.ToString("dd-MM-yyyy"); // Formater la date au format "jour-mois-année"

            if (!itemsAdded.Contains(formattedDate)) // Vérifier si l'élément n'a pas déjà été ajouté
            {
                comboBox3.Items.Add(formattedDate);
                itemsAdded.Add(formattedDate); // Ajouter l'élément au HashSet
            }
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


	void fillComboBox4()
{
    HashSet<string> itemsAdded = new HashSet<string>(); // Créer un HashSet pour garder une trace des éléments ajoutés

    try
    {
        connection.Open();
        string query = "SELECT DISTINCT DATE_FORMAT(date_paiement, '%m-%Y') AS MonthYear FROM paiements";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string monthYear = myreader.GetString("MonthYear");

            if (!itemsAdded.Contains(monthYear)) // Vérifier si l'élément n'a pas déjà été ajouté
            {
                comboBox4.Items.Add(monthYear);
                itemsAdded.Add(monthYear); // Ajouter l'élément au HashSet
            }
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void fillComboBox5()
{
    HashSet<string> itemsAdded = new HashSet<string>(); // Créer un HashSet pour garder une trace des éléments ajoutés

    try
    {
        connection.Open();
        string query = "SELECT DISTINCT DATE_FORMAT(date_paiement, '%m-%Y') AS MonthYear FROM paiements";
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string monthYear = myreader.GetString("MonthYear");
            string yearOnly = monthYear.Substring(3); // Extraire les 4 derniers caractères (l'année)

            if (!itemsAdded.Contains(yearOnly)) // Vérifier si l'année n'a pas déjà été ajoutée
            {
                comboBox5.Items.Add(yearOnly);
                itemsAdded.Add(yearOnly); // Ajouter l'année au HashSet
            }
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}





void RefreshComboBox2()
{
    comboBox2.Items.Clear(); // Efface les éléments actuels de la ComboBox2
    fillComboBox2(); // Remplit à nouveau la ComboBox2 avec les éléments mis à jour
}

// Fonction de rafraîchissement de la ComboBox3
void RefreshComboBox3()
{
    comboBox3.Items.Clear(); // Efface les éléments actuels de la ComboBox3
    fillComboBox3(); // Remplit à nouveau la ComboBox3 avec les éléments mis à jour
}


void RefreshComboBox4()
{
    comboBox4.Items.Clear(); // Efface les éléments actuels de la ComboBox2
    fillComboBox2(); // Remplit à nouveau la ComboBox2 avec les éléments mis à jour
}

// Fonction de rafraîchissement de la ComboBox3
void RefreshComboBox5()
{
    comboBox5.Items.Clear(); // Efface les éléments actuels de la ComboBox3
    fillComboBox3(); // Remplit à nouveau la ComboBox3 avec les éléments mis à jour
}
	
	
	
	// Fonction de rafraîchissement de la ComboBox3
void RefreshComboBox1()
{
    comboBox1.Items.Clear(); // Efface les éléments actuels de la ComboBox3
    fillComboBox3(); // Remplit à nouveau la ComboBox3 avec les éléments mis à jour
}
	
	
		
		void ComboBox4SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox10TextChanged(object sender, EventArgs e)
		{
			 
   
	
		}
		void Label11Click(object sender, EventArgs e)
		{
	
		}
		void Label15Click(object sender, EventArgs e)
		{
	
		}
		void ButtonCalculateClick(object sender, EventArgs e)
		{
	 string selectedId = comboBox1.SelectedItem as string;

    if (selectedId != null)
    {
        try
        {
            connection.Open();

            string query = "SELECT SUM(total) FROM paiements WHERE idCommande = @idCommande";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idCommande", selectedId);

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal totalSum = Convert.ToDecimal(result);
                textBox10.Text = totalSum.ToString();
            }
            else
            {
                textBox10.Text = "0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du calcul de la somme : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
		}
		void Button3Click(object sender, EventArgs e)
		{
	string selectedIdProduit = comboBox2.SelectedItem as string;

    if (selectedIdProduit != null)
    {
        try
        {
            connection.Open();

            string query = "SELECT SUM(total) FROM paiements WHERE idProduit = @idProduit";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idProduit", selectedIdProduit);

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal totalSum = Convert.ToDecimal(result);
                textBox11.Text = totalSum.ToString();
            }
            else
            {
                textBox11.Text = "0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du calcul de la somme : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
		}
		void PaiementsLoad(object sender, EventArgs e)
		{
	
		}
		void Button4Click(object sender, EventArgs e)
		{
	
			 string selectedDate = comboBox3.SelectedItem as string;

    if (!string.IsNullOrEmpty(selectedDate))
    {
        try
        {
            connection.Open();

            string query = "SELECT SUM(total) FROM paiements WHERE DATE_FORMAT(date_paiement, '%d-%m-%Y') = @selectedDate";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@selectedDate", selectedDate);

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal totalSum = Convert.ToDecimal(result);
                textBox12.Text = totalSum.ToString();
            }
            else
            {
                textBox12.Text = "0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du calcul de la somme : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
			
			
			
			
		}
		void TextBox12TextChanged(object sender, EventArgs e)
		{
	
		}
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button7Click(object sender, EventArgs e)
		{
	panel1.Visible = true;
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			 string selectedMonthYear = comboBox4.SelectedItem as string;

    if (selectedMonthYear != null)
    {
        try
        {
            connection.Open();

            // Convertir la chaîne "MM-YYYY" en une date au début du mois et de l'année sélectionnés
            DateTime selectedDate = DateTime.ParseExact(selectedMonthYear, "MM-yyyy", null);
            DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1);

            string query = "SELECT SUM(total) FROM paiements WHERE date_paiement >= @startDate AND date_paiement < @endDate";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal totalSum = Convert.ToDecimal(result);
                textBox13.Text = totalSum.ToString();
            }
            else
            {
                textBox13.Text = "0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du calcul de la somme : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
			
		}
		void ComboBox5SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button6Click(object sender, EventArgs e)
		{
	 string selectedYear = comboBox5.SelectedItem as string;

    if (selectedYear != null)
    {
        try
        {
            connection.Open();

            string query = "SELECT SUM(total) FROM paiements WHERE DATE_FORMAT(date_paiement, '%Y') = @selectedYear";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@selectedYear", selectedYear);

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal totalSum = Convert.ToDecimal(result);
                textBox14.Text = totalSum.ToString();
            }
            else
            {
                textBox14.Text = "0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du calcul de la somme : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void Button8Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		


		
	}
}
