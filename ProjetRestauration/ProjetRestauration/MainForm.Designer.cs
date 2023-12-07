/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 12/08/2023
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetRestauration
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox motdepasse;
		private System.Windows.Forms.ComboBox UserType;
		private System.Windows.Forms.Button connection;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.TextBox();
			this.motdepasse = new System.Windows.Forms.TextBox();
			this.UserType = new System.Windows.Forms.ComboBox();
			this.connection = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(164, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(164, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(164, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type User";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(347, 223);
			this.login.Multiline = true;
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(127, 20);
			this.login.TabIndex = 3;
			this.login.TextChanged += new System.EventHandler(this.LoginTextChanged);
			// 
			// motdepasse
			// 
			this.motdepasse.Location = new System.Drawing.Point(347, 269);
			this.motdepasse.Multiline = true;
			this.motdepasse.Name = "motdepasse";
			this.motdepasse.Size = new System.Drawing.Size(127, 22);
			this.motdepasse.TabIndex = 4;
			this.motdepasse.UseSystemPasswordChar = true;
			this.motdepasse.TextChanged += new System.EventHandler(this.MotdepasseTextChanged);
			// 
			// UserType
			// 
			this.UserType.FormattingEnabled = true;
			this.UserType.Items.AddRange(new object[] {
			"Administrateur",
			"ChefCuisinier",
			"Restaurateur"});
			this.UserType.Location = new System.Drawing.Point(347, 314);
			this.UserType.Name = "UserType";
			this.UserType.Size = new System.Drawing.Size(127, 21);
			this.UserType.TabIndex = 5;
			this.UserType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// connection
			// 
			this.connection.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connection.Location = new System.Drawing.Point(172, 381);
			this.connection.Name = "connection";
			this.connection.Size = new System.Drawing.Size(138, 33);
			this.connection.TabIndex = 6;
			this.connection.Text = "Se connecter";
			this.connection.UseVisualStyleBackColor = false;
			this.connection.Click += new System.EventHandler(this.ConnectionClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(338, 381);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 33);
			this.button2.TabIndex = 7;
			this.button2.Text = "Quitter";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(172, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(303, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(329, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "ACCUEIL RESTAURATION";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(531, 77);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(310, 337);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(952, 426);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.connection);
			this.Controls.Add(this.UserType);
			this.Controls.Add(this.motdepasse);
			this.Controls.Add(this.login);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ProjetRestauration";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
