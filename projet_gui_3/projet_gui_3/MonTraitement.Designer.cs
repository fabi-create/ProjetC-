/*
 * Created by SharpDevelop.
 * User: Yvan GBAFFONOU
 * Date: 04/08/2023
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class MonTraitement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton cfNoir;
		private System.Windows.Forms.RadioButton cfBlanc;
		private System.Windows.Forms.RadioButton cfVert;
		private System.Windows.Forms.RadioButton cfBleu;
		private System.Windows.Forms.RadioButton cfRouge;
		private System.Windows.Forms.CheckBox ftSouligne;
		private System.Windows.Forms.CheckBox ftGras;
		private System.Windows.Forms.CheckBox ftItalique;
		private System.Windows.Forms.RadioButton ctNoir;
		private System.Windows.Forms.RadioButton ctBlanc;
		private System.Windows.Forms.RadioButton ctVert;
		private System.Windows.Forms.RadioButton ctBleu;
		private System.Windows.Forms.RadioButton ctRouge;
		private System.Windows.Forms.TextBox message;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.cfNoir = new System.Windows.Forms.RadioButton();
			this.cfBlanc = new System.Windows.Forms.RadioButton();
			this.cfVert = new System.Windows.Forms.RadioButton();
			this.cfBleu = new System.Windows.Forms.RadioButton();
			this.cfRouge = new System.Windows.Forms.RadioButton();
			this.ftSouligne = new System.Windows.Forms.CheckBox();
			this.ftGras = new System.Windows.Forms.CheckBox();
			this.ftItalique = new System.Windows.Forms.CheckBox();
			this.ctNoir = new System.Windows.Forms.RadioButton();
			this.ctBlanc = new System.Windows.Forms.RadioButton();
			this.ctVert = new System.Windows.Forms.RadioButton();
			this.ctBleu = new System.Windows.Forms.RadioButton();
			this.ctRouge = new System.Windows.Forms.RadioButton();
			this.message = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(442, 422);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 29);
			this.button1.TabIndex = 57;
			this.button1.Text = "Terminer";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// cfNoir
			// 
			this.cfNoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cfNoir.Location = new System.Drawing.Point(390, 42);
			this.cfNoir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cfNoir.Name = "cfNoir";
			this.cfNoir.Size = new System.Drawing.Size(58, 20);
			this.cfNoir.TabIndex = 53;
			this.cfNoir.TabStop = true;
			this.cfNoir.Text = "Noir";
			this.cfNoir.UseVisualStyleBackColor = true;
			this.cfNoir.CheckedChanged += new System.EventHandler(this.CfNoirCheckedChanged);
			// 
			// cfBlanc
			// 
			this.cfBlanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cfBlanc.Location = new System.Drawing.Point(308, 42);
			this.cfBlanc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cfBlanc.Name = "cfBlanc";
			this.cfBlanc.Size = new System.Drawing.Size(78, 20);
			this.cfBlanc.TabIndex = 52;
			this.cfBlanc.TabStop = true;
			this.cfBlanc.Text = "Blanc";
			this.cfBlanc.UseVisualStyleBackColor = true;
			this.cfBlanc.CheckedChanged += new System.EventHandler(this.CfBlancCheckedChanged);
			// 
			// cfVert
			// 
			this.cfVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cfVert.Location = new System.Drawing.Point(225, 42);
			this.cfVert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cfVert.Name = "cfVert";
			this.cfVert.Size = new System.Drawing.Size(78, 20);
			this.cfVert.TabIndex = 51;
			this.cfVert.TabStop = true;
			this.cfVert.Text = "Vert";
			this.cfVert.UseVisualStyleBackColor = true;
			this.cfVert.CheckedChanged += new System.EventHandler(this.CfVertCheckedChanged);
			// 
			// cfBleu
			// 
			this.cfBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cfBleu.Location = new System.Drawing.Point(142, 42);
			this.cfBleu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cfBleu.Name = "cfBleu";
			this.cfBleu.Size = new System.Drawing.Size(78, 20);
			this.cfBleu.TabIndex = 50;
			this.cfBleu.TabStop = true;
			this.cfBleu.Text = "Bleu";
			this.cfBleu.UseVisualStyleBackColor = true;
			this.cfBleu.CheckedChanged += new System.EventHandler(this.CfBleuCheckedChanged);
			// 
			// cfRouge
			// 
			this.cfRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cfRouge.Location = new System.Drawing.Point(51, 42);
			this.cfRouge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cfRouge.Name = "cfRouge";
			this.cfRouge.Size = new System.Drawing.Size(70, 20);
			this.cfRouge.TabIndex = 49;
			this.cfRouge.TabStop = true;
			this.cfRouge.Text = "Rouge";
			this.cfRouge.UseVisualStyleBackColor = true;
			this.cfRouge.CheckedChanged += new System.EventHandler(this.CfRougeCheckedChanged);
			// 
			// ftSouligne
			// 
			this.ftSouligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ftSouligne.Location = new System.Drawing.Point(346, 349);
			this.ftSouligne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ftSouligne.Name = "ftSouligne";
			this.ftSouligne.Size = new System.Drawing.Size(95, 20);
			this.ftSouligne.TabIndex = 48;
			this.ftSouligne.Text = "Souligné";
			this.ftSouligne.UseVisualStyleBackColor = true;
			this.ftSouligne.CheckedChanged += new System.EventHandler(this.FtSouligneCheckedChanged);
			// 
			// ftGras
			// 
			this.ftGras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ftGras.Location = new System.Drawing.Point(208, 349);
			this.ftGras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ftGras.Name = "ftGras";
			this.ftGras.Size = new System.Drawing.Size(78, 20);
			this.ftGras.TabIndex = 47;
			this.ftGras.Text = "Gras";
			this.ftGras.UseVisualStyleBackColor = true;
			this.ftGras.CheckedChanged += new System.EventHandler(this.FtGrasCheckedChanged);
			// 
			// ftItalique
			// 
			this.ftItalique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ftItalique.Location = new System.Drawing.Point(67, 349);
			this.ftItalique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ftItalique.Name = "ftItalique";
			this.ftItalique.Size = new System.Drawing.Size(78, 20);
			this.ftItalique.TabIndex = 46;
			this.ftItalique.Text = "Italique";
			this.ftItalique.UseVisualStyleBackColor = true;
			this.ftItalique.CheckedChanged += new System.EventHandler(this.FtItaliqueCheckedChanged);
			// 
			// ctNoir
			// 
			this.ctNoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctNoir.Location = new System.Drawing.Point(390, 118);
			this.ctNoir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ctNoir.Name = "ctNoir";
			this.ctNoir.Size = new System.Drawing.Size(58, 20);
			this.ctNoir.TabIndex = 45;
			this.ctNoir.TabStop = true;
			this.ctNoir.Text = "Noir";
			this.ctNoir.UseVisualStyleBackColor = true;
			this.ctNoir.CheckedChanged += new System.EventHandler(this.CtNoirCheckedChanged);
			// 
			// ctBlanc
			// 
			this.ctBlanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctBlanc.Location = new System.Drawing.Point(308, 118);
			this.ctBlanc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ctBlanc.Name = "ctBlanc";
			this.ctBlanc.Size = new System.Drawing.Size(78, 20);
			this.ctBlanc.TabIndex = 44;
			this.ctBlanc.TabStop = true;
			this.ctBlanc.Text = "Blanc";
			this.ctBlanc.UseVisualStyleBackColor = true;
			this.ctBlanc.CheckedChanged += new System.EventHandler(this.CtBlancCheckedChanged);
			// 
			// ctVert
			// 
			this.ctVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctVert.Location = new System.Drawing.Point(225, 118);
			this.ctVert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ctVert.Name = "ctVert";
			this.ctVert.Size = new System.Drawing.Size(78, 20);
			this.ctVert.TabIndex = 43;
			this.ctVert.TabStop = true;
			this.ctVert.Text = "Vert";
			this.ctVert.UseVisualStyleBackColor = true;
			this.ctVert.CheckedChanged += new System.EventHandler(this.CtVertCheckedChanged);
			// 
			// ctBleu
			// 
			this.ctBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctBleu.Location = new System.Drawing.Point(142, 118);
			this.ctBleu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ctBleu.Name = "ctBleu";
			this.ctBleu.Size = new System.Drawing.Size(78, 20);
			this.ctBleu.TabIndex = 42;
			this.ctBleu.TabStop = true;
			this.ctBleu.Text = "Bleu";
			this.ctBleu.UseVisualStyleBackColor = true;
			this.ctBleu.CheckedChanged += new System.EventHandler(this.CtBleuCheckedChanged);
			// 
			// ctRouge
			// 
			this.ctRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctRouge.Location = new System.Drawing.Point(51, 118);
			this.ctRouge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ctRouge.Name = "ctRouge";
			this.ctRouge.Size = new System.Drawing.Size(70, 20);
			this.ctRouge.TabIndex = 41;
			this.ctRouge.TabStop = true;
			this.ctRouge.Text = "Rouge";
			this.ctRouge.UseVisualStyleBackColor = true;
			this.ctRouge.CheckedChanged += new System.EventHandler(this.CtRougeCheckedChanged);
			// 
			// message
			// 
			this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.message.Location = new System.Drawing.Point(36, 188);
			this.message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.message.Multiline = true;
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(418, 125);
			this.message.TabIndex = 40;
			this.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.groupBox3.Location = new System.Drawing.Point(36, 320);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox3.Size = new System.Drawing.Size(417, 84);
			this.groupBox3.TabIndex = 56;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Style de texte";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.YellowGreen;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(326, 422);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 29);
			this.button2.TabIndex = 59;
			this.button2.Text = "Formulaire";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Olive;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(208, 422);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 29);
			this.button3.TabIndex = 60;
			this.button3.Text = "Liste";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 61;
			this.label1.Text = "Couleur de fond";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(51, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 62;
			this.label2.Text = "Couleur de formze";
			// 
			// MonTraitement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(556, 480);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cfNoir);
			this.Controls.Add(this.cfBlanc);
			this.Controls.Add(this.cfVert);
			this.Controls.Add(this.cfBleu);
			this.Controls.Add(this.cfRouge);
			this.Controls.Add(this.ftSouligne);
			this.Controls.Add(this.ftGras);
			this.Controls.Add(this.ftItalique);
			this.Controls.Add(this.ctNoir);
			this.Controls.Add(this.ctBlanc);
			this.Controls.Add(this.ctVert);
			this.Controls.Add(this.ctBleu);
			this.Controls.Add(this.ctRouge);
			this.Controls.Add(this.message);
			this.Controls.Add(this.groupBox3);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MonTraitement";
			this.Text = "MonTraitement";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
