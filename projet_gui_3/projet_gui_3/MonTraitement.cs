/*

 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projet_gui_3
{
	/// <summary>
	/// Description of MonTraitement.
	/// </summary>
	public partial class MonTraitement : Form
	{
		
		
		public MonTraitement()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void AppliquerProprietesTexte() {
            FontStyle style = FontStyle.Regular;

            if (ftGras.Checked)
                style |= FontStyle.Bold;
            if (ftItalique.Checked)
                style |= FontStyle.Italic;
            if (ftSouligne.Checked)
                style |= FontStyle.Underline;
            
			message.Font = new Font(message.Font, style);
			
			if(ctRouge.Checked)
				message.ForeColor = Color.Red;
			if(ctBleu.Checked)
				message.ForeColor = Color.Blue;
			if(ctVert.Checked)
				message.ForeColor = Color.Green;
			if(ctBlanc.Checked)
				message.ForeColor = Color.White;
			if(ctNoir.Checked)
				message.ForeColor = Color.Black;
			
			if(cfRouge.Checked)
				message.BackColor = Color.Red;
			if(cfBleu.Checked)
				message.BackColor = Color.Blue;
			if(cfVert.Checked)
				message.BackColor = Color.Green;
			if(cfBlanc.Checked)
				message.BackColor = Color.White;
			if(cfNoir.Checked)
				message.BackColor = Color.Black;
		}
		
		//Forme de texte
		void FtItaliqueCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void FtGrasCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void FtSouligneCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		
		//Couleur de texte
		void CtRougeCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CtBleuCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CtVertCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CtBlancCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CtNoirCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		
		//Couleur de fond de texte
		void CfRougeCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CfBleuCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CfVertCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CfBlancCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void CfNoirCheckedChanged(object sender, EventArgs e)
		{
			AppliquerProprietesTexte();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
			var etu = new FormEtudiant();
			etu.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			var etu = new Etudiants();
			etu.Show();
			this.Hide();
		}
	}
}
