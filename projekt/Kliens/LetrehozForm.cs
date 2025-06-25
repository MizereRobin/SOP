using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Kliens
{
    public partial class LetrehozForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public LetrehozForm()
        {
            InitializeComponent();

            if (AuthState.Token != null)
            {
                labelBejelentkezve.Text = "Bejelentkezve";
                labelBejelentkezve.BackColor = Color.Green;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthState.Token);
            }
            else
            {
                labelBejelentkezve.Text = "Nincs Bejelentkezve";
                labelBejelentkezve.BackColor = Color.PaleVioletRed;
            }

            comboBoxMegye.DropDown += ComboBoxMegye_DropDown;
            comboBoxAdohely.DropDown += ComboBoxAdohely_DropDown;
        }

        private async void ComboBoxMegye_DropDown(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetAsync("http://localhost:3000/megyek");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var megyek = json.Replace("[","").Replace("]","").Replace("\"","").Split(',').ToList<string>();
                comboBoxMegye.DataSource = megyek;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba: {ex.Message}");
            }
        }

        private async void ComboBoxAdohely_DropDown(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetAsync("http://localhost:3000/telepulesnev");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var telepulesek = json.Replace("[", "").Replace("]", "").Replace("\"", "").Split(',').ToList<string>();
                comboBoxAdohely.DataSource = telepulesek;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba: {ex.Message}");
            }
        }

        private void bejelentkezésToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void létrehozásToolStripMenuItem_Click(object sender, EventArgs e) { }

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

        private void buttonTelepulesHozzaad_Click(object sender, EventArgs e) 
        {
            string adat = $"{textBoxTelepulesNev.Text}!{comboBoxMegye.SelectedText}";

            // POST ide: .../addtelepules az adat változót kell átadni neki

        }

        private void buttonKiosztasHozzaad_Click(object sender, EventArgs e) 
        {
            //Formátum: frekvencia!csatorna!teljesitmeny!adohely!cim
            string adat = $"{textBoxFrekvencia.Text}!{textBoxCsatorna.Text}!{textBoxTeljesimeny.Text}!{comboBoxAdohely.SelectedText}!{textBoxCim.Text}";
        
        }

        private void comboBoxMegye_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Frissit(object sender, EventArgs e)
        {
            comboBoxMegye.DataSource = null;
            comboBoxAdohely.DataSource = null;
        }
    }
}