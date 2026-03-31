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
        private void btnConnect(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs(object sender, EventArgs e)
        {
            
        }

        private void btnHitungMK(object sender, EventArgs e)
        {

        }

        private void btnUpdate(object sender, EventArgs e)
        {

        }

        private void Hasil(object sender, EventArgs e)
        {

        }
    }
}
