namespace PizzaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbEbat = new ComboBox();
            label3 = new Label();
            lstPizzalar = new ListBox();
            rdbInceKenar = new RadioButton();
            rdbKalinKenar = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            nudAdet = new NumericUpDown();
            btnHesapla = new Button();
            lstListe = new ListBox();
            label5 = new Label();
            txtTutar = new TextBox();
            btnSepeteEkle = new Button();
            btnSiparisOnay = new Button();
            label6 = new Label();
            lblToplamTutar = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1135, 50);
            label1.TabIndex = 0;
            label1.Text = "PIZZA OTOMASYONU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Ebat";
            // 
            // cmbEbat
            // 
            cmbEbat.FormattingEnabled = true;
            cmbEbat.Location = new Point(12, 104);
            cmbEbat.Name = "cmbEbat";
            cmbEbat.Size = new Size(260, 28);
            cmbEbat.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Pizzalar";
            // 
            // lstPizzalar
            // 
            lstPizzalar.AccessibleDescription = "";
            lstPizzalar.FormattingEnabled = true;
            lstPizzalar.ItemHeight = 20;
            lstPizzalar.Location = new Point(12, 187);
            lstPizzalar.Name = "lstPizzalar";
            lstPizzalar.Size = new Size(260, 104);
            lstPizzalar.TabIndex = 4;
            // 
            // rdbInceKenar
            // 
            rdbInceKenar.AutoSize = true;
            rdbInceKenar.Location = new Point(12, 312);
            rdbInceKenar.Name = "rdbInceKenar";
            rdbInceKenar.Size = new Size(99, 24);
            rdbInceKenar.TabIndex = 5;
            rdbInceKenar.TabStop = true;
            rdbInceKenar.Text = "İnce Kenar";
            rdbInceKenar.UseVisualStyleBackColor = true;
            // 
            // rdbKalinKenar
            // 
            rdbKalinKenar.AutoSize = true;
            rdbKalinKenar.Location = new Point(155, 312);
            rdbKalinKenar.Name = "rdbKalinKenar";
            rdbKalinKenar.Size = new Size(105, 24);
            rdbKalinKenar.TabIndex = 6;
            rdbKalinKenar.TabStop = true;
            rdbKalinKenar.Text = "Kalın Kenar";
            rdbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 192);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzemeler";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 155);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(72, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Zeytin";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 125);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(79, 24);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "Ançuez";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 95);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 24);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Mısır";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Sosis";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(125, 155);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(70, 24);
            checkBox10.TabIndex = 8;
            checkBox10.Text = "Peynir";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(125, 125);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(97, 24);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "Ton Balığı";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(125, 95);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(78, 24);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "Mantar";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(125, 65);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(69, 24);
            checkBox7.TabIndex = 8;
            checkBox7.Text = "Sucuk";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(125, 36);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(72, 24);
            checkBox6.TabIndex = 8;
            checkBox6.Text = "Salam";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Dana Jambon";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 598);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(68, 596);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(104, 27);
            nudAdet.TabIndex = 9;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(178, 594);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 29);
            btnHesapla.TabIndex = 10;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.HorizontalScrollbar = true;
            lstListe.ItemHeight = 20;
            lstListe.Location = new Point(332, 104);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(815, 464);
            lstListe.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 603);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 12;
            label5.Text = "Tutar";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(381, 600);
            txtTutar.Name = "txtTutar";
            txtTutar.ReadOnly = true;
            txtTutar.Size = new Size(161, 27);
            txtTutar.TabIndex = 13;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(577, 600);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(136, 29);
            btnSepeteEkle.TabIndex = 14;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // btnSiparisOnay
            // 
            btnSiparisOnay.Location = new Point(963, 590);
            btnSiparisOnay.Name = "btnSiparisOnay";
            btnSiparisOnay.Size = new Size(155, 49);
            btnSiparisOnay.TabIndex = 15;
            btnSiparisOnay.Text = "Sipariş Onayla";
            btnSiparisOnay.UseVisualStyleBackColor = true;
            btnSiparisOnay.Click += btnSiparisOnay_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(763, 604);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 16;
            label6.Text = "Toplam Tutar";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.BorderStyle = BorderStyle.FixedSingle;
            lblToplamTutar.Location = new Point(866, 598);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(78, 29);
            lblToplamTutar.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 702);
            Controls.Add(lblToplamTutar);
            Controls.Add(label6);
            Controls.Add(btnSiparisOnay);
            Controls.Add(btnSepeteEkle);
            Controls.Add(txtTutar);
            Controls.Add(label5);
            Controls.Add(lstListe);
            Controls.Add(btnHesapla);
            Controls.Add(nudAdet);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(rdbKalinKenar);
            Controls.Add(rdbInceKenar);
            Controls.Add(lstPizzalar);
            Controls.Add(label3);
            Controls.Add(cmbEbat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbEbat;
        private Label label3;
        private ListBox lstPizzalar;
        private RadioButton rdbInceKenar;
        private RadioButton rdbKalinKenar;
        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox1;
        private Label label4;
        private NumericUpDown nudAdet;
        private Button btnHesapla;
        private ListBox lstListe;
        private Label label5;
        private TextBox txtTutar;
        private Button btnSepeteEkle;
        private Button btnSiparisOnay;
        private Label label6;
        private Label lblToplamTutar;
    }
}