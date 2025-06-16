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
    public partial class Lekerdez : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Lekerdez()

        {
            InitializeComponent();
        }

        private async void btnFetchAddresses_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Adja meg a várost!");
                return;
            }

            string apiUrl = $"http://localhost:3000/api/radios?city={city}";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var dataTable = ConvertJsonToDataTable(responseBody);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }

        private async void btnFetchRadios_Click(object sender, EventArgs e)
        {
            string location = txtCity.Text;
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Adja meg a várost!");
                return;
            }

            string apiUrl = $"http://localhost:3000/api/radios/from?location={location}";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var dataTable = ConvertJsonToDataTable(responseBody);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }

        private async void btnFetchRadiosWithCityName_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:3000/api/radios/with-city-name";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var dataTable = ConvertJsonToDataTable(responseBody);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
        }

        private DataTable ConvertJsonToDataTable(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentException("The JSON string is null or empty.");
            }

            var dataTable = new DataTable();
            var rows = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);

            if (rows == null || rows.Count == 0)
                return dataTable;

            foreach (var column in rows[0].Keys)
            {
                dataTable.Columns.Add(column);
            }

            foreach (var row in rows)
            {
                var dataRow = dataTable.NewRow();
                foreach (var key in row.Keys)
                {
                    dataRow[key] = row[key];
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void létrehozásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm.ChangeForm(sender, new LetrehozForm());
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
            //MenuForm.ChangeForm(sender, new Lekerdez());
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
