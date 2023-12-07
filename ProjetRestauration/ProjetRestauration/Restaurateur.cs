/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/08/2023
 * Time: 18:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of Restaurateur.
	/// </summary>
	public partial class Restaurateur : Form
	{
		public Restaurateur()
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
	var pro = new FormCommande();
			 pro.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
//				var pro = new Paiements();
//			 pro.Show();
//			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void RestaurateurLoad(object sender, EventArgs e)
		{
	
		}
	}
}
