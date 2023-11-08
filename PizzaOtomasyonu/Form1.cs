namespace PizzaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat() { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat() { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat() { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat() { Adi = "Maxi", Carpan = 2 };
            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);
            cmbEbat.Items.Add(buyuk);
            cmbEbat.Items.Add(maxi);
            cmbEbat.SelectedIndex = 0;


            Pizza klasik = new Pizza() { Adi = "Klasik", Fiyat = 14 };
            Pizza karisik = new Pizza() { Adi = "Karýþýk", Fiyat = 17 };
            Pizza turkish = new Pizza() { Adi = "Turkish", Fiyat = 20 };
            Pizza tuna = new Pizza() { Adi = "Tuna", Fiyat = 21 };
            Pizza akdeniz = new Pizza() { Adi = "Akdeniz", Fiyat = 19 };
            Pizza karadeniz = new Pizza() { Adi = "Karadeniz", Fiyat = 22 };

            lstPizzalar.Items.Add(klasik);
            lstPizzalar.Items.Add(karisik);
            lstPizzalar.Items.Add(turkish);
            lstPizzalar.Items.Add(tuna);
            lstPizzalar.Items.Add(akdeniz);
            lstPizzalar.Items.Add(karadeniz);

            KenarTip ince = new KenarTip() { Adi = "Ýnce Kenar", EkFiyat = 0 };
            rdbInceKenar.Tag = ince;
            KenarTip kalin = new KenarTip() { Adi = "Kalýn Kenar", EkFiyat = 2 };
            rdbKalinKenar.Tag = kalin;



        }
        Siparis s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)lstPizzalar.SelectedItem;
            p.Ebati = (Ebat)cmbEbat.SelectedItem;
            p.KenarTipi = (rdbInceKenar.Checked ? (KenarTip)rdbInceKenar.Tag : (KenarTip)rdbKalinKenar.Tag);
            p.Malzemeler = new List<string>();
            foreach (CheckBox item in groupBox1.Controls)
            {

                if (item.Checked)
                {
                    p.Malzemeler.Add(item.Text);
                }
            }

            decimal tutar = nudAdet.Value * p.Tutar;
            txtTutar.Text = tutar.ToString();
            s = new Siparis();
            s.Pizza = p;
            s.Adet = (int)nudAdet.Value;



        }


        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                lstListe.Items.Add(s);

            }

        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int adet = 0;
            foreach (Siparis spr in lstListe.Items)
            {
                toplamTutar += spr.Adet * spr.Pizza.Tutar;
                adet++;

            }
            lblToplamTutar.Text = toplamTutar.ToString();
            MessageBox.Show("Toplam Sipariþ Adediniz: " + adet + "\nToplam Sipariþ Tutarýnýz: " + toplamTutar);
        }
    }
}