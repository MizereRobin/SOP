namespace Kliens
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.opciókToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
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
            this.bejelentkezésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bejelentkezésToolStripMenuItem.Text = "Bejelentkezés";
            this.bejelentkezésToolStripMenuItem.Click += new System.EventHandler(this.bejelentkezésToolStripMenuItem_Click);
            // 
            // regisztrációToolStripMenuItem
            // 
            this.regisztrációToolStripMenuItem.Name = "regisztrációToolStripMenuItem";
            this.regisztrációToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regisztrációToolStripMenuItem.Text = "Regisztráció";
            this.regisztrációToolStripMenuItem.Click += new System.EventHandler(this.regisztrációToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}