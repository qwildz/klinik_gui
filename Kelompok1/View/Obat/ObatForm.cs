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
    public partial class ObatForm : Form
    {
        Obat obat;
        public ObatForm()
        {
            InitializeComponent();
            obat = new Obat();
        }

        private void ObatForm_Load(object sender, EventArgs e)
        {
            DataSet table = obat.LoadObat();
            dgvObat.DataSource = table;
            dgvObat.DataMember = "tobat";
            dgvObat.Columns[0].HeaderText = "ID";
            dgvObat.Columns[1].HeaderText = "Nama Obat";
            dgvObat.Columns[2].HeaderText = "Jenis Obat";
        }

        private void buttonCariObat_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string where = " WHERE 1=1 ";

            where += "AND nama_obat LIKE '%" + textBoxCariObat.Text + "%'";

            DataSet table = obat.LoadObat(where);
            dgvObat.DataSource = table;
            dgvObat.DataMember = "tobat";
            dgvObat.Columns[0].HeaderText = "ID";
            dgvObat.Columns[1].HeaderText = "Nama Meja";
            dgvObat.Columns[2].HeaderText = "Status Meja";
            Cursor = Cursors.Default;
        }

        private void buttonTambahObat_Click(object sender, EventArgs e)
        {
            FormObat f = new FormObat();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                ObatForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonUbahObat_Click(object sender, EventArgs e)
        {
            int id_obat = Convert.ToInt32(dgvObat.CurrentRow.Cells[0].Value);
            string nama_obat = Convert.ToString(dgvObat.CurrentRow.Cells[1].Value);
            string jenis_obat = Convert.ToString(dgvObat.CurrentRow.Cells[2].Value);
            object[] data = { id_obat, nama_obat, jenis_obat };
            FormObat f = new FormObat(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                ObatForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttonHapusObat_Click(object sender, EventArgs e)
        {
            int id_obat = Convert.ToInt32(dgvObat.CurrentRow.Cells[0].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (konfirmasi == DialogResult.Yes)
            {
                obat.DeleteObat(id_obat);

                Cursor = Cursors.WaitCursor;
                DataSet table = obat.LoadObat();
                dgvObat.DataSource = table;
                dgvObat.DataMember = "tobat";
                dgvObat.Columns[0].HeaderText = "ID";
                dgvObat.Columns[1].HeaderText = "Nama Obat";
                dgvObat.Columns[2].HeaderText = "Jenis Obat";
                Cursor = Cursors.Default;
            }
        } 

    }
}
