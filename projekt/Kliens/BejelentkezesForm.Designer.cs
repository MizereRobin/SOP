namespace Kliens
{
    partial class BejelentkezesForm
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
            this.logButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.lekérdezésToolStripMenuItem.Text = "Lekérdezés";
            // 
            // létrehozásToolStripMenuItem
            // 
            this.létrehozásToolStripMenuItem.Name = "létrehozásToolStripMenuItem";
            this.létrehozásToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.létrehozásToolStripMenuItem.Text = "Létrehozás";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
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
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(344, 240);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(97, 23);
            this.logButton.TabIndex = 11;
            this.logButton.Text = "Bejelentkezés";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jelszo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Felhasznalo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordText
            // 
            this.passwordText.AcceptsReturn = true;
            this.passwordText.AcceptsTab = true;
            this.passwordText.AllowDrop = true;
            this.passwordText.Location = new System.Drawing.Point(341, 197);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 8;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(341, 142);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 7;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // BejelentkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BejelentkezesForm";
            this.Text = "BejelentkezesForm";
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
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox nameText;
    }
}