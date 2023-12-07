
namespace ChangeDevises
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1_euro = new System.Windows.Forms.RadioButton();
            this.radioButton2_dollar = new System.Windows.Forms.RadioButton();
            this.radioButton3_cfa = new System.Windows.Forms.RadioButton();
            this.radioButton4_yen = new System.Windows.Forms.RadioButton();
            this.radioButton5_uae = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_montant = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_uae = new System.Windows.Forms.RadioButton();
            this.radioButton_yen = new System.Windows.Forms.RadioButton();
            this.radioButton_cfa = new System.Windows.Forms.RadioButton();
            this.radioButton_dollar = new System.Windows.Forms.RadioButton();
            this.radioButton_euro = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_resultat = new System.Windows.Forms.TextBox();
            this.textBox_effacer = new System.Windows.Forms.Button();
            this.button1_quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Devises";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5_uae);
            this.groupBox1.Controls.Add(this.radioButton4_yen);
            this.groupBox1.Controls.Add(this.radioButton3_cfa);
            this.groupBox1.Controls.Add(this.radioButton2_dollar);
            this.groupBox1.Controls.Add(this.radioButton1_euro);
            this.groupBox1.Location = new System.Drawing.Point(50, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1_euro
            // 
            this.radioButton1_euro.AutoSize = true;
            this.radioButton1_euro.Location = new System.Drawing.Point(18, 46);
            this.radioButton1_euro.Name = "radioButton1_euro";
            this.radioButton1_euro.Size = new System.Drawing.Size(68, 24);
            this.radioButton1_euro.TabIndex = 0;
            this.radioButton1_euro.TabStop = true;
            this.radioButton1_euro.Text = "Euro";
            this.radioButton1_euro.UseVisualStyleBackColor = true;
            // 
            // radioButton2_dollar
            // 
            this.radioButton2_dollar.AutoSize = true;
            this.radioButton2_dollar.Location = new System.Drawing.Point(186, 46);
            this.radioButton2_dollar.Name = "radioButton2_dollar";
            this.radioButton2_dollar.Size = new System.Drawing.Size(75, 24);
            this.radioButton2_dollar.TabIndex = 1;
            this.radioButton2_dollar.TabStop = true;
            this.radioButton2_dollar.Text = "Dollar";
            this.radioButton2_dollar.UseVisualStyleBackColor = true;
            // 
            // radioButton3_cfa
            // 
            this.radioButton3_cfa.AutoSize = true;
            this.radioButton3_cfa.Location = new System.Drawing.Point(383, 46);
            this.radioButton3_cfa.Name = "radioButton3_cfa";
            this.radioButton3_cfa.Size = new System.Drawing.Size(66, 24);
            this.radioButton3_cfa.TabIndex = 2;
            this.radioButton3_cfa.TabStop = true;
            this.radioButton3_cfa.Text = "CFA";
            this.radioButton3_cfa.UseVisualStyleBackColor = true;
            // 
            // radioButton4_yen
            // 
            this.radioButton4_yen.AutoSize = true;
            this.radioButton4_yen.Location = new System.Drawing.Point(522, 46);
            this.radioButton4_yen.Name = "radioButton4_yen";
            this.radioButton4_yen.Size = new System.Drawing.Size(67, 24);
            this.radioButton4_yen.TabIndex = 3;
            this.radioButton4_yen.TabStop = true;
            this.radioButton4_yen.Text = "YEN";
            this.radioButton4_yen.UseVisualStyleBackColor = true;
            this.radioButton4_yen.CheckedChanged += new System.EventHandler(this.radioButton4_yen_CheckedChanged);
            // 
            // radioButton5_uae
            // 
            this.radioButton5_uae.AutoSize = true;
            this.radioButton5_uae.Location = new System.Drawing.Point(676, 46);
            this.radioButton5_uae.Name = "radioButton5_uae";
            this.radioButton5_uae.Size = new System.Drawing.Size(68, 24);
            this.radioButton5_uae.TabIndex = 4;
            this.radioButton5_uae.TabStop = true;
            this.radioButton5_uae.Text = "UAE";
            this.radioButton5_uae.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant";
            // 
            // textBox_montant
            // 
            this.textBox_montant.Location = new System.Drawing.Point(378, 280);
            this.textBox_montant.Name = "textBox_montant";
            this.textBox_montant.Size = new System.Drawing.Size(250, 26);
            this.textBox_montant.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_uae);
            this.groupBox2.Controls.Add(this.radioButton_yen);
            this.groupBox2.Controls.Add(this.radioButton_cfa);
            this.groupBox2.Controls.Add(this.radioButton_dollar);
            this.groupBox2.Controls.Add(this.radioButton_euro);
            this.groupBox2.Location = new System.Drawing.Point(68, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_uae
            // 
            this.radioButton_uae.AutoSize = true;
            this.radioButton_uae.Location = new System.Drawing.Point(676, 46);
            this.radioButton_uae.Name = "radioButton_uae";
            this.radioButton_uae.Size = new System.Drawing.Size(68, 24);
            this.radioButton_uae.TabIndex = 4;
            this.radioButton_uae.TabStop = true;
            this.radioButton_uae.Text = "UAE";
            this.radioButton_uae.UseVisualStyleBackColor = true;
            this.radioButton_uae.CheckedChanged += new System.EventHandler(this.radioButton_uae_CheckedChanged);
            // 
            // radioButton_yen
            // 
            this.radioButton_yen.AutoSize = true;
            this.radioButton_yen.Location = new System.Drawing.Point(522, 46);
            this.radioButton_yen.Name = "radioButton_yen";
            this.radioButton_yen.Size = new System.Drawing.Size(67, 24);
            this.radioButton_yen.TabIndex = 3;
            this.radioButton_yen.TabStop = true;
            this.radioButton_yen.Text = "YEN";
            this.radioButton_yen.UseVisualStyleBackColor = true;
            this.radioButton_yen.CheckedChanged += new System.EventHandler(this.radioButton_yen_CheckedChanged);
            // 
            // radioButton_cfa
            // 
            this.radioButton_cfa.AutoSize = true;
            this.radioButton_cfa.Location = new System.Drawing.Point(383, 46);
            this.radioButton_cfa.Name = "radioButton_cfa";
            this.radioButton_cfa.Size = new System.Drawing.Size(66, 24);
            this.radioButton_cfa.TabIndex = 2;
            this.radioButton_cfa.TabStop = true;
            this.radioButton_cfa.Text = "CFA";
            this.radioButton_cfa.UseVisualStyleBackColor = true;
            this.radioButton_cfa.CheckedChanged += new System.EventHandler(this.radioButton_cfa_CheckedChanged);
            // 
            // radioButton_dollar
            // 
            this.radioButton_dollar.AutoSize = true;
            this.radioButton_dollar.Location = new System.Drawing.Point(186, 46);
            this.radioButton_dollar.Name = "radioButton_dollar";
            this.radioButton_dollar.Size = new System.Drawing.Size(75, 24);
            this.radioButton_dollar.TabIndex = 1;
            this.radioButton_dollar.TabStop = true;
            this.radioButton_dollar.Text = "Dollar";
            this.radioButton_dollar.UseVisualStyleBackColor = true;
            this.radioButton_dollar.CheckedChanged += new System.EventHandler(this.radioButton_dollar_CheckedChanged);
            // 
            // radioButton_euro
            // 
            this.radioButton_euro.AutoSize = true;
            this.radioButton_euro.Location = new System.Drawing.Point(18, 46);
            this.radioButton_euro.Name = "radioButton_euro";
            this.radioButton_euro.Size = new System.Drawing.Size(68, 24);
            this.radioButton_euro.TabIndex = 0;
            this.radioButton_euro.TabStop = true;
            this.radioButton_euro.Text = "Euro";
            this.radioButton_euro.UseVisualStyleBackColor = true;
            this.radioButton_euro.CheckedChanged += new System.EventHandler(this.radioButton_euro_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Résultat";
            // 
            // textBox1_resultat
            // 
            this.textBox1_resultat.Enabled = false;
            this.textBox1_resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_resultat.Location = new System.Drawing.Point(378, 560);
            this.textBox1_resultat.Name = "textBox1_resultat";
            this.textBox1_resultat.Size = new System.Drawing.Size(250, 32);
            this.textBox1_resultat.TabIndex = 7;
            // 
            // textBox_effacer
            // 
            this.textBox_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_effacer.Location = new System.Drawing.Point(196, 648);
            this.textBox_effacer.Name = "textBox_effacer";
            this.textBox_effacer.Size = new System.Drawing.Size(115, 45);
            this.textBox_effacer.TabIndex = 8;
            this.textBox_effacer.Text = "Effacer";
            this.textBox_effacer.UseVisualStyleBackColor = true;
            this.textBox_effacer.Click += new System.EventHandler(this.textBox_effacer_Click);
            // 
            // button1_quitter
            // 
            this.button1_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_quitter.Location = new System.Drawing.Point(601, 648);
            this.button1_quitter.Name = "button1_quitter";
            this.button1_quitter.Size = new System.Drawing.Size(123, 45);
            this.button1_quitter.TabIndex = 9;
            this.button1_quitter.Text = "Quitter";
            this.button1_quitter.UseVisualStyleBackColor = true;
            this.button1_quitter.Click += new System.EventHandler(this.button1_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 824);
            this.Controls.Add(this.button1_quitter);
            this.Controls.Add(this.textBox_effacer);
            this.Controls.Add(this.textBox1_resultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_montant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2_dollar;
        private System.Windows.Forms.RadioButton radioButton1_euro;
        private System.Windows.Forms.RadioButton radioButton5_uae;
        private System.Windows.Forms.RadioButton radioButton4_yen;
        private System.Windows.Forms.RadioButton radioButton3_cfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_montant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_uae;
        private System.Windows.Forms.RadioButton radioButton_yen;
        private System.Windows.Forms.RadioButton radioButton_cfa;
        private System.Windows.Forms.RadioButton radioButton_dollar;
        private System.Windows.Forms.RadioButton radioButton_euro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_resultat;
        private System.Windows.Forms.Button textBox_effacer;
        private System.Windows.Forms.Button button1_quitter;
    }
}

