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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        String kupID = Form1.kupacID;
        String konekStr = Form1.konekcioniString;

        private void Form4_Load(object sender, EventArgs e)
        {
            prikaziTabelu();
        }

        private void prikaziTabelu()
        {
            String query = "SELECT n.*, ime, prezime" +
                    " FROM narudzbenica n, kupac k WHERE k.kupac_id=n.kupac_id;";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataAdapter.Dispose();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBrisanjeNarudzbe_Click(object sender, EventArgs e)
        {
            try
            {
                int narID = Convert.ToInt32(textBoxId.Text);
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Nepravilan unos");
                }
                else
                {
                    MySqlConnection konekcija = new MySqlConnection(konekStr);
                    konekcija.Open();
                    String query = "SELECT * FROM stavka_narudzbenice sn" +
                    " WHERE narudzbenica_id='" + narID + "';";
                    MySqlCommand cmd = new MySqlCommand(query, konekcija);
                    cmd = new MySqlCommand(query, konekcija);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    string query2 = "";
                    while (reader.Read())
                    {
                        query2 += "UPDATE skladiste SET" +
                        " kolicina_stanje=kolicina_stanje+" + reader["kolicina"] + " WHERE" +
                        " artikal_id='" + reader["artikal_id"] + "'; " +
                        " DELETE FROM stavka_narudzbenice WHERE" +
                        " artikal_id='" + reader["artikal_id"] +
                        "' AND narudzbenica_id='" + narID + "'; ";
                    }
                    reader.Close();
                    if (query2 != "")
                    {
                        cmd = new MySqlCommand(query2, konekcija);
                        cmd.ExecuteNonQuery();
                    }
                    query="DELETE FROM narudzbenica WHERE" +
                        " narudzbenica_id='" + narID + "'; ";
                    cmd = new MySqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();

                    prikaziTabelu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kreiranjeNovogKupcaAžuriranjePostojećegKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            this.Hide();
            fr2.Show();
        }

        private void dodavanjeAžuriranjeArtiklaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            this.Hide();
            fr3.Show();
        }
    }
}
