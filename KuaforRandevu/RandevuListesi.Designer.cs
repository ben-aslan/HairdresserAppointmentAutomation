namespace KuaforRandevu
{
    partial class RandevuListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.randevukodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.advesoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonnumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randevu_saati_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.telefon_numarasi_txt = new System.Windows.Forms.TextBox();
            this.musteri_soyadi_txt = new System.Windows.Forms.TextBox();
            this.musteri_adi_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.randevu_kodu_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(23, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.randevukodu,
            this.advesoyad,
            this.telefonnumarasi,
            this.tarih,
            this.saat});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 285);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // randevukodu
            // 
            this.randevukodu.Text = "Randevu Kodu";
            this.randevukodu.Width = 100;
            // 
            // advesoyad
            // 
            this.advesoyad.Text = "Ad ve Soyad";
            this.advesoyad.Width = 200;
            // 
            // telefonnumarasi
            // 
            this.telefonnumarasi.Text = "Telefon numarası";
            this.telefonnumarasi.Width = 150;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            this.tarih.Width = 100;
            // 
            // saat
            // 
            this.saat.Text = "Saat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.randevu_kodu_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.randevu_saati_txt);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.telefon_numarasi_txt);
            this.groupBox1.Controls.Add(this.musteri_soyadi_txt);
            this.groupBox1.Controls.Add(this.musteri_adi_txt);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // randevu_saati_txt
            // 
            this.randevu_saati_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.randevu_saati_txt.Location = new System.Drawing.Point(444, 102);
            this.randevu_saati_txt.Name = "randevu_saati_txt";
            this.randevu_saati_txt.Size = new System.Drawing.Size(70, 27);
            this.randevu_saati_txt.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // telefon_numarasi_txt
            // 
            this.telefon_numarasi_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.telefon_numarasi_txt.Location = new System.Drawing.Point(133, 61);
            this.telefon_numarasi_txt.Name = "telefon_numarasi_txt";
            this.telefon_numarasi_txt.Size = new System.Drawing.Size(152, 27);
            this.telefon_numarasi_txt.TabIndex = 7;
            // 
            // musteri_soyadi_txt
            // 
            this.musteri_soyadi_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.musteri_soyadi_txt.Location = new System.Drawing.Point(405, 58);
            this.musteri_soyadi_txt.Name = "musteri_soyadi_txt";
            this.musteri_soyadi_txt.Size = new System.Drawing.Size(183, 27);
            this.musteri_soyadi_txt.TabIndex = 6;
            // 
            // musteri_adi_txt
            // 
            this.musteri_adi_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.musteri_adi_txt.Location = new System.Drawing.Point(405, 19);
            this.musteri_adi_txt.Name = "musteri_adi_txt";
            this.musteri_adi_txt.Size = new System.Drawing.Size(183, 27);
            this.musteri_adi_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Müşteri adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(291, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Müşteri soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefon numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Randevu tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(334, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Randevu saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Randevu Kodu:";
            // 
            // randevu_kodu_txt
            // 
            this.randevu_kodu_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.randevu_kodu_txt.Location = new System.Drawing.Point(133, 19);
            this.randevu_kodu_txt.Name = "randevu_kodu_txt";
            this.randevu_kodu_txt.Size = new System.Drawing.Size(152, 27);
            this.randevu_kodu_txt.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(663, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RandevuListesi";
            this.Text = "RandevuListesi";
            this.Load += new System.EventHandler(this.RandevuListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader randevukodu;
        private System.Windows.Forms.ColumnHeader advesoyad;
        private System.Windows.Forms.ColumnHeader telefonnumarasi;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox randevu_saati_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox telefon_numarasi_txt;
        private System.Windows.Forms.TextBox musteri_soyadi_txt;
        private System.Windows.Forms.TextBox musteri_adi_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox randevu_kodu_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}