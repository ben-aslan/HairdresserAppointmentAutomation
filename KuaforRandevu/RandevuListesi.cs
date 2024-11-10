using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforRandevu
{
    public partial class RandevuListesi : Form
    {
        public RandevuListesi()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(@"Server=localhost;Port=3306;Uid=root;Pwd=ayarlama@#@#141414;Database=kuaforuygulamasi");
        private void RandevuListesi_Load(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        void RandevulariListele()
        {
            listView1.Items.Clear();

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand komut = new MySqlCommand("Select * From randevular", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem urun = new ListViewItem(new string[]
                    {
                        oku["Id"].ToString(  ),
                        oku["MusteriAdi"].ToString(  )+" "+oku["MusteriSoyadi"].ToString(  ),
                        oku["TelefonNumarasi"].ToString(  ),
                        oku["RandevuTarihi"].ToString(  ),
                        oku["RandevuSaati"].ToString(  )
                    }
                         );
                    listView1.Items.Add(urun);
                }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                ListViewItem listViewItem = listView1.SelectedItems[0];
                MySqlCommand komut = new MySqlCommand("Select * From randevular where Id=" + listViewItem.SubItems[0].Text, baglanti);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    randevu_kodu_txt.Text = oku["Id"].ToString();
                    musteri_adi_txt.Text = oku["MusteriAdi"].ToString();
                    musteri_soyadi_txt.Text = oku["MusteriSoyadi"].ToString();
                    telefon_numarasi_txt.Text = oku["TelefonNumarasi"].ToString();
                    dateTimePicker1.Text = oku["RandevuTarihi"].ToString();
                    randevu_saati_txt.Text = oku["RandevuSaati"].ToString();
                }
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
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand komut = new MySqlCommand("Update randevular Set MusteriAdi='" + musteri_adi_txt.Text + "', MusteriSoyadi='" + musteri_soyadi_txt.Text + "', TelefonNumarasi='" + telefon_numarasi_txt.Text + "',RandevuTarihi='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "',RandevuSaati='" + randevu_saati_txt.Text + "' Where Id='" + randevu_kodu_txt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                RandevulariListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand komut = new MySqlCommand("Delete From randevular Where Id='" + randevu_kodu_txt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Randevu Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (baglanti.State != ConnectionState.Closed)
                    baglanti.Close();

                RandevulariListele();
            }
        }
    }
}
