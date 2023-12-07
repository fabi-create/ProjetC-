/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System; 
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;



namespace ProjetRestauration
{
	/// <summary>
	/// Description of ListeCommandes.
	/// </summary>
	public partial class ListeCommandes : Form
	{
		
        private listeCommande listeCommandeSelectionne = null;
        private List<listeCommande> listelisteCommande = new List<listeCommande>();
		
		private MySqlConnection connection;
        private MySqlCommand command;
		
		
		
		public ListeCommandes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		

			InitializeDatabaseConnection();
			fillComboBox3();
			fillComboBox1();
			fillComboBox4();
			 
			// 
			// TODO: Add constructor code after the Ini tializeComponent() call.
			//  
			 
			listelisteCommande = LoadlisteCommandesData();
		 
			 
			tableauValidation.DataSource = listelisteCommande;
			 
			tableauValidation.SelectionChanged += tableauValidation_SelectionChanged;
			searchBox.TextChanged += RechercheTextBoxTextChanged;
		}
		
			private void InitializeDatabaseConnection()
        {
            // Remplacez "votre_chaine_de_connexion" par la chaîne de connexion appropriée à votre base de données MySQL.
            string connectionString = "Server=localhost;Database=projetC#;Uid=root; port=3308;Pwd=";
            connection = new MySqlConnection(connectionString);
        }
		
  
		
		
		private List<listeCommande> LoadlisteCommandesData()
        {
            try
		    { 
		        string query = "SELECT * FROM listecommande";
		        command = new MySqlCommand(query, connection);
		        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
		        DataTable dataTable = new DataTable();
		        adapter.Fill(dataTable);

		        
		        foreach (DataRow row in dataTable.Rows)
        {
            listeCommande listecommande = new listeCommande
            {
                    id = Convert.ToInt32(row["id"]),   
                idCommande = Convert.ToInt32(row["idCommande"]),
                etatCommande = Convert.ToInt32(row["etatCommande"]),
                idProduit = Convert.ToInt32(row["idProduit"]),
                idRestaurateur = Convert.ToInt32(row["idRestaurateur"]),
                quantite = Convert.ToInt32(row["quantite"]),
                prixUnitaire = Convert.ToInt32(row["prixUnitaire"])
            };

            listelisteCommande.Add(listecommande); // Ajoutez à la liste ici
        }
		        
		    }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            return listelisteCommande ;
        }
		
		
		
		private void RechercheTextBoxTextChanged(object sender, EventArgs e)
			{
			    string rechercheText = searchBox.Text.Trim().ToLower(); // Convertissez le texte en minuscules pour la comparaison
			    List<listeCommande> listecommandesFiltres = new List<listeCommande>();
			
			    foreach (listeCommande listecommande in listelisteCommande)
			    {
			    	if (listecommande.idRestaurateur.ToString().ToLower().Contains(rechercheText)  || listecommande.idCommande.ToString().ToLower().Contains(rechercheText) || listecommande.idProduit.ToString().ToLower().Contains(rechercheText) )
			        {
			           listecommandesFiltres.Add(listecommande);
			        }
			    }
			
			    tableauValidation.DataSource = listecommandesFiltres;
			}
		
	
		
		
		void tableauValidation_SelectionChanged(object sender, EventArgs e)
			{
			    if(tableauValidation.SelectedRows.Count > 0)
			    {
			        listeCommandeSelectionne = tableauValidation.SelectedRows[0].DataBoundItem as listeCommande;
			    }
			
//			if (tableauValidation.SelectedRows.Count > 0)
//    {
//        listeCommandeSelectionne = tableauValidation.SelectedRows[0].DataBoundItem as listeCommande;
//    }
//    else
//    {
//        listeCommandeSelectionne = null; // Réinitialiser la sélection si rien n'est sélectionné
//    }
			}
		


private void fillComboBox3()
{
    try
    {
        connection.Open();
        string query = "SELECT id, libelle FROM produits"; // Sélectionnez id et nomProduit
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            int idProduit = myreader.GetInt32(0);
            string nomProduit = myreader.GetString(1);
            comboBox3.Items.Add(new ComboBoxItem(idProduit, nomProduit)); // Ajoutez un objet ComboBoxItem contenant l'ID et le nom du produit
        }
        myreader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }

