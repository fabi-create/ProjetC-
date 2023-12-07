using projet_gui_employee.Vues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gui_employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_permanent_Click(object sender, EventArgs e)
        {
            
        }

        private void permamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPermanentUI
            {
                MdiParent = this,
                Visible = true
            };

        }

        private void journalierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddJournalierUI
            {
                MdiParent = this,
                Visible = true
            };
        }

        private void commissaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCommissaire
            {
                MdiParent = this,
                Visible = true
            };
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeDesEmployesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListeEmployeUI
            {
                MdiParent = this,
                Visible = true
            };
        }
    }
}
