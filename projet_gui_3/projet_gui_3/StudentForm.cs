/*
 * Created by SharpDevelop.
 * User: Kodjo
 * Date: 09/08/2023
 * Time: 19:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient ;

namespace projet_gui_3
{
	/// <summary>
	/// Description of StudentForm.
	/// </summary>
	
	public partial class StudentForm : Form
	{
		private const string connectionString = "Server=localhost;Database=dbstudents;Uid=root;Pwd=root;";
		public StudentForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ClearFormFields();
			textBoxMatricule.Enabled = false ;
			//
			buttonUpdate.Enabled = false ;
			buttonUpdate.Hide();
			buttonValider.Enabled = true ;
			buttonValider.Show();
			
			//
			 
			// Activer la sélection de ligne complète
    		dataTableEtu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			loadStudents();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void addListener(){
			// Ajouter un événement de sélection de ligne
    		//dataTableEtu.SelectionChanged += DataGridView_SelectionChanged;
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void StudentFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			 if (dataTableEtu.SelectedRows.Count > 0)
		    {
		        int selectedRowIndex = dataTableEtu.SelectedRows[0].Index;
		        int matriculeToDelete = Convert.ToInt32(dataTableEtu.Rows[selectedRowIndex].Cells["Matricule"].Value);
		
		        using (MySqlConnection connection = new MySqlConnection(connectionString))
		        {
		            connection.Open();
		
		            string deleteQuery = "DELETE FROM t_students WHERE matricule = @Matricule";
		            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
		            deleteCommand.Parameters.AddWithValue("@Matricule", matriculeToDelete);
		
		            int rowsAffected = deleteCommand.ExecuteNonQuery();
		            if (rowsAffected > 0)
		            {
		                MessageBox.Show("Étudiant supprimé avec succès.");
		                loadStudents();
		                ClearFormFields();
		            }
		            else
		            {
		                MessageBox.Show("La suppression a échoué.");
		            }
		         }
		    }
		    else
		    {
		        MessageBox.Show("Sélectionnez un étudiant à supprimer.");
		    }
		}
		void Button4Click(object sender, EventArgs e)
		{
		    if (dataTableEtu.SelectedRows.Count > 0)
		    {
		        int selectedRowIndex = dataTableEtu.SelectedRows[0].Index;
		        int matriculeToEdit = Convert.ToInt32(dataTableEtu.Rows[selectedRowIndex].Cells["Matricule"].Value);
				//
				buttonUpdate.Enabled = true ;
				buttonUpdate.Show();
				buttonValider.Enabled = false ;
				buttonValider.Hide();
		        //
		        using (MySqlConnection connection = new MySqlConnection(connectionString))
		        {
		            connection.Open();
		
		            string selectQuery = "SELECT * FROM t_students WHERE matricule = @Matricule";
		            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
		            selectCommand.Parameters.AddWithValue("@Matricule", matriculeToEdit);
		
		            using (MySqlDataReader reader = selectCommand.ExecuteReader())
		            {
		                SetStudentFormDataFromDataReader(reader);
		            }
		        }
		    }
		    else
		    {
		        MessageBox.Show("Sélectionnez un étudiant à modifier.");
		    }
		}

		
		void Label9Click(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			ClearFormFields();
		}
		void Label10Click(object sender, EventArgs e)
		{
		}
		void ComboBoxClasseSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (ValidateFields())
            	{
				
				int  matricule = int.Parse(textBoxMatricule.Text);
//				int matricule = 0 ;
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                int age = int.Parse(textBoxAge.Text );
                string classe = comboBoxClasse.Text;
                float moyenne = float.Parse(textBoxMoyenne.Text);
                string nationalite = comboBoxNationalite.Text;
                
                
                // Save data into the database
                string query = "INSERT INTO t_students (matricule, nom, prenom, age,  classe, moyenne, nationalite) " +
               "VALUES ('"+ matricule +"', '" + nom + "','" + prenom + "','"+ age+"', '" + classe + "',  '" + moyenne + "','" + nationalite + "')";
                
                try
				{
				  MySqlConnection conn;
				  conn = new MySql.Data.MySqlClient.MySqlConnection();
				  conn.ConnectionString = connectionString;
				  conn.Open();
				  MySqlCommand MyCommand2 = new MySqlCommand(query, conn);
				  MySqlDataReader MyReader2;
				  MyReader2 = MyCommand2.ExecuteReader(); 
				  MessageBox.Show("Etudiant ajouter avec success");
				  conn.Close();
				  loadStudents();
				  ClearFormFields();
				}
				catch (MySql.Data.MySqlClient.MySqlException ex)
				{
				    MessageBox.Show(ex.Message);
				}
			}

		}
		private void SetStudentFormDataFromDataReader(MySqlDataReader reader)
		{
		    if (reader.Read())
		    {
		        textBoxMatricule.Text = reader["matricule"].ToString();
		        textBoxNom.Text = reader["nom"].ToString();
		        textBoxPrenom.Text = reader["prenom"].ToString();
		        textBoxAge.Text = reader["age"].ToString();
		        comboBoxClasse.SelectedItem = reader["classe"].ToString();
		        textBoxMoyenne.Text = reader["moyenne"].ToString();
		        comboBoxNationalite.SelectedItem = reader["nationalite"].ToString();
		    }
		}
		private void ClearFormFields()
		{
			    
			    textBoxMatricule.Text = "0";
			    textBoxNom.Text = "";
			    textBoxPrenom.Text = "";
			    textBoxAge.Text = "";
			    comboBoxClasse.SelectedIndex = -1;
			    textBoxMoyenne.Text = "";
			    comboBoxNationalite.SelectedIndex = -1;
			    //
			    buttonUpdate.Enabled = false ;
				buttonUpdate.Hide();
				buttonValider.Enabled = true ;
				buttonValider.Show();
		}
		//
		private void loadStudents()
        {
            DataTable dataTable = RetrieveDataFromDatabase();
            
            dataTableEtu.DataSource = dataTable;
        }
		//
		
		public DataTable RetrieveDataFromDatabase()
		{
		    DataTable dataTable = new DataTable();
		
		    using (MySqlConnection connection = new MySqlConnection(connectionString))
		    {
		        connection.Open();
		
		        string query = "SELECT * FROM t_students "; 
		        MySqlCommand command = new MySqlCommand(query, connection);
		        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
		        {
		            adapter.Fill(dataTable);
		        }
		    }
		
		    return dataTable;
		}
		public bool ValidateFields()
		{
		    string errorMessage = "";
		
		    if (string.IsNullOrWhiteSpace(textBoxMatricule.Text))
		    {
		    	errorMessage +="\nEntrez un Matricule valide" ;
		    }
		
		    if (string.IsNullOrWhiteSpace(textBoxNom.Text))
		    {
		        errorMessage +="\nEntrez un Nom valide.";
		    }
		
		    if (string.IsNullOrWhiteSpace(textBoxPrenom.Text))
		    {
		        errorMessage +="\nEntrez un Prenom valide.";
		    }
		
		    if (string.IsNullOrWhiteSpace(comboBoxClasse.Text))
		    {
		        errorMessage +="\nSelectionner une Classe Valide.";
		    }
		
		    if (string.IsNullOrWhiteSpace(comboBoxNationalite.Text))
		    {
		        errorMessage +="\nSelectionner une Nationalite valide.";
		        errorMessage +="\n Complete tous champ";
		    }
		
		    if (errorMessage.Length == 0)
		    {
		        return true;
		    }
		    else
		    {
		        MessageBox.Show(errorMessage.ToString());
		        return false;
		    }
	}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			 if (dataTableEtu.SelectedRows.Count > 0)
			    {
			        int selectedRowIndex = dataTableEtu.SelectedRows[0].Index;
			        int matriculeToEdit = Convert.ToInt32(dataTableEtu.Rows[selectedRowIndex].Cells["Matricule"].Value);
			
			        using (MySqlConnection connection = new MySqlConnection(connectionString))
			        {
			            connection.Open();
			
			            string updateQuery = "UPDATE t_students SET nom = @Nom, prenom = @Prenom, age = @Age, classe = @Classe, moyenne = @Moyenne, nationalite = @Nationalite WHERE matricule = @Matricule";
			            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
			            updateCommand.Parameters.AddWithValue("@Nom", textBoxNom.Text);
			            updateCommand.Parameters.AddWithValue("@Prenom", textBoxPrenom.Text);
			            updateCommand.Parameters.AddWithValue("@Age", Convert.ToInt32(textBoxAge.Text));
			            updateCommand.Parameters.AddWithValue("@Classe", comboBoxClasse.SelectedItem.ToString());
			            updateCommand.Parameters.AddWithValue("@Moyenne", Convert.ToSingle(textBoxMoyenne.Text));
			            updateCommand.Parameters.AddWithValue("@Nationalite", comboBoxNationalite.SelectedItem.ToString());
			            updateCommand.Parameters.AddWithValue("@Matricule", matriculeToEdit);
			
			            int rowsAffected = updateCommand.ExecuteNonQuery();
			            if (rowsAffected > 0)
			            {
			                MessageBox.Show("Étudiant mis à jour avec succès.");
			                ClearFormFields();
			                loadStudents();
			            }
			            else
			            {
			                MessageBox.Show("La mise à jour a échoué.");
			            }
			        }
			    }
			    else
			    {
			        MessageBox.Show("Sélectionnez un étudiant à modifier.");
			    }
		}
		
		private void TextBoxSearchTextChanged(object sender, EventArgs e)
		{
				string searchText = textBoxSearch.Text.ToLower();
				
				DataTable dataTable = RetrieveDataFromDatabase();
		        DataView dv =  dataTable.DefaultView;
		        
		        //dv.RowFilter = "matricule LIKE '%" searchText + "nom LIKE '%" + searchText + "%' OR prenom LIKE '%" + searchText + "%' OR classe LIKE '%" + searchText + "%' OR nationalite LIKE '%" + searchText + "%'";
		        
		        dv.RowFilter = "nom LIKE '%" + searchText + "%' OR prenom LIKE '%" + searchText + "%' OR classe LIKE '%" + searchText + "%' OR nationalite LIKE '%" + searchText + "%'";
		        dataTableEtu.DataSource = dv; // Mettre à jour la source de données du DataGridView avec le DataView filtré
		    
		}
		
	}
}
