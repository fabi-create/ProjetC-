/*
 * Created by SharpDevelop.
 * User: Yvan GBAFFONOU
 * Date: 04/08/2023
 * Time: 23:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class PreviewEtudiant
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox moyenneBox;
		private System.Windows.Forms.TextBox classeBox;
		private System.Windows.Forms.TextBox prenomBox;
		private System.Windows.Forms.TextBox nomBox;
		private System.Windows.Forms.TextBox matriculeBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.ComboBox nationaliteBox;
		
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
			this.cancelButton = new System.Windows.Forms.Button();
			this.moyenneBox = new System.Windows.Forms.TextBox();
			this.classeBox = new System.Windows.Forms.TextBox();
			this.prenomBox = new System.Windows.Forms.TextBox();
			this.nomBox = new System.Windows.Forms.TextBox();
			this.matriculeBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.confirmButton = new System.Windows.Forms.Button();
			this.nationaliteBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Red;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(360, 564);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(126, 34);
			this.cancelButton.TabIndex = 30;
			this.cancelButton.Text = "Annuler";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// moyenneBox
			// 
			this.moyenneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moyenneBox.Location = new System.Drawing.Point(297, 389);
			this.moyenneBox.Multiline = true;
			this.moyenneBox.Name = "moyenneBox";
			this.moyenneBox.Size = new System.Drawing.Size(205, 31);
			this.moyenneBox.TabIndex = 27;
			// 
			// classeBox
			// 
			this.classeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classeBox.Location = new System.Drawing.Point(297, 314);
			this.classeBox.Multiline = true;
			this.classeBox.Name = "classeBox";
			this.classeBox.Size = new System.Drawing.Size(205, 31);
			this.classeBox.TabIndex = 26;
			// 
			// prenomBox
			// 
			this.prenomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prenomBox.Location = new System.Drawing.Point(297, 248);
			this.prenomBox.Multiline = true;
			this.prenomBox.Name = "prenomBox";
			this.prenomBox.Size = new System.Drawing.Size(205, 31);
			this.prenomBox.TabIndex = 25;
			// 
			// nomBox
			// 
			this.nomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomBox.Location = new System.Drawing.Point(297, 173);
			this.nomBox.Multiline = true;
			this.nomBox.Name = "nomBox";
			this.nomBox.Size = new System.Drawing.Size(205, 31);
			this.nomBox.TabIndex = 24;
			// 
			// matriculeBox
			// 
			this.matriculeBox.Enabled = false;
			this.matriculeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matriculeBox.Location = new System.Drawing.Point(297, 104);
			this.matriculeBox.Multiline = true;
			this.matriculeBox.Name = "matriculeBox";
			this.matriculeBox.Size = new System.Drawing.Size(205, 31);
			this.matriculeBox.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(160, 463);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Nationalité";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(160, 397);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "Moyenne";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(160, 322);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Classe";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(160, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Prenom";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(160, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Nom";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Matricule";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(212, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 53);
			this.label1.TabIndex = 16;
			this.label1.Text = "Modifier";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// confirmButton
			// 
			this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(127)))), ((int)(((byte)(238)))));
			this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmButton.ForeColor = System.Drawing.Color.White;
			this.confirmButton.Location = new System.Drawing.Point(200, 564);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(126, 34);
			this.confirmButton.TabIndex = 29;
			this.confirmButton.Text = "Confirmer";
			this.confirmButton.UseVisualStyleBackColor = false;
			this.confirmButton.Click += new System.EventHandler(this.ConfirmButtonClick);
			// 
			// nationaliteBox
			// 
			this.nationaliteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nationaliteBox.FormattingEnabled = true;
			this.nationaliteBox.ItemHeight = 22;
			this.nationaliteBox.Items.AddRange(new object[] {
			"Beninoise",
			"Nigerienne",
			"Malienne",
			"Senegalaise"});
			this.nationaliteBox.Location = new System.Drawing.Point(297, 462);
			this.nationaliteBox.Name = "nationaliteBox";
			this.nationaliteBox.Size = new System.Drawing.Size(205, 30);
			this.nationaliteBox.TabIndex = 31;
			// 
			// PreviewEtudiant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(675, 631);
			this.Controls.Add(this.nationaliteBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.confirmButton);
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
			this.Name = "PreviewEtudiant";
			this.Text = "PreviewEtudiant";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
