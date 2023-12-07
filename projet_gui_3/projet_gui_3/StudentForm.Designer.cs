/*
 * Created by SharpDevelop.
 * User: Kodjo
 * Date: 09/08/2023
 * Time: 19:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
{
	partial class StudentForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBoxClasse;
		private System.Windows.Forms.ComboBox comboBoxNationalite;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonValider;
		private System.Windows.Forms.TextBox textBoxMoyenne;
		private System.Windows.Forms.TextBox textBoxNom;
		private System.Windows.Forms.TextBox textBoxPrenom;
		private System.Windows.Forms.TextBox textBoxMatricule;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataTableEtu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttondelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.Button buttonUpdate;
		
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
			this.comboBoxClasse = new System.Windows.Forms.ComboBox();
			this.comboBoxNationalite = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonValider = new System.Windows.Forms.Button();
			this.textBoxMoyenne = new System.Windows.Forms.TextBox();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.textBoxPrenom = new System.Windows.Forms.TextBox();
			this.textBoxMatricule = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataTableEtu = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.labelAge = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttondelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataTableEtu)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxClasse
			// 
			this.comboBoxClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxClasse.FormattingEnabled = true;
			this.comboBoxClasse.Items.AddRange(new object[] {
			"",
			"LTI-1",
			"LTI-2",
			"MP1-ISI",
			"MP2-ISI",
			"MP1-SSI",
			"MP2-SSI"});
			this.comboBoxClasse.Location = new System.Drawing.Point(239, 381);
			this.comboBoxClasse.Name = "comboBoxClasse";
			this.comboBoxClasse.Size = new System.Drawing.Size(272, 37);
			this.comboBoxClasse.TabIndex = 31;
			this.comboBoxClasse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClasseSelectedIndexChanged);
			// 
			// comboBoxNationalite
			// 
			this.comboBoxNationalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxNationalite.FormattingEnabled = true;
			this.comboBoxNationalite.Items.AddRange(new object[] {
			"Sénégalaise",
			"Malienne",
			"Ivoirienne",
			"Nigériane",
			"Ghanéenne"});
			this.comboBoxNationalite.Location = new System.Drawing.Point(240, 498);
			this.comboBoxNationalite.Name = "comboBoxNationalite";
			this.comboBoxNationalite.Size = new System.Drawing.Size(272, 37);
			this.comboBoxNationalite.TabIndex = 30;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(399, 594);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 55);
			this.button2.TabIndex = 29;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// buttonValider
			// 
			this.buttonValider.BackColor = System.Drawing.Color.Green;
			this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonValider.ForeColor = System.Drawing.Color.White;
			this.buttonValider.Location = new System.Drawing.Point(253, 595);
			this.buttonValider.Name = "buttonValider";
			this.buttonValider.Size = new System.Drawing.Size(130, 55);
			this.buttonValider.TabIndex = 28;
			this.buttonValider.Text = "Valider";
			this.buttonValider.UseVisualStyleBackColor = false;
			this.buttonValider.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBoxMoyenne
			// 
			this.textBoxMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMoyenne.Location = new System.Drawing.Point(239, 440);
			this.textBoxMoyenne.Name = "textBoxMoyenne";
			this.textBoxMoyenne.Size = new System.Drawing.Size(273, 35);
			this.textBoxMoyenne.TabIndex = 27;
			// 
			// textBoxNom
			// 
			this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNom.Location = new System.Drawing.Point(238, 200);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(273, 35);
			this.textBoxNom.TabIndex = 26;
			// 
			// textBoxPrenom
			// 
			this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrenom.Location = new System.Drawing.Point(238, 261);
			this.textBoxPrenom.Name = "textBoxPrenom";
			this.textBoxPrenom.Size = new System.Drawing.Size(273, 35);
			this.textBoxPrenom.TabIndex = 25;
			// 
			// textBoxMatricule
			// 
			this.textBoxMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMatricule.Location = new System.Drawing.Point(239, 144);
			this.textBoxMatricule.Name = "textBoxMatricule";
			this.textBoxMatricule.Size = new System.Drawing.Size(273, 35);
			this.textBoxMatricule.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(40, 501);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 41);
			this.label7.TabIndex = 23;
			this.label7.Text = "Nationalité";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(42, 446);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 29);
			this.label6.TabIndex = 22;
			this.label6.Text = "Moyenne";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(42, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 37);
			this.label5.TabIndex = 21;
			this.label5.Text = "Classe";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(42, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Prenom";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Nom";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 30);
			this.label2.TabIndex = 18;
			this.label2.Text = "Matricule";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(51, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 49);
			this.label1.TabIndex = 17;
			this.label1.Text = "Formulaire";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataTableEtu);
			this.panel1.Location = new System.Drawing.Point(709, 137);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 405);
			this.panel1.TabIndex = 32;
			// 
			// dataTableEtu
			// 
			this.dataTableEtu.AllowUserToOrderColumns = true;
			this.dataTableEtu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataTableEtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTableEtu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataTableEtu.Location = new System.Drawing.Point(0, 0);
			this.dataTableEtu.Name = "dataTableEtu";
			this.dataTableEtu.RowTemplate.Height = 28;
			this.dataTableEtu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataTableEtu.Size = new System.Drawing.Size(664, 405);
			this.dataTableEtu.TabIndex = 0;
			this.dataTableEtu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(708, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 35);
			this.label8.TabIndex = 33;
			this.label8.Text = "Recherche";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.buttonUpdate);
			this.panel2.Controls.Add(this.textBoxAge);
			this.panel2.Controls.Add(this.labelAge);
			this.panel2.Controls.Add(this.comboBoxClasse);
			this.panel2.Controls.Add(this.comboBoxNationalite);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.buttonValider);
			this.panel2.Controls.Add(this.textBoxMoyenne);
			this.panel2.Controls.Add(this.textBoxNom);
			this.panel2.Controls.Add(this.textBoxPrenom);
			this.panel2.Controls.Add(this.textBoxMatricule);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(630, 684);
			this.panel2.TabIndex = 34;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Green;
			this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.ForeColor = System.Drawing.Color.White;
			this.buttonUpdate.Location = new System.Drawing.Point(104, 595);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(130, 55);
			this.buttonUpdate.TabIndex = 34;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = false;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// textBoxAge
			// 
			this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAge.Location = new System.Drawing.Point(238, 316);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(273, 35);
			this.textBoxAge.TabIndex = 33;
			// 
			// labelAge
			// 
			this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAge.Location = new System.Drawing.Point(42, 319);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(100, 39);
			this.labelAge.TabIndex = 32;
			this.labelAge.Text = "Age";
			this.labelAge.Click += new System.EventHandler(this.Label10Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(896, 77);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(270, 39);
			this.textBoxSearch.TabIndex = 35;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
			// 
			// buttondelete
			// 
			this.buttondelete.BackColor = System.Drawing.Color.Red;
			this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttondelete.ForeColor = System.Drawing.Color.White;
			this.buttondelete.Location = new System.Drawing.Point(1136, 562);
			this.buttondelete.Name = "buttondelete";
			this.buttondelete.Size = new System.Drawing.Size(176, 64);
			this.buttondelete.TabIndex = 36;
			this.buttondelete.Text = "Supprimer";
			this.buttondelete.UseVisualStyleBackColor = false;
			this.buttondelete.Click += new System.EventHandler(this.Button3Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.Location = new System.Drawing.Point(976, 563);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(154, 64);
			this.buttonEdit.TabIndex = 37;
			this.buttonEdit.Text = "Modifier";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.Button4Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(1392, 369);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 23);
			this.label9.TabIndex = 38;
			this.label9.Click += new System.EventHandler(this.Label9Click);
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1438, 684);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttondelete);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.panel1);
			this.Name = "StudentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentForm";
			this.Load += new System.EventHandler(this.StudentFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataTableEtu)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
