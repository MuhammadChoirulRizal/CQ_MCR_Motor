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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "UPDATE Mahasiswa SET Alamat='Yogyakarta' WHERE NIM='23110100001'";
                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Data yang diupdate: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "SELECT COUNT(*) FROM Dosen";
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

        private void btnUpdateMk_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "UPDATE MataKuliah SET SKS=4 WHERE KodeMK='IF210101'";
                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Data diupdate: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertProdi_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();

                string query = "INSERT INTO ProgramStudi VALUES ('MI" + DateTime.Now.Second + "','Test')";
                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
