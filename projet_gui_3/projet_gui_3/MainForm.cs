/*

 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projet_gui_3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MonTraitement traitement = new MonTraitement();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void QuitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void ConnectButtonClick(object sender, EventArgs e)
		{
			if(loginBox.Text.ToLower() == "isi" && passwordBox.Text.ToLower() == "passer" ){
				traitement.Show();
				this.Hide();
			}else{
				loginBox.Text = "";
				passwordBox.Text = "";
				errorLabel.Visible = true;
			}
		}
		void ErrorLabelClick(object sender, EventArgs e)
		{
	
		}
		
		
	}
}
