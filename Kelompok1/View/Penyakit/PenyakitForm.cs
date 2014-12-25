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
    public partial class PenyakitForm : Form
    {
        Penyakit penyakit;
        public PenyakitForm()
        {
            InitializeComponent();
            penyakit = new Penyakit();
        }

        private void PenyakitForm_Load(object sender, EventArgs e)
        {
            DataSet table = penyakit.LoadPenyakit();
            dgvPenyakit.DataSource = table;
            dgvPenyakit.DataMember = "tpenyakit";
            dgvPenyakit.Columns[0].HeaderText = "ID";
            dgvPenyakit.Columns[1].HeaderText = "Nama Penyakit";
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            FormPenyakit f = new FormPenyakit();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                PenyakitForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonCariPenyakit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string where = " WHERE 1=1 ";

            where += "AND nama_penyakit LIKE '%" + textBoxCariPenyakit.Text + "%'";

            DataSet table = penyakit.LoadPenyakit(where);
            dgvPenyakit.DataSource = table;
            dgvPenyakit.DataMember = "tpenyakit";
            dgvPenyakit.Columns[0].HeaderText = "ID";
            dgvPenyakit.Columns[1].HeaderText = "Nama Penyakit";
            Cursor = Cursors.Default;
        }

        private void buttonUbahPenyakit_Click(object sender, EventArgs e)
        {
            int id_penyakit = Convert.ToInt32(dgvPenyakit.CurrentRow.Cells[0].Value);
            string nama_penyakit = Convert.ToString(dgvPenyakit.CurrentRow.Cells[1].Value);
            object[] data = { id_penyakit, nama_penyakit};
            FormPenyakit f = new FormPenyakit(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                PenyakitForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonHapusPenyakit_Click(object sender, EventArgs e)
        {
            int id_penyakit = Convert.ToInt32(dgvPenyakit.CurrentRow.Cells[0].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (konfirmasi == DialogResult.Yes)
            {
                penyakit.DeletePenyakit(id_penyakit);

                Cursor = Cursors.WaitCursor;
                DataSet table = penyakit.LoadPenyakit();
                dgvPenyakit.DataSource = table;
                dgvPenyakit.DataMember = "tpenyakit";
                dgvPenyakit.Columns[0].HeaderText = "ID";
                dgvPenyakit.Columns[1].HeaderText = "Nama Penyakit";
                Cursor = Cursors.Default;
            }
        }
    }
}
