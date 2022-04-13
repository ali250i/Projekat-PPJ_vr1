namespace Projekat_PPJ
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAzuriranjeKupca = new System.Windows.Forms.Button();
            this.buttonKreiranjeKupca = new System.Windows.Forms.Button();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxKorisničkoIme = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.textBoxPretragaPrezime = new System.Windows.Forms.TextBox();
            this.textBoxPretragaIme = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonObrisiKupca = new System.Windows.Forms.Button();
            this.buttonOsvjezi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOsvjezi);
            this.groupBox1.Controls.Add(this.buttonObrisiKupca);
            this.groupBox1.Controls.Add(this.buttonAzuriranjeKupca);
            this.groupBox1.Controls.Add(this.buttonKreiranjeKupca);
            this.groupBox1.Controls.Add(this.textBoxSifra);
            this.groupBox1.Controls.Add(this.textBoxKorisničkoIme);
            this.groupBox1.Controls.Add(this.textBoxTelefon);
            this.groupBox1.Controls.Add(this.textBoxAdresa);
            this.groupBox1.Controls.Add(this.textBoxGrad);
            this.groupBox1.Controls.Add(this.textBoxPrezime);
            this.groupBox1.Controls.Add(this.textBoxIme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonTrazi);
            this.groupBox1.Controls.Add(this.textBoxPretragaPrezime);
            this.groupBox1.Controls.Add(this.textBoxPretragaIme);
            this.groupBox1.Location = new System.Drawing.Point(16, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(785, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiranje novog kupca / Ažuriranje postojećeg kupca";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAzuriranjeKupca
            // 
            this.buttonAzuriranjeKupca.Location = new System.Drawing.Point(82, 527);
            this.buttonAzuriranjeKupca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAzuriranjeKupca.Name = "buttonAzuriranjeKupca";
            this.buttonAzuriranjeKupca.Size = new System.Drawing.Size(123, 28);
            this.buttonAzuriranjeKupca.TabIndex = 21;
            this.buttonAzuriranjeKupca.Text = "Ažuriranje kupca";
            this.buttonAzuriranjeKupca.UseVisualStyleBackColor = true;
            this.buttonAzuriranjeKupca.Click += new System.EventHandler(this.buttonAzuriranjeKupca_Click);
            // 
            // buttonKreiranjeKupca
            // 
            this.buttonKreiranjeKupca.Location = new System.Drawing.Point(259, 527);
            this.buttonKreiranjeKupca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKreiranjeKupca.Name = "buttonKreiranjeKupca";
            this.buttonKreiranjeKupca.Size = new System.Drawing.Size(123, 28);
            this.buttonKreiranjeKupca.TabIndex = 20;
            this.buttonKreiranjeKupca.Text = "Kreiranje kupca";
            this.buttonKreiranjeKupca.UseVisualStyleBackColor = true;
            this.buttonKreiranjeKupca.Click += new System.EventHandler(this.buttonKreiranjeKupca_Click);
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(485, 426);
            this.textBoxSifra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(132, 22);
            this.textBoxSifra.TabIndex = 18;
            // 
            // textBoxKorisničkoIme
            // 
            this.textBoxKorisničkoIme.Location = new System.Drawing.Point(485, 389);
            this.textBoxKorisničkoIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKorisničkoIme.Name = "textBoxKorisničkoIme";
            this.textBoxKorisničkoIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxKorisničkoIme.TabIndex = 17;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(485, 357);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(132, 22);
            this.textBoxTelefon.TabIndex = 16;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(137, 463);
            this.textBoxAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(132, 22);
            this.textBoxAdresa.TabIndex = 15;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(137, 431);
            this.textBoxGrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(132, 22);
            this.textBoxGrad.TabIndex = 14;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(137, 398);
            this.textBoxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrezime.TabIndex = 13;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(137, 362);
            this.textBoxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxIme.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Šifra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 250);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(393, 25);
            this.buttonTrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(100, 28);
            this.buttonTrazi.TabIndex = 2;
            this.buttonTrazi.Text = "Traži";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // textBoxPretragaPrezime
            // 
            this.textBoxPretragaPrezime.Location = new System.Drawing.Point(215, 25);
            this.textBoxPretragaPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPretragaPrezime.Name = "textBoxPretragaPrezime";
            this.textBoxPretragaPrezime.Size = new System.Drawing.Size(132, 22);
            this.textBoxPretragaPrezime.TabIndex = 1;
            // 
            // textBoxPretragaIme
            // 
            this.textBoxPretragaIme.Location = new System.Drawing.Point(48, 25);
            this.textBoxPretragaIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPretragaIme.Name = "textBoxPretragaIme";
            this.textBoxPretragaIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxPretragaIme.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodavanjeAžuriranjeArtiklaToolStripMenuItem
            // 
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1,
            this.prikazBrisanjeNarudžbeToolStripMenuItem});
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Name = "dodavanjeAžuriranjeArtiklaToolStripMenuItem";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem.Text = "Meni";
            // 
            // dodavanjeAžuriranjeArtiklaToolStripMenuItem1
            // 
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1.Name = "dodavanjeAžuriranjeArtiklaToolStripMenuItem1";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1.Size = new System.Drawing.Size(276, 24);
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1.Text = "Dodavanje / Ažuriranje artikla";
            this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1.Click += new System.EventHandler(this.dodavanjeAžuriranjeArtiklaToolStripMenuItem1_Click);
            // 
            // prikazBrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Name = "prikazBrisanjeNarudžbeToolStripMenuItem";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz / Brisanje narudžbe";
            this.prikazBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // buttonObrisiKupca
            // 
            this.buttonObrisiKupca.Location = new System.Drawing.Point(423, 527);
            this.buttonObrisiKupca.Name = "buttonObrisiKupca";
            this.buttonObrisiKupca.Size = new System.Drawing.Size(116, 27);
            this.buttonObrisiKupca.TabIndex = 22;
            this.buttonObrisiKupca.Text = "Obrišite kupca";
            this.buttonObrisiKupca.UseVisualStyleBackColor = true;
            this.buttonObrisiKupca.Click += new System.EventHandler(this.buttonObrisiKupca_Click);
            // 
            // buttonOsvjezi
            // 
            this.buttonOsvjezi.Location = new System.Drawing.Point(593, 527);
            this.buttonOsvjezi.Name = "buttonOsvjezi";
            this.buttonOsvjezi.Size = new System.Drawing.Size(97, 27);
            this.buttonOsvjezi.TabIndex = 23;
            this.buttonOsvjezi.Text = "Osvježi";
            this.buttonOsvjezi.UseVisualStyleBackColor = true;
            this.buttonOsvjezi.Click += new System.EventHandler(this.buttonOsvjezi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Kreiranje novog kupca / Ažuriranje postojećeg kupca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAzuriranjeKupca;
        private System.Windows.Forms.Button buttonKreiranjeKupca;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxKorisničkoIme;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TextBox textBoxPretragaPrezime;
        private System.Windows.Forms.TextBox textBoxPretragaIme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAžuriranjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAžuriranjeArtiklaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikazBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.Button buttonObrisiKupca;
        private System.Windows.Forms.Button buttonOsvjezi;
    }
}