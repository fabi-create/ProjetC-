/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 24/08/2023
 * Time: 00:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class Produits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button QuitButton;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.DataGridView tableauProduit;
		
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
			this.QuitButton = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.tableauProduit = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.tableauProduit)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddButton.Location = new System.Drawing.Point(74, 328);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 24);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = " Ajouter";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// UpdateButton
			// 
			this.UpdateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateButton.Location = new System.Drawing.Point(168, 328);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(83, 24);
			this.UpdateButton.TabIndex = 2;
			this.UpdateButton.Text = "Modifier";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Location = new System.Drawing.Point(278, 325);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(95, 27);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "Supprimer";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
			// 
			// QuitButton
			// 
			this.QuitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuitButton.Location = new System.Drawing.Point(392, 328);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(75, 24);
			this.QuitButton.TabIndex = 4;
			this.QuitButton.Text = "Quitter";
			this.QuitButton.UseVisualStyleBackColor = false;
			this.QuitButton.Click += new System.EventHandler(this.QuitButtonClick);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(490, 328);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "Retour";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(203, 61);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(237, 20);
			this.searchBox.TabIndex = 6;
			// 
			// tableauProduit
			// 
			this.tableauProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableauProduit.Location = new System.Drawing.Point(74, 119);
			this.tableauProduit.Name = "tableauProduit";
			this.tableauProduit.Size = new System.Drawing.Size(491, 150);
			this.tableauProduit.TabIndex = 7;
			// 
			// Produits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(751, 377);
			this.Controls.Add(this.tableauProduit);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.AddButton);
			this.Name = "Produits";
			this.Text = "Produits";
			((System.ComponentModel.ISupportInitialize)(this.tableauProduit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