    // Ajoutez un gestionnaire d'événement pour la sélection d'un élément dans la ComboBox
    comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
}

private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
{
    // Assurez-vous que l'index sélectionné est valide
    if (comboBox3.SelectedIndex >= 0)
    {  
        ComboBoxItem selectedItem = comboBox3.SelectedItem as ComboBoxItem;
        int idProduit = selectedItem.ID; // Récupérez l'ID du produit sélectionné
 
        try 
        { 
             connection.Open();
             string query = "SELECT prix FROM produits WHERE id = @idProduit"; // Récupérer le prix du produit
             MySqlCommand command = new MySqlCommand(query, connection);
             command.Parameters.AddWithValue("@idProduit", idProduit);
            
             object result = command.ExecuteScalar();
             if (result != null && result != DBNull.Value)
             {
                 decimal prixProduit = Convert.ToDecimal(result);
                 textBoxPrixProduit.Text = prixProduit.ToString();  // Afficher le prix dans le TextBox
             }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors de la récupération du prix : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}






 
   void fillComboBox4()
{
    try
    {
        connection.Open();
        string query = "SELECT * FROM utilisateurs where type_utilisateur='Restaurateur'";
       MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string sname = myreader.GetString(0);
            comboBox4.Items.Add(sname);
        }
        myreader.Close(); // N'oubliez pas de fermer le lecteur de données après utilisation
    }
    catch (Exception ex) // Utilisez "ex" au lieu de "Exception" pour attraper l'exception
    {
        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
    }
    finally
    {
        connection.Close(); // Assurez-vous de fermer la connexion même en cas d'exception
    }
}

   



void fillComboBox1()
{
    try
    {
        connection.Open();
        string query = "SELECT * FROM commandes";
       MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader myreader;
        myreader = command.ExecuteReader();
        while (myreader.Read())
        {
            string sname = myreader.GetString(0);
            comboBox1.Items.Add(sname);
        }
        myreader.Close(); // N'oubliez pas de fermer le lecteur de données après utilisation
    }
    catch (Exception ex) // Utilisez "ex" au lieu de "Exception" pour attraper l'exception
    {
        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
    }
    finally
    {
        connection.Close(); // Assurez-vous de fermer la connexion même en cas d'exception
    }
}


bool ProduitExisteDeja(int idCommande, int idProduit)
{
    try
    {
        connection.Open();
        string queryCheckExists = "SELECT COUNT(*) FROM listeCommande WHERE idCommande = @idCommande AND idProduit = @idProduit";
        MySqlCommand commandCheckExists = new MySqlCommand(queryCheckExists, connection);
        commandCheckExists.Parameters.AddWithValue("@idCommande", idCommande);
        commandCheckExists.Parameters.AddWithValue("@idProduit", idProduit);

        int existingCount = Convert.ToInt32(commandCheckExists.ExecuteScalar());
        return existingCount > 0;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors de la vérification de l'existence du produit : " + ex.Message);
        return false; // En cas d'erreur, considérez que le produit n'existe pas pour éviter les erreurs supplémentaires
    }
    finally
    {
        connection.Close();
    }
}





void Button1Click(object sender, EventArgs e)
{
	

	
		string id = textBox2.Text;
    int idCommande = int.Parse(comboBox1.Text);
    int idProduit = int.Parse(comboBox3.Text);
    int etatCommande = int.Parse(comboBox2.Text);
    int idRestaurateur  = int.Parse(comboBox4.Text);
    int quantite = int.Parse(textBox1.Text);
    decimal prixUnitaire = decimal.Parse(textBoxPrixProduit.Text);

    // Vérifier si le produit avec le même ID de commande existe déjà
    if (ProduitExisteDeja(idCommande, idProduit))
    {
        MessageBox.Show("Ce produit avec le même ID de commande existe déjà ! Veuillez saisir un autre ID de produit.");
        return; // Sortir de la fonction pour éviter l'ajout en double
    }

    // Vérifier si la quantité saisie est inférieure à la quantité disponible dans la table produits
    if (!QuantiteDisponible(idProduit, quantite))
    {
        MessageBox.Show("Quantité en manque dans la table produits !");
        return; // Sortir de la fonction pour éviter l'ajout avec une quantité insuffisante
    }

    try
    {
        connection.Open();

    // Insertion de la nouvelle commande dans la table listeCommande
    string queryInsert = "INSERT INTO listeCommande (id,idCommande, etatCommande, idProduit,idRestaurateur,quantite,prixUnitaire) " +
                       "VALUES (@id,@idCommande,@etatCommande, @idProduit,@idRestaurateur, @quantite, @prixUnitaire)";
    command = new MySqlCommand(queryInsert, connection);

     command.Parameters.AddWithValue("@id", id);
    command.Parameters.AddWithValue("@idCommande", idCommande);
    command.Parameters.AddWithValue("@etatCommande", etatCommande);
    command.Parameters.AddWithValue("@idProduit", idProduit);
    command.Parameters.AddWithValue("@idRestaurateur", idRestaurateur);
    command.Parameters.AddWithValue("@quantite", quantite);
    command.Parameters.AddWithValue("@prixUnitaire", prixUnitaire);

    command.ExecuteNonQuery();
    MessageBox.Show("ListeCommande enregistrée avec succès !");

    // Mise à jour de la quantité dans la table produits
    string queryUpdateQuantite = "UPDATE produits SET quantite = quantite - @quantite WHERE id = @idProduit";
    command = new MySqlCommand(queryUpdateQuantite, connection);

    command.Parameters.AddWithValue("@quantite", quantite);
    command.Parameters.AddWithValue("@idProduit", idProduit);

    command.ExecuteNonQuery();
    MessageBox.Show("Quantité mise à jour dans la table produits !");

    // Effacer les champs après l'enregistrement
    textBox1.Text = "";
    textBox2.Text = "";
    comboBox1.Text = "";
    comboBox2.Text = "";
    comboBox3.Text = "";
    comboBox4.Text = "";
    textBoxPrixProduit.Text ="";
    
    // Ajouter la nouvelle commande à la liste
        listeCommande nouvelleCommande = new listeCommande
        {
        	
        	id = Convert.ToInt32(id),
            idCommande = idCommande,
            etatCommande =etatCommande,
            idProduit = idProduit,
            idRestaurateur = idRestaurateur,
            quantite = quantite,
            prixUnitaire =prixUnitaire
        };
        listelisteCommande.Add(nouvelleCommande);

        // Mise à jour de la source de données du tableau
        tableauValidation.DataSource = null; // Réinitialise la source de données
        tableauValidation.DataSource = listelisteCommande; // Met à jour la source de données
        
        
        // Appel de la méthode Refresh pour rafraîchir l'affichage du DataGridView
tableauValidation.Refresh();

        // Rendre le panneau visible
        panel1.Visible = true;
        
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

bool QuantiteDisponible(int idProduit, int quantite)
{
    try
    {
        connection.Open();
        string queryCheckQuantite = "SELECT quantite FROM produits WHERE id = @idProduit";
        MySqlCommand commandCheckQuantite = new MySqlCommand(queryCheckQuantite, connection);
        commandCheckQuantite.Parameters.AddWithValue("@idProduit", idProduit);

        int quantiteDisponible = Convert.ToInt32(commandCheckQuantite.ExecuteScalar());
        return quantite <= quantiteDisponible;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors de la vérification de la quantité : " + ex.Message);
        return false; // En cas d'erreur, considérez que la quantité n'est pas disponible pour éviter les erreurs supplémentaires
    }
    finally
    {
        connection.Close();
    }
}

public void ShowPanel()
{
    panel1.Visible = true;
}


		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void ListeCommandesLoad(object sender, EventArgs e)
		{
	
		}
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void ComboBox4SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
			
	
		}
		void Button2Click(object sender, EventArgs e)
		{
				var form = new FormCommande();
			 form.Show();
			this.Hide();
		  
		}
		void TableauValidationCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
{
    // Assurez-vous d'abord que la sélection est valide
    if (tableauValidation.SelectedRows.Count > 0)
    {
        listeCommande listeCommandeSelectionne = tableauValidation.SelectedRows[0].DataBoundItem as listeCommande;

        // Mettre à jour la valeur de etatCommande dans la base de données
        try
        {
            connection.Open();
            string updateQuery = "UPDATE listecommande SET etatCommande = 1 WHERE id = @idCommande";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@idCommande", listeCommandeSelectionne.id);
            updateCommand.ExecuteNonQuery();

            // Mettre à jour la valeur de etatCommande dans la liste
            listeCommandeSelectionne.etatCommande = 1;
              // Actualiser la source de données du DataGridView pour refléter les modifications
            tableauValidation.DataSource = null; // Supprime la source de données actuelle
            tableauValidation.DataSource = listelisteCommande; // Attribue la nouvelle liste de données
            tableauValidation.Refresh(); // Rafraîchit l'affichage du DataGridView


            MessageBox.Show("La commande a été validée avec succès !", "Validation de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors de la mise à jour de l'état de la commande : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
    else
    {
        MessageBox.Show("Veuillez sélectionner une commande dans la liste.");
    }
}

		
		
		void Button4Click(object sender, EventArgs e)
		{
	
			
				// Assurez-vous d'abord que la sélection est valide
    if (tableauValidation.SelectedRows.Count > 0)
    {
        listeCommande listeCommandeSelectionne = tableauValidation.SelectedRows[0].DataBoundItem as listeCommande;

        // Mettre à jour la valeur de etatCommande dans la base de données
        try
        {
            connection.Open();
            string updateQuery = "UPDATE listecommande SET etatCommande = 0 WHERE id = @idCommande";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@idCommande", listeCommandeSelectionne.id);
            updateCommand.ExecuteNonQuery();
            
            
            
            // Mettre à jour la valeur de etatCommande dans la liste
            listeCommandeSelectionne.etatCommande = 0;
              // Actualiser la source de données du DataGridView pour refléter les modifications
            tableauValidation.DataSource = null; // Supprime la source de données actuelle
            tableauValidation.DataSource = listelisteCommande; // Attribue la nouvelle liste de données
            tableauValidation.Refresh(); // Rafraîchit l'affichage du DataGridView
             MessageBox.Show("l'annulation de la validation a été fait avec succes !", "Validation de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors de la mise à jour de l'état de la commande : " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
    else
    {
        MessageBox.Show("Veuillez sélectionner une commande dans la liste.");
    }
			
			
		}
		void Button5Click(object sender, EventArgs e)
		{
			
			if (listeCommandeSelectionne != null)
    {
        if (listeCommandeSelectionne.etatCommande == 0) // Assurez-vous d'utiliser la bonne propriété pour l'état de la commande
        {
            MessageBox.Show("Veuillez d'abord valider la commande avant de passer au paiement.");
        }
        else
        {
            var formulaire = new Paiements(connection);
            formulaire.listecommande = listeCommandeSelectionne;
            formulaire.populate();
            formulaire.Show();
            this.Hide();
        }
    }
    else
    {
        MessageBox.Show("Veuillez sélectionner une commande avec produit avant de mettre à jour.");
    }
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{

		}
		void Button6Click(object sender, EventArgs e)
		{
 panel1.Visible = true;
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void TextBoxPrixProduitTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
