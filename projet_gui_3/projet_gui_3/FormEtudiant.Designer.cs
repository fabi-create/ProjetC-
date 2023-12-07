/*

 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class FormEtudiant
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox matriculeBox;
		private System.Windows.Forms.TextBox nomBox;
		private System.Windows.Forms.TextBox prenomBox;
		private System.Windows.Forms.TextBox classeBox;
		private System.Windows.Forms.TextBox moyenneBox;
		private System.Windows.Forms.ComboBox nationaliteBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.matriculeBox = new System.Windows.Forms.TextBox();
			this.nomBox = new System.Windows.Forms.TextBox();
			this.prenomBox = new System.Windows.Forms.TextBox();
			this.classeBox = new System.Windows.Forms.TextBox();
			this.moyenneBox = new System.Windows.Forms.TextBox();
			this.nationaliteBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(213, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Formulaire";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(173, 103);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Matricule";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(173, 159);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nom";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(173, 220);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Prenom";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(173, 274);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Classe";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(173, 335);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 19);
			this.label6.TabIndex = 5;
			this.label6.Text = "Moyenne";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(173, 388);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 19);
			this.label7.TabIndex = 6;
			this.label7.Text = "Nationalité";
			// 
			// matriculeBox
			// 
			this.matriculeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matriculeBox.Location = new System.Drawing.Point(276, 97);
			this.matriculeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.matriculeBox.Multiline = true;
			this.matriculeBox.Name = "matriculeBox";
			this.matriculeBox.Size = new System.Drawing.Size(155, 26);
			this.matriculeBox.TabIndex = 7;
			// 
			// nomBox
			// 
			this.nomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomBox.Location = new System.Drawing.Point(276, 153);
			this.nomBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nomBox.Multiline = true;
			this.nomBox.Name = "nomBox";
			this.nomBox.Size = new System.Drawing.Size(155, 26);
			this.nomBox.TabIndex = 8;
			// 
			// prenomBox
			// 
			this.prenomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prenomBox.Location = new System.Drawing.Point(276, 213);
			this.prenomBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.prenomBox.Multiline = true;
			this.prenomBox.Name = "prenomBox";
			this.prenomBox.Size = new System.Drawing.Size(155, 26);
			this.prenomBox.TabIndex = 9;
			// 
			// classeBox
			// 
			this.classeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classeBox.Location = new System.Drawing.Point(276, 267);
			this.classeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.classeBox.Multiline = true;
			this.classeBox.Name = "classeBox";
			this.classeBox.Size = new System.Drawing.Size(155, 26);
			this.classeBox.TabIndex = 10;
			// 
			// moyenneBox
			// 
			this.moyenneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moyenneBox.Location = new System.Drawing.Point(276, 328);
			this.moyenneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.moyenneBox.Multiline = true;
			this.moyenneBox.Name = "moyenneBox";
			this.moyenneBox.Size = new System.Drawing.Size(155, 26);
			this.moyenneBox.TabIndex = 11;
			// 
			// nationaliteBox
			// 
			this.nationaliteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nationaliteBox.FormattingEnabled = true;
			this.nationaliteBox.ItemHeight = 18;
			this.nationaliteBox.Items.AddRange(new object[] {
			"Béninoise",
			"Malienne",
			"Nigérienne",
			"Sénégalaise",
			"Togolaise"});
			this.nationaliteBox.Location = new System.Drawing.Point(276, 386);
			this.nationaliteBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nationaliteBox.Name = "nationaliteBox";
			this.nationaliteBox.Size = new System.Drawing.Size(155, 26);
			this.nationaliteBox.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(203, 446);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 28);
			this.button1.TabIndex = 14;
			this.button1.Text = "Ajouter";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Maroon;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(323, 446);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 28);
			this.button2.TabIndex = 15;
			this.button2.Text = "Annuler";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// FormEtudiant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(662, 531);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nationaliteBox);
			this.Controls.Add(this.moyenneBox);
			this.Controls.Add(this.classeBox);
			this.Controls.Add(this.prenomBox);
			this.Controls.Add(this.nomBox);
			this.Controls.Add(this.matriculeBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormEtudiant";
			this.Text = "FormEtudiant";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
