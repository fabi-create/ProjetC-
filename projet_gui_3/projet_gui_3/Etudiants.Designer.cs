/*
 * Created by SharpDevelop.
 * User: Yvan GBAFFONOU
 * Date: 05/08/2023
 * Time: 12:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class Etudiants
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView tableauEtudiant;
		private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
		private System.Windows.Forms.DataGridViewTextBoxColumn nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
		private System.Windows.Forms.DataGridViewTextBoxColumn classe;
		private System.Windows.Forms.DataGridViewTextBoxColumn moyenne;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nationalité;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.TextBox searchBox;
		
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
			this.tableauEtudiant = new System.Windows.Forms.DataGridView();
			this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nationalité = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.tableauEtudiant)).BeginInit();
			this.SuspendLayout();
			// 
			// tableauEtudiant
			// 
			this.tableauEtudiant.AllowUserToOrderColumns = true;
			this.tableauEtudiant.BackgroundColor = System.Drawing.Color.White;
			this.tableauEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableauEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.matricule,
			this.nom,
			this.prenom,
			this.classe,
			this.moyenne,
			this.Nationalité});
			this.tableauEtudiant.Location = new System.Drawing.Point(9, 115);
			this.tableauEtudiant.Margin = new System.Windows.Forms.Padding(2);
			this.tableauEtudiant.Name = "tableauEtudiant";
			this.tableauEtudiant.RowTemplate.Height = 24;
			this.tableauEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tableauEtudiant.Size = new System.Drawing.Size(628, 284);
			this.tableauEtudiant.TabIndex = 0;
			this.tableauEtudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// matricule
			// 
			this.matricule.DataPropertyName = "matricule";
			this.matricule.HeaderText = "Matricule";
			this.matricule.Name = "matricule";
			// 
			// nom
			// 
			this.nom.DataPropertyName = "nom";
			this.nom.HeaderText = "Nom";
			this.nom.Name = "nom";
			// 
			// prenom
			// 
			this.prenom.DataPropertyName = "prenom";
			this.prenom.HeaderText = "Prénom";
			this.prenom.Name = "prenom";
			// 
			// classe
			// 
			this.classe.DataPropertyName = "classe";
			this.classe.HeaderText = "Classe";
			this.classe.Name = "classe";
			// 
			// moyenne
			// 
			this.moyenne.DataPropertyName = "moyenne";
			this.moyenne.HeaderText = "Moyenne";
			this.moyenne.Name = "moyenne";
			// 
			// Nationalité
			// 
			this.Nationalité.DataPropertyName = "nationalite";
			this.Nationalité.HeaderText = "Nationalité";
			this.Nationalité.Name = "Nationalité";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(175, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Liste étudiants";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addButton
			// 
			this.addButton.BackColor = System.Drawing.Color.Black;
			this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addButton.ForeColor = System.Drawing.Color.White;
			this.addButton.Location = new System.Drawing.Point(119, 417);
			this.addButton.Margin = new System.Windows.Forms.Padding(2);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(92, 28);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Ajouter";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// updateButton
			// 
			this.updateButton.BackColor = System.Drawing.Color.Black;
			this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateButton.ForeColor = System.Drawing.Color.White;
			this.updateButton.Location = new System.Drawing.Point(233, 418);
			this.updateButton.Margin = new System.Windows.Forms.Padding(2);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(92, 28);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "Modifier";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.Black;
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteButton.ForeColor = System.Drawing.Color.White;
			this.deleteButton.Location = new System.Drawing.Point(351, 418);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(118, 28);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Supprimer";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.Black;
			this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.ForeColor = System.Drawing.Color.White;
			this.quitButton.Location = new System.Drawing.Point(497, 418);
			this.quitButton.Margin = new System.Windows.Forms.Padding(2);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(92, 28);
			this.quitButton.TabIndex = 5;
			this.quitButton.Text = "Quitter";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
			// 
			// searchBox
			// 
			this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchBox.ForeColor = System.Drawing.Color.MediumBlue;
			this.searchBox.Location = new System.Drawing.Point(214, 69);
			this.searchBox.Margin = new System.Windows.Forms.Padding(2);
			this.searchBox.Multiline = true;
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(221, 32);
			this.searchBox.TabIndex = 6;
			// 
			// Etudiants
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(656, 457);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableauEtudiant);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Etudiants";
			this.Text = "Etudiants";
			this.Load += new System.EventHandler(this.EtudiantsLoad);
			((System.ComponentModel.ISupportInitialize)(this.tableauEtudiant)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
