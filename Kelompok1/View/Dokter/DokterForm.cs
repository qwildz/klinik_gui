using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class DokterForm : Form
    {
        Dokter dokter;
        public DokterForm()
        {
            InitializeComponent();
            dokter = new Dokter();
        }

        private void DokterForm_Load(object sender, EventArgs e)
        {
            DataSet table = dokter.LoadDokter();
            dgvDokter.DataSource = table;
            dgvDokter.DataMember = "tdokter";
            dgvDokter.Columns[0].HeaderText = "ID";
            dgvDokter.Columns[1].HeaderText = "Nama Dokter";
            dgvDokter.Columns[2].HeaderText = "Spesialis";
            dgvDokter.Columns[3].HeaderText = "Alamat";
            dgvDokter.Columns[4].HeaderText = "No. Telepon";
        }

        private void buttonTambahDokter_Click(object sender, EventArgs e)
        {
            if (!Session.isAdmin())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa menambah dokter");
                return;
            }

            FormDokterForm f = new FormDokterForm();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                DokterForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (! Session.isAdmin())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa mengubah dokter");
                return;
            }

            int id_dokter = Convert.ToInt32(dgvDokter.CurrentRow.Cells[0].Value);
            string nama_dokter = Convert.ToString(dgvDokter.CurrentRow.Cells[1].Value);
            string spesialis = Convert.ToString(dgvDokter.CurrentRow.Cells[2].Value);
            string alamat = Convert.ToString(dgvDokter.CurrentRow.Cells[3].Value);
            string no_telepon = Convert.ToString(dgvDokter.CurrentRow.Cells[4].Value);
            object[] data = { id_dokter, nama_dokter, spesialis, alamat, no_telepon };
            FormDokterForm f = new FormDokterForm(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                DokterForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string where = " WHERE 1=1 ";
            if (radioButtonNDokter.Checked)
            {
                where += "AND nama_dokter LIKE '%" + textBoxCari.Text + "%'";
            }
            else if (radioButtonSpesialis.Checked)
            {
                where += "AND spesialis LIKE '%" + textBoxCari.Text + "%'";
            }

            DataSet table = dokter.LoadDokter(where);
            dgvDokter.DataSource = table;
            dgvDokter.DataMember = "tdokter";
            dgvDokter.Columns[0].HeaderText = "ID";
            dgvDokter.Columns[1].HeaderText = "Nama Dokter";
            dgvDokter.Columns[2].HeaderText = "Spesialis";
            dgvDokter.Columns[3].HeaderText = "Alamat";
            dgvDokter.Columns[4].HeaderText = "No. Telepon";
            Cursor = Cursors.Default;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (!Session.isAdmin())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa menghapus dokter");
                return;
            }

            int id_dokter = Convert.ToInt32(dgvDokter.CurrentRow.Cells[0].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (konfirmasi == DialogResult.Yes)
            {
                dokter.DeleteDokter(id_dokter);

                Cursor = Cursors.WaitCursor;
                DataSet table = dokter.LoadDokter();
                dgvDokter.DataSource = table;
                dgvDokter.DataMember = "tdokter";
                dgvDokter.Columns[0].HeaderText = "ID";
                dgvDokter.Columns[1].HeaderText = "Nama Dokter";
                dgvDokter.Columns[2].HeaderText = "Spesialis";
                dgvDokter.Columns[3].HeaderText = "Alamat";
                dgvDokter.Columns[4].HeaderText = "No. Telepon";
                Cursor = Cursors.Default;
            }
        }
    }
}
