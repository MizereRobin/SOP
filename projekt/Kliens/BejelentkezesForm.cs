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
    public partial class BejelentkezesForm : Form
    {
        public BejelentkezesForm()
        {
            InitializeComponent();
            módosításToolStripMenuItem.Available = false;
            törlésToolStripMenuItem.Available = false;
            lekérdezésToolStripMenuItem.Available = false;
            opciókToolStripMenuItem.Available = false;
            
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            label1.Text = passwordText.Text;
            if (nameText.Text.ToString() == Program.user.Name.ToString())
            {
                logButton.Text = "első jó";
                if (passwordText.Text == Program.user.Password)
                {

                    Program.user.IsAuth = true;
                    this.Close();
                }
            }
            else
            {
                label2.Text = "valami nem jó";
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
