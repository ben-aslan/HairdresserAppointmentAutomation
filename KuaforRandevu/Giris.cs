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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici_adi_txt.Text.Trim() == "subu" && sifre_txt.Text.Trim() == "berat")
            {
                this.Hide();
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya Şifre yanlış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
