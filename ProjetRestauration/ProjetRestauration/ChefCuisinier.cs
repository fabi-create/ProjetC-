/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 23/08/2023
 * Time: 23:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of ChefCuisinier.
	/// </summary>
	public partial class ChefCuisinier : Form
	{
		public ChefCuisinier()
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
	var user = new Produits();
			user.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			var user = new FormProduit();
			user.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
