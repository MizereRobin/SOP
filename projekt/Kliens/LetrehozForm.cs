using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliens
{
    public partial class LetrehozForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static List<string> LekerdezList = new List<string>();
        public async void Lekerdez(string mit) 
        { 
            List<string> list = new List<string>();

            string apiUrl = $"http://localhost:3000/{mit}";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                string text = responseBody;

                text = text.Replace("[","").Replace("]","").Replace("\"","");
                list = text.Split(',').ToList<string>();
                MessageBox.Show("Sikerült dik\n"+list.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
            LekerdezList=list;
        }
        public LetrehozForm()
        {
            InitializeComponent();
            if (AuthState.Token != null)
            {
                labelBejelentkezve.Text = "Bejelentkezve";
                labelBejelentkezve.BackColor = Color.Green;
            }
            else
            {
                labelBejelentkezve.Text = "Nincs Bejelentkezve";
                labelBejelentkezve.BackColor = Color.PaleVioletRed;
            }
            Lekerdez("megyek");
            Thread.Sleep(200);
            MessageBox.Show("");
            comboBoxMegye.DataSource = LekerdezList;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTelepulesHozzaad_Click(object sender, EventArgs e)
        {

        }

        private void buttonKiosztasHozzaad_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMegye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
