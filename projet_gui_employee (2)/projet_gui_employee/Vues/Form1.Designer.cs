
namespace projet_gui_employee
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commissaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmployesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.listeDesEmployesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permamentToolStripMenuItem,
            this.journalierToolStripMenuItem,
            this.commissaireToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // permamentToolStripMenuItem
            // 
            this.permamentToolStripMenuItem.Name = "permamentToolStripMenuItem";
            this.permamentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permamentToolStripMenuItem.Text = "Permament";
            this.permamentToolStripMenuItem.Click += new System.EventHandler(this.permamentToolStripMenuItem_Click);
            // 
            // journalierToolStripMenuItem
            // 
            this.journalierToolStripMenuItem.Name = "journalierToolStripMenuItem";
            this.journalierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.journalierToolStripMenuItem.Text = "Journalier";
            this.journalierToolStripMenuItem.Click += new System.EventHandler(this.journalierToolStripMenuItem_Click);
            // 
            // commissaireToolStripMenuItem
            // 
            this.commissaireToolStripMenuItem.Name = "commissaireToolStripMenuItem";
            this.commissaireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commissaireToolStripMenuItem.Text = "Commissaire";
            this.commissaireToolStripMenuItem.Click += new System.EventHandler(this.commissaireToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // listeDesEmployesToolStripMenuItem
            // 
            this.listeDesEmployesToolStripMenuItem.Name = "listeDesEmployesToolStripMenuItem";
            this.listeDesEmployesToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.listeDesEmployesToolStripMenuItem.Text = "Liste des employes";
            this.listeDesEmployesToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmployesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 624);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commissaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmployesToolStripMenuItem;
    }
}

