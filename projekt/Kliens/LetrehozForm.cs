using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliens
{
    public partial class LetrehozForm : Form
    {
        public LetrehozForm()
        {
            InitializeComponent();
        }

        private void bejelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void létrehozásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MenuForm.ChangeForm(sender, new LetrehozForm());
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm.ChangeForm(sender, new ModositasForm());
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm.ChangeForm(sender, new TorlesForm());
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm.ChangeForm(sender, new Lekerdez());
        }
    }
}
