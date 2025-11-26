namespace Project_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            spns = new Label();
            identitas = new Label();
            Kelas = new Label();
            cmbKelas = new ComboBox();
            NP = new Label();
            NamaSiswa = new Label();
            txtNama = new TextBox();
            Matematika = new Label();
            IPA = new Label();
            IPS = new Label();
            BHSINDO = new Label();
            BHSING = new Label();
            BHSJW = new Label();
            pai = new Label();
            pjok = new Label();
            txtMatematika = new TextBox();
            txtIPA = new TextBox();
            txtIPS = new TextBox();
            txtBindo = new TextBox();
            txtBinggris = new TextBox();
            smkn1 = new Label();
            alamat = new Label();
            txtBjawa = new TextBox();
            txtPAI = new TextBox();
            txtPJOK = new TextBox();
            nilaitarata = new Label();
            txtRataRata = new TextBox();
            ekstra = new Label();
            chkPramuka = new CheckBox();
            chkPMR = new CheckBox();
            chKPKS = new CheckBox();
            chkMarching = new CheckBox();
            pramuka = new Label();
            pmr = new Label();
            PKS = new Label();
            marband = new Label();
            poin = new Label();
            txtPelanggaran = new TextBox();
            pelanggaran = new Label();
            btnHitung = new Button();
            btnReset = new Button();
            btnSimpan = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // spns
            // 
            spns.AutoSize = true;
            spns.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spns.Location = new Point(49, 156);
            spns.Name = "spns";
            spns.Size = new Size(385, 31);
            spns.TabIndex = 0;
            spns.Text = "SISTEM PERHITUNGAN NILAI SISWA";
            // 
            // identitas
            // 
            identitas.AutoSize = true;
            identitas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            identitas.Location = new Point(49, 201);
            identitas.Name = "identitas";
            identitas.Size = new Size(121, 23);
            identitas.TabIndex = 1;
            identitas.Text = "Identitas siswa";
            // 
            // Kelas
            // 
            Kelas.AutoSize = true;
            Kelas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kelas.Location = new Point(49, 259);
            Kelas.Name = "Kelas";
            Kelas.Size = new Size(58, 23);
            Kelas.TabIndex = 3;
            Kelas.Text = "Kelas :";
            Kelas.Click += label3_Click;
            // 
            // cmbKelas
            // 
            cmbKelas.FormattingEnabled = true;
            cmbKelas.Items.AddRange(new object[] { "XII A", "XII B", "XII C", "XII D", "XII E", "XII F", "XII G" });
            cmbKelas.Location = new Point(335, 259);
            cmbKelas.Name = "cmbKelas";
            cmbKelas.Size = new Size(151, 28);
            cmbKelas.TabIndex = 4;
            cmbKelas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NP
            // 
            NP.AutoSize = true;
            NP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NP.Location = new Point(45, 304);
            NP.Name = "NP";
            NP.Size = new Size(118, 23);
            NP.TabIndex = 7;
            NP.Text = "Nilai Pelajaran";
            // 
            // NamaSiswa
            // 
            NamaSiswa.AutoSize = true;
            NamaSiswa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaSiswa.Location = new Point(47, 231);
            NamaSiswa.Name = "NamaSiswa";
            NamaSiswa.Size = new Size(111, 23);
            NamaSiswa.TabIndex = 8;
            NamaSiswa.Text = "Nama Siswa :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(167, 227);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(326, 27);
            txtNama.TabIndex = 9;
            txtNama.TextChanged += textBoxNAMA_TextChanged;
            // 
            // Matematika
            // 
            Matematika.AutoSize = true;
            Matematika.Location = new Point(45, 339);
            Matematika.Name = "Matematika";
            Matematika.Size = new Size(99, 20);
            Matematika.TabIndex = 11;
            Matematika.Text = "Matematika : ";
            Matematika.Click += Matematika_Click;
            // 
            // IPA
            // 
            IPA.AutoSize = true;
            IPA.Location = new Point(46, 366);
            IPA.Name = "IPA";
            IPA.Size = new Size(37, 20);
            IPA.TabIndex = 12;
            IPA.Text = "IPA :";
            IPA.Click += IPA_Click;
            // 
            // IPS
            // 
            IPS.AutoSize = true;
            IPS.Location = new Point(46, 396);
            IPS.Name = "IPS";
            IPS.Size = new Size(40, 20);
            IPS.TabIndex = 13;
            IPS.Text = "IPS : ";
            IPS.Click += IPS_Click;
            // 
            // BHSINDO
            // 
            BHSINDO.AutoSize = true;
            BHSINDO.Location = new Point(46, 426);
            BHSINDO.Name = "BHSINDO";
            BHSINDO.Size = new Size(131, 20);
            BHSINDO.TabIndex = 14;
            BHSINDO.Text = "Bahasa Indonesia :";
            BHSINDO.Click += BHSINDO_Click;
            // 
            // BHSING
            // 
            BHSING.AutoSize = true;
            BHSING.Location = new Point(46, 458);
            BHSING.Name = "BHSING";
            BHSING.Size = new Size(112, 20);
            BHSING.TabIndex = 15;
            BHSING.Text = "Bahasa Inggris :";
            // 
            // BHSJW
            // 
            BHSJW.AutoSize = true;
            BHSJW.Location = new Point(45, 487);
            BHSJW.Name = "BHSJW";
            BHSJW.Size = new Size(99, 20);
            BHSJW.TabIndex = 16;
            BHSJW.Text = "Bahasa Jawa :";
            // 
            // pai
            // 
            pai.AutoSize = true;
            pai.Location = new Point(45, 520);
            pai.Name = "pai";
            pai.Size = new Size(37, 20);
            pai.TabIndex = 17;
            pai.Text = "PAI :";
            // 
            // pjok
            // 
            pjok.AutoSize = true;
            pjok.Location = new Point(45, 551);
            pjok.Name = "pjok";
            pjok.Size = new Size(48, 20);
            pjok.TabIndex = 18;
            pjok.Text = "PJOK :";
            // 
            // txtMatematika
            // 
            txtMatematika.Location = new Point(342, 332);
            txtMatematika.Name = "txtMatematika";
            txtMatematika.Size = new Size(151, 27);
            txtMatematika.TabIndex = 19;
            txtMatematika.TextChanged += textBoxmtk_TextChanged;
            // 
            // txtIPA
            // 
            txtIPA.Location = new Point(342, 359);
            txtIPA.Name = "txtIPA";
            txtIPA.Size = new Size(151, 27);
            txtIPA.TabIndex = 20;
            // 
            // txtIPS
            // 
            txtIPS.Location = new Point(342, 389);
            txtIPS.Name = "txtIPS";
            txtIPS.Size = new Size(151, 27);
            txtIPS.TabIndex = 21;
            // 
            // txtBindo
            // 
            txtBindo.Location = new Point(342, 419);
            txtBindo.Name = "txtBindo";
            txtBindo.Size = new Size(151, 27);
            txtBindo.TabIndex = 22;
            // 
            // txtBinggris
            // 
            txtBinggris.Location = new Point(342, 451);
            txtBinggris.Name = "txtBinggris";
            txtBinggris.Size = new Size(151, 27);
            txtBinggris.TabIndex = 23;
            // 
            // smkn1
            // 
            smkn1.AutoSize = true;
            smkn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            smkn1.Location = new Point(145, 80);
            smkn1.Name = "smkn1";
            smkn1.Size = new Size(276, 31);
            smkn1.TabIndex = 24;
            smkn1.Text = "SMA Pradita Dirgantara";
            // 
            // alamat
            // 
            alamat.AutoSize = true;
            alamat.Location = new Point(93, 111);
            alamat.Name = "alamat";
            alamat.Size = new Size(393, 20);
            alamat.TabIndex = 25;
            alamat.Text = "Jl. Satya Garuda No.6,  Perbukitan Adi Soemarmo, Boyolali";
            // 
            // txtBjawa
            // 
            txtBjawa.Location = new Point(342, 480);
            txtBjawa.Name = "txtBjawa";
            txtBjawa.Size = new Size(151, 27);
            txtBjawa.TabIndex = 26;
            // 
            // txtPAI
            // 
            txtPAI.Location = new Point(342, 513);
            txtPAI.Name = "txtPAI";
            txtPAI.Size = new Size(151, 27);
            txtPAI.TabIndex = 27;
            // 
            // txtPJOK
            // 
            txtPJOK.Location = new Point(342, 544);
            txtPJOK.Name = "txtPJOK";
            txtPJOK.Size = new Size(151, 27);
            txtPJOK.TabIndex = 28;
            txtPJOK.TextChanged += textBoxpjok_TextChanged;
            // 
            // nilaitarata
            // 
            nilaitarata.AutoSize = true;
            nilaitarata.Location = new Point(46, 601);
            nilaitarata.Name = "nilaitarata";
            nilaitarata.Size = new Size(117, 20);
            nilaitarata.TabIndex = 29;
            nilaitarata.Text = "Nilai Rata-Rata :";
            // 
            // txtRataRata
            // 
            txtRataRata.Location = new Point(342, 594);
            txtRataRata.Name = "txtRataRata";
            txtRataRata.Size = new Size(147, 27);
            txtRataRata.TabIndex = 30;
            txtRataRata.TextChanged += textBoxtarata_TextChanged;
            // 
            // ekstra
            // 
            ekstra.AutoSize = true;
            ekstra.Location = new Point(46, 643);
            ekstra.Name = "ekstra";
            ekstra.Size = new Size(145, 20);
            ekstra.TabIndex = 31;
            ekstra.Text = "Nilai Ekstrakulikuler :";
            // 
            // chkPramuka
            // 
            chkPramuka.AutoSize = true;
            chkPramuka.Location = new Point(46, 675);
            chkPramuka.Name = "chkPramuka";
            chkPramuka.Size = new Size(88, 24);
            chkPramuka.TabIndex = 32;
            chkPramuka.Text = "Pramuka";
            chkPramuka.UseVisualStyleBackColor = true;
            // 
            // chkPMR
            // 
            chkPMR.AutoSize = true;
            chkPMR.Location = new Point(46, 705);
            chkPMR.Name = "chkPMR";
            chkPMR.Size = new Size(61, 24);
            chkPMR.TabIndex = 33;
            chkPMR.Text = "PMR";
            chkPMR.UseVisualStyleBackColor = true;
            // 
            // chKPKS
            // 
            chKPKS.AutoSize = true;
            chKPKS.Location = new Point(329, 675);
            chKPKS.Name = "chKPKS";
            chKPKS.Size = new Size(56, 24);
            chKPKS.TabIndex = 34;
            chKPKS.Text = "PKS";
            chKPKS.UseVisualStyleBackColor = true;
            // 
            // chkMarching
            // 
            chkMarching.AutoSize = true;
            chkMarching.Location = new Point(329, 705);
            chkMarching.Name = "chkMarching";
            chkMarching.Size = new Size(131, 24);
            chkMarching.TabIndex = 35;
            chkMarching.Text = "Marching Band";
            chkMarching.UseVisualStyleBackColor = true;
            // 
            // pramuka
            // 
            pramuka.AutoSize = true;
            pramuka.Location = new Point(249, 679);
            pramuka.Name = "pramuka";
            pramuka.Size = new Size(42, 20);
            pramuka.TabIndex = 36;
            pramuka.Text = "+ 0,2";
            // 
            // pmr
            // 
            pmr.AutoSize = true;
            pmr.Location = new Point(249, 709);
            pmr.Name = "pmr";
            pmr.Size = new Size(42, 20);
            pmr.TabIndex = 37;
            pmr.Text = "+ 0,2";
            // 
            // PKS
            // 
            PKS.AutoSize = true;
            PKS.Location = new Point(491, 675);
            PKS.Name = "PKS";
            PKS.Size = new Size(42, 20);
            PKS.TabIndex = 38;
            PKS.Text = "+ 0,3";
            // 
            // marband
            // 
            marband.AutoSize = true;
            marband.Location = new Point(491, 709);
            marband.Name = "marband";
            marband.Size = new Size(42, 20);
            marband.TabIndex = 39;
            marband.Text = "+ 0,3";
            // 
            // poin
            // 
            poin.AutoSize = true;
            poin.Location = new Point(46, 757);
            poin.Name = "poin";
            poin.Size = new Size(180, 20);
            poin.TabIndex = 40;
            poin.Text = "Jumlah Poin Pelanggaran :";
            // 
            // txtPelanggaran
            // 
            txtPelanggaran.Location = new Point(232, 754);
            txtPelanggaran.Name = "txtPelanggaran";
            txtPelanggaran.Size = new Size(97, 27);
            txtPelanggaran.TabIndex = 41;
            // 
            // pelanggaran
            // 
            pelanggaran.AutoSize = true;
            pelanggaran.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pelanggaran.Location = new Point(335, 760);
            pelanggaran.Name = "pelanggaran";
            pelanggaran.Size = new Size(189, 17);
            pelanggaran.TabIndex = 42;
            pelanggaran.Text = "1 poin pelanggaran = -0,2 nilai";
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.FromArgb(0, 192, 0);
            btnHitung.ForeColor = SystemColors.ControlLightLight;
            btnHitung.Location = new Point(46, 793);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(120, 32);
            btnHitung.TabIndex = 43;
            btnHitung.Text = "HITUNG HASIL";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(181, 793);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 44;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button2_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(281, 793);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(150, 29);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "SIMPAN DATA";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(447, 793);
            button4.Name = "button4";
            button4.Size = new Size(94, 32);
            button4.TabIndex = 46;
            button4.Text = "KELUAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(293, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 834);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(btnSimpan);
            Controls.Add(btnReset);
            Controls.Add(btnHitung);
            Controls.Add(pelanggaran);
            Controls.Add(txtPelanggaran);
            Controls.Add(poin);
            Controls.Add(marband);
            Controls.Add(PKS);
            Controls.Add(pmr);
            Controls.Add(pramuka);
            Controls.Add(chkMarching);
            Controls.Add(chKPKS);
            Controls.Add(chkPMR);
            Controls.Add(chkPramuka);
            Controls.Add(ekstra);
            Controls.Add(txtRataRata);
            Controls.Add(nilaitarata);
            Controls.Add(txtPJOK);
            Controls.Add(txtPAI);
            Controls.Add(txtBjawa);
            Controls.Add(alamat);
            Controls.Add(smkn1);
            Controls.Add(txtBinggris);
            Controls.Add(txtBindo);
            Controls.Add(txtIPS);
            Controls.Add(txtIPA);
            Controls.Add(txtMatematika);
            Controls.Add(pjok);
            Controls.Add(pai);
            Controls.Add(BHSJW);
            Controls.Add(BHSING);
            Controls.Add(BHSINDO);
            Controls.Add(IPS);
            Controls.Add(IPA);
            Controls.Add(Matematika);
            Controls.Add(txtNama);
            Controls.Add(NamaSiswa);
            Controls.Add(NP);
            Controls.Add(cmbKelas);
            Controls.Add(Kelas);
            Controls.Add(identitas);
            Controls.Add(spns);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label spns;
        private Label identitas;
        private Label Kelas;
        private ComboBox cmbKelas;
        private Label NP;
        private Label NamaSiswa;
        private TextBox txtNama;
        private Label Matematika;
        private Label IPA;
        private Label IPS;
        private Label BHSINDO;
        private Label BHSING;
        private Label BHSJW;
        private Label pai;
        private Label pjok;
        private TextBox txtMatematika;
        private TextBox txtIPA;
        private TextBox txtIPS;
        private TextBox txtBindo;
        private TextBox txtBinggris;
        private Label smkn1;
        private Label alamat;
        private TextBox txtBjawa;
        private TextBox txtPAI;
        private TextBox txtPJOK;
        private Label nilaitarata;
        private TextBox txtRataRata;
        private Label ekstra;
        private CheckBox chkPramuka;
        private CheckBox chkPMR;
        private CheckBox chKPKS;
        private CheckBox chkMarching;
        private Label pramuka;
        private Label pmr;
        private Label PKS;
        private Label marband;
        private Label poin;
        private TextBox txtPelanggaran;
        private Label pelanggaran;
        private Button btnHitung;
        private Button btnReset;
        private Button btnSimpan;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
