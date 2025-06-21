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
    public partial class MenuForm : Form
    {
        public static void ChangeForm(object sender, Form newform)
        {
            Form activeform = ActiveForm;
            if (activeform.Name != "MenuForm")
            {
                if (newform is Lekerdez || newform is BejelentkezesForm || newform is RegisztracioForm)
                {
                    activeform.Hide();
                    Form newf = newform;
                    newf.Show();
                }
                else
                {
                    activeform.Hide();
                    Form newf = new BejelentkezesForm();
                    newf.Show();
                }
            }
        }
        public MenuForm()
        {
            InitializeComponent();
            menüToolStripMenuItem.Enabled = false;
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lekerdez lekerdez = new Lekerdez(this);
            lekerdez.Show();
            //this.Show();
        }

        private void létrehozásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.user.IsAuth)
            {
                LetrehozForm l = new LetrehozForm();
                l.Show();
            }
            else
            {
                Form newf = new BejelentkezesForm();
                newf.Show(); ;
            }
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.user.IsAuth)
            {
                ModositasForm l = new ModositasForm();
                l.Show();
            }
            else
            {
                Form newf = new BejelentkezesForm();
                newf.Show(); ;
            }
            
            
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.user.IsAuth)
            {
                TorlesForm l = new TorlesForm();
                l.Show();
            }
            else
            {
                Form newf = new BejelentkezesForm();
                newf.Show(); ;
            }

            
        }

        private void bejelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BejelentkezesForm b = new BejelentkezesForm();
                b.Show();
        }

        private void regisztrációToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisztracioForm r = new RegisztracioForm();
            r.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.user.IsAuth = false;
        }
    }
}
