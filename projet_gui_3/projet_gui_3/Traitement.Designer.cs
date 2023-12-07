/*
 * Created by SharpDevelop.
 * User: Kodjo
 * Date: 04/08/2023
 * Time: 09:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class Traitement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox message;
		private System.Windows.Forms.RadioButton CTRouge;
		private System.Windows.Forms.RadioButton CTBleu;
		private System.Windows.Forms.RadioButton CTVert;
		private System.Windows.Forms.RadioButton CTNoir;
		private System.Windows.Forms.RadioButton CTBlanc;
		private System.Windows.Forms.CheckBox FTItaligue;
		private System.Windows.Forms.CheckBox FTGras;
		private System.Windows.Forms.CheckBox FTSouligne;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton CFBlanc;
		private System.Windows.Forms.RadioButton CFNoir;
		private System.Windows.Forms.RadioButton CFVert;
		private System.Windows.Forms.RadioButton CFBleu;
		private System.Windows.Forms.RadioButton CFRouge;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		
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
			this.message = new System.Windows.Forms.TextBox();
			this.CTRouge = new System.Windows.Forms.RadioButton();
			this.CTBleu = new System.Windows.Forms.RadioButton();
			this.CTVert = new System.Windows.Forms.RadioButton();
			this.CTNoir = new System.Windows.Forms.RadioButton();
			this.CTBlanc = new System.Windows.Forms.RadioButton();
			this.FTItaligue = new System.Windows.Forms.CheckBox();
			this.FTGras = new System.Windows.Forms.CheckBox();
			this.FTSouligne = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CFBlanc = new System.Windows.Forms.RadioButton();
			this.CFNoir = new System.Windows.Forms.RadioButton();
			this.CFVert = new System.Windows.Forms.RadioButton();
			this.CFBleu = new System.Windows.Forms.RadioButton();
			this.CFRouge = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// message
			// 
			this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.message.Location = new System.Drawing.Point(148, 159);
			this.message.Multiline = true;
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(612, 203);
			this.message.TabIndex = 0;
			// 
			// CTRouge
			// 
			this.CTRouge.Location = new System.Drawing.Point(33, 24);
			this.CTRouge.Name = "CTRouge";
			this.CTRouge.Size = new System.Drawing.Size(104, 30);
			this.CTRouge.TabIndex = 1;
			this.CTRouge.TabStop = true;
			this.CTRouge.Text = "Rouge";
			this.CTRouge.UseVisualStyleBackColor = true;
			this.CTRouge.CheckedChanged += new System.EventHandler(this.CTRougeCheckedChanged);
			// 
			// CTBleu
			// 
			this.CTBleu.Location = new System.Drawing.Point(168, 26);
			this.CTBleu.Name = "CTBleu";
			this.CTBleu.Size = new System.Drawing.Size(104, 30);
			this.CTBleu.TabIndex = 2;
			this.CTBleu.TabStop = true;
			this.CTBleu.Text = "Bleu";
			this.CTBleu.UseVisualStyleBackColor = true;
			this.CTBleu.CheckedChanged += new System.EventHandler(this.CTBleuCheckedChanged);
			// 
			// CTVert
			// 
			this.CTVert.Location = new System.Drawing.Point(296, 26);
			this.CTVert.Name = "CTVert";
			this.CTVert.Size = new System.Drawing.Size(104, 30);
			this.CTVert.TabIndex = 3;
			this.CTVert.TabStop = true;
			this.CTVert.Text = "Vert";
			this.CTVert.UseVisualStyleBackColor = true;
			this.CTVert.CheckedChanged += new System.EventHandler(this.CTVertCheckedChanged);
			// 
			// CTNoir
			// 
			this.CTNoir.Location = new System.Drawing.Point(590, 25);
			this.CTNoir.Name = "CTNoir";
			this.CTNoir.Size = new System.Drawing.Size(78, 30);
			this.CTNoir.TabIndex = 4;
			this.CTNoir.TabStop = true;
			this.CTNoir.Text = "Noir";
			this.CTNoir.UseVisualStyleBackColor = true;
			this.CTNoir.CheckedChanged += new System.EventHandler(this.CTNoirCheckedChanged);
			// 
			// CTBlanc
			// 
			this.CTBlanc.Location = new System.Drawing.Point(441, 23);
			this.CTBlanc.Name = "CTBlanc";
			this.CTBlanc.Size = new System.Drawing.Size(109, 30);
			this.CTBlanc.TabIndex = 5;
			this.CTBlanc.TabStop = true;
			this.CTBlanc.Text = "Blanc";
			this.CTBlanc.UseVisualStyleBackColor = true;
			this.CTBlanc.CheckedChanged += new System.EventHandler(this.CTBlancCheckedChanged);
			// 
			// FTItaligue
			// 
			this.FTItaligue.Location = new System.Drawing.Point(259, 390);
			this.FTItaligue.Name = "FTItaligue";
			this.FTItaligue.Size = new System.Drawing.Size(104, 24);
			this.FTItaligue.TabIndex = 6;
			this.FTItaligue.Text = "Italique";
			this.FTItaligue.UseVisualStyleBackColor = true;
			this.FTItaligue.CheckedChanged += new System.EventHandler(this.FTItaligueCheckedChanged);
			// 
			// FTGras
			// 
			this.FTGras.Location = new System.Drawing.Point(383, 390);
			this.FTGras.Name = "FTGras";
			this.FTGras.Size = new System.Drawing.Size(104, 24);
			this.FTGras.TabIndex = 7;
			this.FTGras.Text = "Gras";
			this.FTGras.UseVisualStyleBackColor = true;
			this.FTGras.CheckedChanged += new System.EventHandler(this.FTGrasCheckedChanged);
			// 
			// FTSouligne
			// 
			this.FTSouligne.Location = new System.Drawing.Point(511, 390);
			this.FTSouligne.Name = "FTSouligne";
			this.FTSouligne.Size = new System.Drawing.Size(104, 24);
			this.FTSouligne.TabIndex = 8;
			this.FTSouligne.Text = "Souligné";
			this.FTSouligne.UseVisualStyleBackColor = true;
			this.FTSouligne.CheckedChanged += new System.EventHandler(this.FTSouligneCheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Couleur de texte";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 388);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Forme de texte";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "Couleur de fond";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// CFBlanc
			// 
			this.CFBlanc.Location = new System.Drawing.Point(456, 25);
			this.CFBlanc.Name = "CFBlanc";
			this.CFBlanc.Size = new System.Drawing.Size(94, 24);
			this.CFBlanc.TabIndex = 15;
			this.CFBlanc.TabStop = true;
			this.CFBlanc.Text = "Blanc";
			this.CFBlanc.UseVisualStyleBackColor = true;
			this.CFBlanc.CheckedChanged += new System.EventHandler(this.CFBlancCheckedChanged);
			// 
			// CFNoir
			// 
			this.CFNoir.Location = new System.Drawing.Point(586, 26);
			this.CFNoir.Name = "CFNoir";
			this.CFNoir.Size = new System.Drawing.Size(82, 24);
			this.CFNoir.TabIndex = 14;
			this.CFNoir.TabStop = true;
			this.CFNoir.Text = "Noir";
			this.CFNoir.UseVisualStyleBackColor = true;
			this.CFNoir.CheckedChanged += new System.EventHandler(this.CFNoirCheckedChanged);
			// 
			// CFVert
			// 
			this.CFVert.Location = new System.Drawing.Point(302, 25);
			this.CFVert.Name = "CFVert";
			this.CFVert.Size = new System.Drawing.Size(104, 24);
			this.CFVert.TabIndex = 13;
			this.CFVert.TabStop = true;
			this.CFVert.Text = "Vert";
			this.CFVert.UseVisualStyleBackColor = true;
			this.CFVert.CheckedChanged += new System.EventHandler(this.CFVertCheckedChanged);
			// 
			// CFBleu
			// 
			this.CFBleu.Location = new System.Drawing.Point(168, 25);
			this.CFBleu.Name = "CFBleu";
			this.CFBleu.Size = new System.Drawing.Size(104, 24);
			this.CFBleu.TabIndex = 12;
			this.CFBleu.TabStop = true;
			this.CFBleu.Text = "Bleu";
			this.CFBleu.UseVisualStyleBackColor = true;
			this.CFBleu.CheckedChanged += new System.EventHandler(this.CFBleuCheckedChanged);
			// 
			// CFRouge
			// 
			this.CFRouge.Location = new System.Drawing.Point(33, 25);
			this.CFRouge.Name = "CFRouge";
			this.CFRouge.Size = new System.Drawing.Size(104, 24);
			this.CFRouge.TabIndex = 11;
			this.CFRouge.TabStop = true;
			this.CFRouge.Text = "Rouge";
			this.CFRouge.UseVisualStyleBackColor = true;
			this.CFRouge.CheckedChanged += new System.EventHandler(this.CFRougeCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CTBleu);
			this.groupBox1.Controls.Add(this.CTRouge);
			this.groupBox1.Controls.Add(this.CTVert);
			this.groupBox1.Controls.Add(this.CTNoir);
			this.groupBox1.Controls.Add(this.CTBlanc);
			this.groupBox1.Location = new System.Drawing.Point(337, 81);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 59);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CFRouge);
			this.groupBox2.Controls.Add(this.CFBleu);
			this.groupBox2.Controls.Add(this.CFVert);
			this.groupBox2.Controls.Add(this.CFBlanc);
			this.groupBox2.Controls.Add(this.CFNoir);
			this.groupBox2.Location = new System.Drawing.Point(337, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(751, 63);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(337, 450);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(241, 59);
			this.button1.TabIndex = 19;
			this.button1.Text = "Gestion Etudiant";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Traitement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1126, 550);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FTSouligne);
			this.Controls.Add(this.FTGras);
			this.Controls.Add(this.FTItaligue);
			this.Controls.Add(this.message);
			this.Name = "Traitement";
			this.Text = "Traitement";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
