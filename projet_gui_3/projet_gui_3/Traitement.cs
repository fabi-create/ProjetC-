/*
 * Created by SharpDevelop.
 * User: Kodjo
 * Date: 04/08/2023
 * Time: 09:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projet_gui_3
{
	/// <summary>
	/// Description of Traitement.
	/// </summary>
	public partial class Traitement : Form
	{
		private static Color ct ;
		private static Color cf ;
		private static Font ft ;
		public void updateMessageForm(){
			
                message.ForeColor = ct;
                message.BackColor = cf;
                message.Font = ft;
            
		}
		public Traitement()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		void CFRougeCheckedChanged(object sender, EventArgs e)
		{
			if (CFRouge.Checked)
            {
                cf = Color.Red;
                updateMessageForm();
            }
		}
		void CFBleuCheckedChanged(object sender, EventArgs e)
		{
			if (CFBleu.Checked)
            {
                cf = Color.Blue;
                updateMessageForm();
            }
		}
		void CFVertCheckedChanged(object sender, EventArgs e)
		{
			if (CFVert.Checked)
            {
                cf = Color.Green;
                updateMessageForm();
            }
		}
		void CFBlancCheckedChanged(object sender, EventArgs e)
		{
			if (CFBlanc.Checked)
            {
                cf = Color.White;
                updateMessageForm();
            }
		}
		void CFNoirCheckedChanged(object sender, EventArgs e)
		{
			if (CFNoir.Checked)
            {
                cf = Color.Black;
                updateMessageForm();
            }
		}
		void CTRougeCheckedChanged(object sender, EventArgs e)
		{
			if (CTRouge.Checked)
            {
                ct = Color.Red;
                updateMessageForm();
            }
		}
		void CTBleuCheckedChanged(object sender, EventArgs e)
		{
			if (CTBleu.Checked)
            {
                ct = Color.Blue;
                updateMessageForm();
            }
		}
		void CTVertCheckedChanged(object sender, EventArgs e)
		{
			if (CTVert.Checked)
            {
                ct = Color.Green;
                updateMessageForm();
            }
		}
		void CTBlancCheckedChanged(object sender, EventArgs e)
		{
			if (CTBlanc.Checked)
            {
                ct = Color.White;
                updateMessageForm();
            }
		}
		void CTNoirCheckedChanged(object sender, EventArgs e)
		{
			if (CTNoir.Checked)
            {
                ct = Color.Black;
                updateMessageForm();
            }
		}
		void FTItaligueCheckedChanged(object sender, EventArgs e)
		{
			FontStyle style = message.Font.Style;
            if (FTItaligue.Checked)
            {
                style |= FontStyle.Italic;
            }
            else
            {
                style &= ~FontStyle.Italic;
            }
            ft = new Font(message.Font, style);
            updateMessageForm();
			
		}
		void FTGrasCheckedChanged(object sender, EventArgs e)
		{
			FontStyle style = message.Font.Style;
            if (FTGras.Checked)
            {
                style |= FontStyle.Bold;
                
            }
            else
            {
                style &= ~FontStyle.Bold;
              
            }
            ft = new Font(message.Font, style);
            
            updateMessageForm();
			
		}
		void FTSouligneCheckedChanged(object sender, EventArgs e)
		{	
			FontStyle style = message.Font.Style;
            if (FTSouligne.Checked)
            {
                style |= FontStyle.Underline;
            }
            else
            {
                style &= ~FontStyle.Underline;
            }
            ft = new Font(message.Font, style);
            updateMessageForm();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
//			Form1 etudiant = new Form1() ;
//			etudiant.Show();
			StudentForm sf = new StudentForm();
			sf.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
	}
}
