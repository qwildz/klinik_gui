using System;
using System.Data;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class PasienForm : Form
    {
        Pasien pasien;
        public PasienForm()
        {
            InitializeComponent();
            pasien = new Pasien();
        }

        private void PasienForm_Load(object sender, EventArgs e)
        {
            DataSet table = pasien.LoadPasien();
            dgvPasien.DataSource = table;
            dgvPasien.DataMember = "tpasien";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPasien f = new FormPasien();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                PasienForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string where = " WHERE 1=1 ";
            if (radioButtonNama.Checked)
            {
                where += "AND nama_pasien LIKE '%" + textBoxCari.Text + "%'";
            }
            else if (radioButtonAlamat.Checked)
            {
                where += "AND alamat LIKE '%" + textBoxCari.Text + "%'";
            }
            else if (radioButtonKelamin.Checked)
            {
                where += "AND jenis_kelamin LIKE '%" + comboBoxKelamin.Text + "%'";
            }

            DataSet table = pasien.LoadPasien(where);
            dgvPasien.DataSource = table;
            dgvPasien.DataMember = "tpasien";
            Cursor = Cursors.Default;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            int id_pasien = Convert.ToInt32(dgvPasien.CurrentRow.Cells["id_pasien"].Value);
            string nama_pasien = Convert.ToString(dgvPasien.CurrentRow.Cells["nama_pasien"].Value);
            string jenis_kelamin = Convert.ToString(dgvPasien.CurrentRow.Cells["jenis_kelamin"].Value);
            DateTime tanggal_lahir = Convert.ToDateTime(dgvPasien.CurrentRow.Cells["tgl_lahir"].Value);
            string alamat = Convert.ToString(dgvPasien.CurrentRow.Cells["alamat"].Value);
            string gol_darah = Convert.ToString(dgvPasien.CurrentRow.Cells["gol_darah"].Value);
            string no_telepon = Convert.ToString(dgvPasien.CurrentRow.Cells["no_telepon"].Value);
            object[] data = { id_pasien, nama_pasien, jenis_kelamin, tanggal_lahir, alamat, gol_darah, no_telepon };

            FormPasien f = new FormPasien(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                PasienForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            int id_pasien = Convert.ToInt32(dgvPasien.CurrentRow.Cells["id_pasien"].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (konfirmasi == DialogResult.Yes)
            {
                pasien.DeletePasien(id_pasien);

                Cursor = Cursors.WaitCursor;
                DataSet table = pasien.LoadPasien();
                dgvPasien.DataSource = table;
                dgvPasien.DataMember = "tpasien";
                Cursor = Cursors.Default;
            }
        }

        private void dgvPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                int id_pasien = Convert.ToInt32(dgvPasien.CurrentRow.Cells["id_pasien"].Value);
                string nama_pasien = Convert.ToString(dgvPasien.CurrentRow.Cells["nama_pasien"].Value);
                string jenis_kelamin = Convert.ToString(dgvPasien.CurrentRow.Cells["jenis_kelamin"].Value);
                string tanggal_lahir = Convert.ToString(dgvPasien.CurrentRow.Cells["tgl_lahir"].Value);
                string gol_darah = Convert.ToString(dgvPasien.CurrentRow.Cells["gol_darah"].Value);
                object[] data = { id_pasien, nama_pasien, jenis_kelamin, tanggal_lahir, gol_darah };

                CekupForm f = new CekupForm(data);
                f.ShowDialog();
            }
        }

        private void radioButtonNama_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCari.Visible = true;
            comboBoxKelamin.Visible = false;
        }

        private void radioButtonKelamin_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCari.Visible = false;
            comboBoxKelamin.Visible = true;
        }

        private void radioButtonAlamat_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCari.Visible = true;
            comboBoxKelamin.Visible = false;
        }
    }
}
