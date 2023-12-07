/*
 * Created by SharpDevelop.
 * User: Yvan GBAFFONOU
 * Date: 04/08/2023
 * Time: 08:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet_gui_3
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
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.Label errorLabel;
		
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
			this.loginBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.connectButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(167, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Authentification";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 100);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(69, 178);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loginBox
			// 
			this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBox.Location = new System.Drawing.Point(220, 109);
			this.loginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginBox.MaximumSize = new System.Drawing.Size(151, 33);
			this.loginBox.MinimumSize = new System.Drawing.Size(76, 21);
			this.loginBox.Multiline = true;
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(140, 23);
			this.loginBox.TabIndex = 3;
			// 
			// passwordBox
			// 
			this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordBox.Location = new System.Drawing.Point(220, 184);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.passwordBox.Multiline = true;
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(140, 23);
			this.passwordBox.TabIndex = 4;
			// 
			// connectButton
			// 
			this.connectButton.BackColor = System.Drawing.Color.ForestGreen;
			this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectButton.ForeColor = System.Drawing.Color.White;
			this.connectButton.Location = new System.Drawing.Point(108, 241);
			this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(106, 29);
			this.connectButton.TabIndex = 5;
			this.connectButton.Text = "Se connecter";
			this.connectButton.UseVisualStyleBackColor = false;
			this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.Color.Red;
			this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.ForeColor = System.Drawing.Color.White;
			this.quitButton.Location = new System.Drawing.Point(253, 241);
			this.quitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(106, 29);
			this.quitButton.TabIndex = 6;
			this.quitButton.Text = "Quitter";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
			// 
			// errorLabel
			// 
			this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLabel.ForeColor = System.Drawing.Color.Black;
			this.errorLabel.Location = new System.Drawing.Point(108, 288);
			this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(252, 38);
			this.errorLabel.TabIndex = 9;
			this.errorLabel.Text = "Login ou Password incorrect";
			this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.errorLabel.Visible = false;
			this.errorLabel.Click += new System.EventHandler(this.ErrorLabelClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 346);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "projet_gui_3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
