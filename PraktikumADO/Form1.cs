using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-5LMNPAS3\\CHOY;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );

            conn.Open();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                MessageBox.Show("Koneksi ke database berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "SELECT COUNT(*) FROM Mahasiswa";
                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

