using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekat_PPJ
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        String kupID = Form1.kupacID;
        String konekStr = Form1.konekcioniString;

        public void prikaziNarudzbe()
        {
            try
            {
                String query = "SELECT narudzbenica_id,datum_narudzbe" +
                        " FROM narudzbenica n WHERE kupac_id='" + kupID + "';";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT stavka_id, naziv_artikla, cijena, kolicina" +
                        " FROM stavka_narudzbenice sn,artikal a" +
                        " WHERE sn.artikal_id=a.artikal_id" +
                        " AND narudzbenica_id='" + textBoxId.Text + "';";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView2.DataSource = tabela;
                dataAdapter.Dispose();
                query = "SELECT sum(cijena*kolicina)" +
                        " FROM stavka_narudzbenice sn,artikal a" +
                        " WHERE sn.artikal_id=a.artikal_id" +
                        " AND narudzbenica_id='" + textBoxId.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textBoxTotal.Text = reader[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            prikaziNarudzbe();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kreiranjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            this.Hide();
            fr5.Show();
        }
    }
}
