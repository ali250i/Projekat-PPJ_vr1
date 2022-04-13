namespace Projekat_PPJ
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.Yellow;
            this.buttonPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrijava.Location = new System.Drawing.Point(129, 244);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(100, 28);
            this.buttonPrijava.TabIndex = 12;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(189, 107);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(132, 22);
            this.textBoxKorisnickoIme.TabIndex = 13;
            this.textBoxKorisnickoIme.Text = "admin";
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(189, 154);
            this.textBoxSifra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(132, 22);
            this.textBoxSifra.TabIndex = 14;
            this.textBoxSifra.Text = "12345678";
            this.textBoxSifra.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}

