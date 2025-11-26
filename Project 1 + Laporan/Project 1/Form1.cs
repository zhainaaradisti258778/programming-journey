using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Matematika_Click(object sender, EventArgs e)
        {

        }

        private void IPA_Click(object sender, EventArgs e)
        {

        }

        private void IPS_Click(object sender, EventArgs e)
        {

        }

        private void BHSINDO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxmtk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNAMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpjok_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtarata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            
                // Ambil nilai dari TextBox (pelajaran)
                double mtk = double.Parse(txtMatematika.Text);
                double ipa = double.Parse(txtIPA.Text);
                double ips = double.Parse(txtIPS.Text);
                double indo = double.Parse(txtBindo.Text);
                double inggris = double.Parse(txtBinggris.Text);
                double jawa = double.Parse(txtBjawa.Text);
                double pai = double.Parse(txtPAI.Text);
                double pjok = double.Parse(txtPJOK.Text);

                // Hitung rata-rata dasar
                double rata = (mtk + ipa + ips + indo + inggris + jawa + pai + pjok) / 8;

                // Tambahkan nilai ekstrakurikuler 
                if (chkPramuka.Checked) rata += 0.2;
                if (chkPMR.Checked) rata += 0.2;
                if (chKPKS.Checked) rata += 0.3;
                if (chkMarching.Checked) rata += 0.3;

                // Kurangi poin pelanggaran (1 poin = -0,2)
                double pelanggaran = 0;
                if (!string.IsNullOrEmpty(txtPelanggaran.Text)) pelanggaran = double.Parse(txtPelanggaran.Text);
                rata -= pelanggaran * 0.2;

                // Batas nilai agar tetap 0-100
                if (rata > 100) rata = 100;
                if (rata < 0) rata = 0;

                // Tampilkan hasil di TextBox Nilai Rata-Rata
                txtRataRata.Text = rata.ToString("0.00");
            
                // Ambil nilai dari textbox
                if (double.TryParse(txtRataRata.Text, out double nilai))
                {
                    // Cek hasil kelulusan berdasarkan nilai
                    if (nilai >= 75)
                    {
                        MessageBox.Show("Selamat Anda Dinyatakan Lulus!", "Hasil", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Maaf Anda Dinyakatakan Tidak Lulus!", "Hasil", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                     // Jika input nilai bukan angka
                     MessageBox.Show("Masukkan nilai yang valid! Pastikan semua nilai diisi dengan angka!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kosongkan semua TextBox 
            txtNama.Clear();
            cmbKelas.Text = "";
            txtMatematika.Clear();
            txtIPA.Clear();
            txtIPS.Clear();
            txtBindo.Clear();
            txtBinggris.Clear();
            txtBjawa.Clear();
            txtPAI.Clear();
            txtPJOK.Clear();
            txtRataRata.Clear();
            txtPelanggaran.Clear();

            // Uncheck semua CheckBox ekstrakurikuler 
            chkPramuka.Checked = false;
            chkPMR.Checked = false;
            chKPKS.Checked = false;
            chkMarching.Checked = false;

            // Fokuskan kursor kembali ke nama siswa 
            txtNama.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pastikan nama dan rata-rata sudah diisi
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtRataRata.Text)) 
            {
                MessageBox.Show("Harap isi sesuai sistem!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                

                // Untuk text yang ingin disimpan
                string data = $"Nama: {txtNama.Text}\r\n" + $"Kelas: {cmbKelas.Text}\r\n" + $"Nilai Rata-Rata: " +
                    $"{txtRataRata.Text}\r\n";

                // Simpan ke file di Documents pengguna 
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataNilaiSiswa.txt";

                // Tambahkan ke file (append)
                System.IO.File.AppendAllText(path, data);
                MessageBox.Show($"Data berhasil disimpan ke file: \n{path}", "Berhasil", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Terjadi kesalahan saat menyimpan data:\n" + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}