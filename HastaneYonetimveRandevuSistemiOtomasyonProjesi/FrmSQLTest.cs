
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimveRandevuSistemiOtomasyonProjesi
{
    public partial class FrmSQLTest : Form
    {
        public FrmSQLTest()
        {
            InitializeComponent();
        }

        private void FrmSQLTest_Load(object sender, EventArgs e)
        {
            // Girişte bir şey yapma
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            try
            {
                sqlbaglantisi bgl = new sqlbaglantisi();
                SqlConnection baglanti = bgl.baglanti();

                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("✅ SQL Bağlantısı başarılı!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ SQL bağlantısı sağlanamadı.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ HATA: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
