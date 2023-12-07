/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 21/08/2023
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class ListeCommandes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView tableauValidation;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxPrixProduit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label8;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tableauValidation = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.textBoxPrixProduit = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableauValidation)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.searchBox);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.tableauValidation);
			this.panel1.Location = new System.Drawing.Point(393, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(580, 417);
			this.panel1.TabIndex = 14;
			this.panel1.Visible = false;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(281, 368);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(170, 23);
			this.button5.TabIndex = 18;
			this.button5.Text = "passer au paiement";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(457, 368);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(100, 20);
			this.searchBox.TabIndex = 17;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(99, 368);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(176, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "Annuler la validation";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(18, 368);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "Valider";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// tableauValidation
			// 
			this.tableauValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableauValidation.Location = new System.Drawing.Point(57, 36);
			this.tableauValidation.Name = "tableauValidation";
			this.tableauValidation.Size = new System.Drawing.Size(471, 254);
			this.tableauValidation.TabIndex = 13;
			this.tableauValidation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableauValidationCellContentClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id libelleCommande";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "etatCommande";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = " Id libelleProduit";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "quantite Commander";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 398);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 35);
			this.button1.TabIndex = 4;
			this.button1.Text = "Ajouter le produit";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(206, 129);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(206, 216);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 7;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(206, 261);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"0"});
			this.comboBox2.Location = new System.Drawing.Point(206, 174);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 305);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "IdRestaurateur";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(206, 305);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 21);
			this.comboBox4.TabIndex = 11;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4SelectedIndexChanged);
			// 
			// textBoxPrixProduit
			// 
			this.textBoxPrixProduit.Location = new System.Drawing.Point(206, 352);
			this.textBoxPrixProduit.Name = "textBoxPrixProduit";
			this.textBoxPrixProduit.Size = new System.Drawing.Size(121, 20);
			this.textBoxPrixProduit.TabIndex = 15;
			this.textBoxPrixProduit.TextChanged += new System.EventHandler(this.TextBoxPrixProduitTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 349);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Prix unitaire ";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(178, 439);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 17;
			this.button2.Text = "Retour";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(188, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "id Liste Commande";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(206, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(123, 20);
			this.textBox2.TabIndex = 19;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(233, 398);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(123, 35);
			this.button6.TabIndex = 20;
			this.button6.Text = "validation ";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(48, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(264, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Ajout d\'un produit a une commande";
			// 
			// ListeCommandes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(994, 471);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxPrixProduit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ListeCommandes";
			this.Text = "ListeCommandes";
			this.Load += new System.EventHandler(this.ListeCommandesLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableauValidation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
