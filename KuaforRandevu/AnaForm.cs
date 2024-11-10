using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforRandevu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(@"Server=localhost;Port=3306;Uid=root;Pwd=ayarlama@#@#141414;Database=kuaforuygulamasi");
        private void kaydet_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                if (saat_txt.Text == "" || saat_txt.Text == null)
                    saat_txt.Text = "00";

                if (dakika_txt.Text == "" || dakika_txt.Text == null)
                    dakika_txt.Text = "00";

                MySqlCommand komut = new MySqlCommand("Insert Into randevular ( MusteriAdi, MusteriSoyadi, TelefonNumarasi, RandevuTarihi, RandevuSaati ) Values( '" + musteri_adi_txt.Text + "', '" + musteri_soyadi_txt.Text + "', '" + telefon_numarasi_txt.Text + "', '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "', '" + saat_txt.Text + ":" + dakika_txt.Text + "' )", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuListesi randevuListesi = new RandevuListesi();
            randevuListesi.Show();
        }
    }
}
