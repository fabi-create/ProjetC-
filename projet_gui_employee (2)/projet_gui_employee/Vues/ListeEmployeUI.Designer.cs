
namespace projet_gui_employee.Vues
{
    partial class ListeEmployeUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_actualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_actualiser
            // 
            this.button_actualiser.BackColor = System.Drawing.Color.DarkGreen;
            this.button_actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actualiser.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualiser.ForeColor = System.Drawing.Color.Transparent;
            this.button_actualiser.Location = new System.Drawing.Point(340, 390);
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.Size = new System.Drawing.Size(122, 32);
            this.button_actualiser.TabIndex = 1;
            this.button_actualiser.Text = "Actualiser";
            this.button_actualiser.UseVisualStyleBackColor = false;
            this.button_actualiser.Click += new System.EventHandler(this.button_actualiser_Click);
            // 
            // ListeEmployeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 482);
            this.Controls.Add(this.button_actualiser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeEmployeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeEmployeUI";
            this.Load += new System.EventHandler(this.ListeEmployeUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_actualiser;
    }
}