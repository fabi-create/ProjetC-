/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 23/08/2023
 * Time: 23:37
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
	/// Description of Administrateur.
	/// </summary>
	public partial class Administrateur : Form
	{
		public Administrateur()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
	var user = new FormUtilisateur();
			user.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
	var user = new Utilisateurs();
			user.Show();
			this.Hide();
		}
	}
}
