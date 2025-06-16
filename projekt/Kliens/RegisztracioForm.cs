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
    public partial class RegisztracioForm : Form
    {
        public RegisztracioForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text != null && passwordText.Text != null) ;
            Program.user.Name = nameText.Text;
            Program.user.Password = passwordText.Text;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
