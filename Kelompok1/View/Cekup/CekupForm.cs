using System;
using System.Data;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class CekupForm : Form
    {
        Cekup cekup;
        int id;
        public CekupForm(object[] data)
        {
            InitializeComponent();
            cekup = new Cekup();

            labelNama.Text = data[1].ToString();
            labelKelamin.Text = data[2].ToString();
            labelLahir.Text = Convert.ToDateTime(data[3]).ToString("dd-MM-yyyy");
            labelGoldarah.Text = data[4].ToString();

            this.id = Convert.ToInt32(data[0]);

        }

        private void CekupForm_Load(object sender, EventArgs e)
        {
            DataSet table = cekup.LoadCekup(id);
            dgvCekup.DataSource = table;
            dgvCekup.DataMember = "tcekup";      
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (Session.isResepsionis() || Session.isAdmin())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa menambah cekup");
                return;
            }

            int id_pasien = Convert.ToInt32(id);
            string nama_pasien = Convert.ToString(labelNama.Text);
            object[] data = { id_pasien, nama_pasien };

            FormCekup f = new FormCekup(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                CekupForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (Session.isResepsionis() || Session.isAdmin())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa menghapus cekup");
                return;
            }

            int id_cekup = Convert.ToInt32(dgvCekup.CurrentRow.Cells["id_cekup"].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (konfirmasi == DialogResult.Yes)
            {
                cekup.DeleteCekup(id_cekup);

                CekupForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void dgvCekup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dgvCekup.CurrentRow.Cells["id_cekup"].Value);
                DetailCekup f = new DetailCekup(id);
                f.ShowDialog();
            }
        }

        private void buttonKartu_Click(object sender, EventArgs e)
        {
            ReportKartuCekup f = new ReportKartuCekup(id);
            f.ShowDialog();
        }
    }
}
