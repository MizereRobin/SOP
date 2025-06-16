namespace Kliens
{
    partial class Lekerdez
    {
        /// <summary>
        /// Kötelező tervezői változó.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Felhasznált erőforrások felszabadítása.
        /// </summary>
        /// <param name="disposing">Igaz, ha az erőforrásokat fel kell szabadítani; különben hamis.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer által generált kód

        /// <summary>
        /// A következő metódus szükséges a tervező támogatásához.
        /// A kódszerkesztővel módosítani lehet a metódus tartalmát.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnFetchAddresses = new System.Windows.Forms.Button();
            this.btnFetchRadios = new System.Windows.Forms.Button();
            this.btnFetchRadiosWithCityName = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opciókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.létrehozásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bejelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisztrációToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 145);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 20);
            this.txtCity.TabIndex = 0;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // btnFetchAddresses
            // 
            this.btnFetchAddresses.Location = new System.Drawing.Point(12, 172);
            this.btnFetchAddresses.Name = "btnFetchAddresses";
            this.btnFetchAddresses.Size = new System.Drawing.Size(120, 23);
            this.btnFetchAddresses.TabIndex = 1;
            this.btnFetchAddresses.Text = "Sugárzási helyek";
            this.btnFetchAddresses.UseVisualStyleBackColor = true;
            this.btnFetchAddresses.Click += new System.EventHandler(this.btnFetchAddresses_Click);
            // 
            // btnFetchRadios
            // 
            this.btnFetchRadios.Location = new System.Drawing.Point(12, 202);
            this.btnFetchRadios.Name = "btnFetchRadios";
            this.btnFetchRadios.Size = new System.Drawing.Size(120, 23);
            this.btnFetchRadios.TabIndex = 2;
            this.btnFetchRadios.Text = "Rádiók (teljesítmény)";
            this.btnFetchRadios.UseVisualStyleBackColor = true;
            this.btnFetchRadios.Click += new System.EventHandler(this.btnFetchRadios_Click);
            // 
            // btnFetchRadiosWithCityName
            // 
            this.btnFetchRadiosWithCityName.Location = new System.Drawing.Point(12, 232);
            this.btnFetchRadiosWithCityName.Name = "btnFetchRadiosWithCityName";
            this.btnFetchRadiosWithCityName.Size = new System.Drawing.Size(120, 23);
            this.btnFetchRadiosWithCityName.TabIndex = 3;
            this.btnFetchRadiosWithCityName.Text = "Rádiók (város)";
            this.btnFetchRadiosWithCityName.UseVisualStyleBackColor = true;
            this.btnFetchRadiosWithCityName.Click += new System.EventHandler(this.btnFetchRadiosWithCityName_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.opciókToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(610, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // opciókToolStripMenuItem
            // 
            this.opciókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekérdezésToolStripMenuItem,
            this.létrehozásToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.opciókToolStripMenuItem.Name = "opciókToolStripMenuItem";
            this.opciókToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opciókToolStripMenuItem.Text = "opciók";
            // 
            // lekérdezésToolStripMenuItem
            // 
            this.lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lekérdezésToolStripMenuItem.Text = "Lekérdezés";
            this.lekérdezésToolStripMenuItem.Click += new System.EventHandler(this.lekérdezésToolStripMenuItem_Click);
            // 
            // létrehozásToolStripMenuItem
            // 
            this.létrehozásToolStripMenuItem.Name = "létrehozásToolStripMenuItem";
            this.létrehozásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.létrehozásToolStripMenuItem.Text = "Létrehozás";
            this.létrehozásToolStripMenuItem.Click += new System.EventHandler(this.létrehozásToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // felhasználóToolStripMenuItem
            // 
            this.felhasználóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bejelentkezésToolStripMenuItem,
            this.regisztrációToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.felhasználóToolStripMenuItem.Name = "felhasználóToolStripMenuItem";
            this.felhasználóToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.felhasználóToolStripMenuItem.Text = "Felhasználó";
            // 
            // bejelentkezésToolStripMenuItem
            // 
            this.bejelentkezésToolStripMenuItem.Name = "bejelentkezésToolStripMenuItem";
            this.bejelentkezésToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bejelentkezésToolStripMenuItem.Text = "Bejelentkezés";
            // 
            // regisztrációToolStripMenuItem
            // 
            this.regisztrációToolStripMenuItem.Name = "regisztrációToolStripMenuItem";
            this.regisztrációToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.regisztrációToolStripMenuItem.Text = "Regisztráció";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Lekerdez
            // 
            this.ClientSize = new System.Drawing.Size(610, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnFetchRadiosWithCityName);
            this.Controls.Add(this.btnFetchRadios);
            this.Controls.Add(this.btnFetchAddresses);
            this.Controls.Add(this.txtCity);
            this.Name = "Lekerdez";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnFetchAddresses;
        private System.Windows.Forms.Button btnFetchRadios;
        private System.Windows.Forms.Button btnFetchRadiosWithCityName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opciókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem létrehozásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bejelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regisztrációToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

