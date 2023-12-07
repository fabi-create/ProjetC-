/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 14/08/2023
 * Time: 00:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class PreviewUtilisateur
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
		private System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.TextBox nomBox;
		private System.Windows.Forms.TextBox emailBox;
		private System.Windows.Forms.TextBox numberBox;
		private System.Windows.Forms.TextBox passeBox;
		private System.Windows.Forms.ComboBox typecomboBox;
		private System.Windows.Forms.Button ConfirmButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		
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
			this.idBox = new System.Windows.Forms.TextBox();
			this.nomBox = new System.Windows.Forms.TextBox();
			this.emailBox = new System.Windows.Forms.TextBox();
			this.numberBox = new System.Windows.Forms.TextBox();
			this.passeBox = new System.Windows.Forms.TextBox();
			this.typecomboBox = new System.Windows.Forms.ComboBox();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(172, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(172, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nom Utilisateur";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(172, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(170, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Téléphone ";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(172, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mot De Passe";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(172, 344);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Type d\'Utilisateur";
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(393, 114);
			this.idBox.Multiline = true;
			this.idBox.Name = "idBox";
			this.idBox.Size = new System.Drawing.Size(121, 20);
			this.idBox.TabIndex = 6;
			// 
			// nomBox
			// 
			this.nomBox.Location = new System.Drawing.Point(393, 157);
			this.nomBox.Multiline = true;
			this.nomBox.Name = "nomBox";
			this.nomBox.Size = new System.Drawing.Size(121, 20);
			this.nomBox.TabIndex = 7;
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(393, 203);
			this.emailBox.Multiline = true;
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(121, 20);
			this.emailBox.TabIndex = 8;
			// 
			// numberBox
			// 
			this.numberBox.Location = new System.Drawing.Point(393, 250);
			this.numberBox.Multiline = true;
			this.numberBox.Name = "numberBox";
			this.numberBox.Size = new System.Drawing.Size(121, 20);
			this.numberBox.TabIndex = 9;
			// 
			// passeBox
			// 
			this.passeBox.Location = new System.Drawing.Point(393, 299);
			this.passeBox.Multiline = true;
			this.passeBox.Name = "passeBox";
			this.passeBox.Size = new System.Drawing.Size(121, 20);
			this.passeBox.TabIndex = 10;
			// 
			// typecomboBox
			// 
			this.typecomboBox.FormattingEnabled = true;
			this.typecomboBox.Items.AddRange(new object[] {
			"Restaurateur",
			"ChefCuisinier"});
			this.typecomboBox.Location = new System.Drawing.Point(393, 346);
			this.typecomboBox.Name = "typecomboBox";
			this.typecomboBox.Size = new System.Drawing.Size(121, 21);
			this.typecomboBox.TabIndex = 11;
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConfirmButton.Location = new System.Drawing.Point(172, 393);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(98, 28);
			this.ConfirmButton.TabIndex = 12;
			this.ConfirmButton.Text = "Confirmer";
			this.ConfirmButton.UseVisualStyleBackColor = false;
			this.ConfirmButton.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(416, 393);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 28);
			this.button2.TabIndex = 13;
			this.button2.Text = "Terminer";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(147, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(448, 43);
			this.label7.TabIndex = 14;
			this.label7.Text = "MODIFICATION D\'UTILISATEUR";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// PreviewUtilisateur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(848, 433);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.typecomboBox);
			this.Controls.Add(this.passeBox);
			this.Controls.Add(this.numberBox);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.nomBox);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PreviewUtilisateur";
			this.Text = "PreviewUtilisateur";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
