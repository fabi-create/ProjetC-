/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 13/08/2023
 * Time: 23:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class Utilisateurs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.DataGridView tableauUtilisateur;
		
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
			this.AddButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.tableauUtilisateur = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.tableauUtilisateur)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddButton.Location = new System.Drawing.Point(178, 341);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 34);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Ajouter";
			this.AddButton.UseVisualStyleBackColor = false;
			// 
			// UpdateButton
			// 
			this.UpdateButton.BackColor = System.Drawing.Color.LawnGreen;
			this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateButton.Location = new System.Drawing.Point(359, 343);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(86, 34);
			this.UpdateButton.TabIndex = 1;
			this.UpdateButton.Text = "Modifier";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
			this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(557, 343);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(97, 34);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.Text = "Supprimer";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.MistyRose;
			this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.Location = new System.Drawing.Point(740, 343);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 30);
			this.quitButton.TabIndex = 3;
			this.quitButton.Text = "Quitter";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(178, 33);
			this.searchBox.Multiline = true;
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(637, 32);
			this.searchBox.TabIndex = 5;
			this.searchBox.TextChanged += new System.EventHandler(this.SearchBoxTextChanged);
			// 
			// tableauUtilisateur
			// 
			this.tableauUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableauUtilisateur.Location = new System.Drawing.Point(178, 79);
			this.tableauUtilisateur.Name = "tableauUtilisateur";
			this.tableauUtilisateur.Size = new System.Drawing.Size(637, 235);
			this.tableauUtilisateur.TabIndex = 6;
			this.tableauUtilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableauUtilisateurCellContentClick);
			// 
			// Utilisateurs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(885, 418);
			this.Controls.Add(this.tableauUtilisateur);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.AddButton);
			this.Name = "Utilisateurs";
			this.Text = "Utilisateurs";
			((System.ComponentModel.ISupportInitialize)(this.tableauUtilisateur)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
