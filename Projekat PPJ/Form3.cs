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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        String kupID = Form1.kupacID;
        String konekStr = Form1.konekcioniString;
       

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT a.*,s.kolicina_stanje" +
                    " FROM artikal a, skladiste s" +
                    " WHERE a.artikal_id=a.artikal_id";
                if (textBoxPretragaId.Text != "")
                {
                    query += " AND a.artikal_id='" + textBoxPretragaId.Text + "' ";
                }
                if (textBoxPretragaNaziv.Text != "")
                {
                    query += " AND naziv_artikla LIKE '%" + textBoxPretragaNaziv.Text + "%' ";
                }
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            buttonTrazi.PerformClick();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDodavanjeArtikla_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO artikal(naziv_artikla,vrsta_artikla,cijena)" +
                    " VALUES('";
                String query1 = "INSERT INTO skladiste(artikal_id,kolicina_stanje)" +
                    " VALUES((SELECT count(*) FROM artikal),'";
                if (textBoxNazivArtikla.Text == "" || textBoxVrstaArtikla.Text == "" ||
                    textBoxCijena.Text == "" || textBoxKolicina.Text == "")
                {
                    MessageBox.Show("Nisu popunjena sva polja");
                }
                else
                {
                    query += textBoxNazivArtikla.Text + "', '" + textBoxVrstaArtikla.Text + "', '" + textBoxCijena.Text + "'); ";
                    MessageBox.Show(query);
                    MySqlConnection konekcija = new MySqlConnection(konekStr);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    query1 += textBoxKolicina.Text + "');";
                    cmd = new MySqlCommand(query1, konekcija);
                    cmd.ExecuteNonQuery();
                    buttonTrazi.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AžuriranjeArtikla_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "UPDATE skladiste SET kolicina_stanje=kolicina_stanje+"+numericUpDown1.Value+
                    " WHERE artikal_id='";
                if (textBoxIdArtikla.Text == "")
                {
                    MessageBox.Show("Nije unesen ID artikla");
                }
                else
                {
                    query += textBoxIdArtikla.Text + "'; ";
                    MessageBox.Show(query);
                    MySqlConnection konekcija = new MySqlConnection(konekStr);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    buttonTrazi.PerformClick();
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

        private void prikazBrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Hide();
            fr4.Show();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Odaberite polje unutar tabele!");
            }

            string upit = "SELECT naziv_artikla, vrsta_artikla, cijena, kolicina_stanje FROM artikal, skladiste WHERE" +
                " artikal.artikal_id=skladiste.artikal_id AND artikal.artikal_id='" + id + "';";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(Form1.konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                string naziv = reader[0].ToString();
                string vrsta = reader[1].ToString();
                string cijena = reader[2].ToString();
                string kolicina = reader[3].ToString();

                textBoxNazivArtikla.Text = naziv;
                textBoxVrstaArtikla.Text = vrsta;
                textBoxCijena.Text = cijena;
                textBoxIdArtikla.Text = id.ToString();
                textBoxKolicina.Text = kolicina;

                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            
        }
    }
}
