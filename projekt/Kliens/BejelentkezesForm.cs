using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

        private async void regButton_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var loginData = new
            {
                username = nameText.Text,
                password = passwordText.Text
            };

            string json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync("http://localhost:3000/login", content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var tokenObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseBody);
                AuthState.Token = tokenObj["token"];

                MessageBox.Show("Sikeres bejelentkezés.");
                this.Hide();
                new MenuForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
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
