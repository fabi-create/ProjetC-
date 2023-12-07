/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 00:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class FormCommande
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView tableauCommande;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel2;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableauCommande = new System.Windows.Forms.DataGridView();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableauCommande)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IdCommande";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "LibelleCommande";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NomPrenomClient";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TéléphoneClient ";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "EtatCommande";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(227, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(227, 83);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(227, 119);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(121, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(227, 156);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(121, 20);
			this.textBox4.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"0"});
			this.comboBox1.Location = new System.Drawing.Point(227, 199);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(72, 242);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 41);
			this.button1.TabIndex = 10;
			this.button1.Text = "Ajouter une commande";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(72, 300);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(232, 35);
			this.button2.TabIndex = 11;
			this.button2.Text = "Liste";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(42, 58);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 349);
			this.panel1.TabIndex = 12;
			// 
			// tableauCommande
			// 
			this.tableauCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableauCommande.Location = new System.Drawing.Point(3, 41);
			this.tableauCommande.Name = "tableauCommande";
			this.tableauCommande.Size = new System.Drawing.Size(409, 222);
			this.tableauCommande.TabIndex = 13;
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(3, 3);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(409, 20);
			this.searchBox.TabIndex = 14;
			this.searchBox.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// UpdateButton
			// 
			this.UpdateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateButton.Location = new System.Drawing.Point(3, 303);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(83, 35);
			this.UpdateButton.TabIndex = 15;
			this.UpdateButton.Text = "Modifier";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(122, 303);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 35);
			this.button4.TabIndex = 16;
			this.button4.Text = "Supprimer";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(252, 304);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(170, 34);
			this.button5.TabIndex = 17;
			this.button5.Text = "Ajouter des produits ";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.GreenYellow;
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.UpdateButton);
			this.panel2.Controls.Add(this.searchBox);
			this.panel2.Controls.Add(this.tableauCommande);
			this.panel2.Location = new System.Drawing.Point(513, 55);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(425, 351);
			this.panel2.TabIndex = 18;
			this.panel2.Visible = false;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// FormCommande
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(970, 447);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormCommande";
			this.Text = "FormCommande";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableauCommande)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
