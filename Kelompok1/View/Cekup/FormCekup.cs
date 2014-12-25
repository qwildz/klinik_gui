using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kelompok1
{
    public partial class FormCekup : Form
    {
        Penyakit penyakit = new Penyakit();
        Obat obat = new Obat();
        Cekup cekup = new Cekup();

        DataSet datapenyakit, dataobat;
        int id_pasien;

        public FormCekup(object[] data)
        {
            InitializeComponent();

            txtNamaPasien.Text = data[1].ToString();

            id_pasien = Convert.ToInt32(data[0]);

            txtTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void FormCekup_Load(object sender, EventArgs e)
        {
            datapenyakit = penyakit.LoadPenyakit();
            dataobat = obat.LoadObat();

            cboxPenyakit.DataSource = datapenyakit.Tables["tpenyakit"];
            cboxPenyakit.ValueMember = "id_penyakit";
            cboxPenyakit.DisplayMember = "nama_penyakit";

            cboxObat.DataSource = dataobat.Tables["tobat"];
            cboxObat.ValueMember = "id_obat";
            cboxObat.DisplayMember = "nama_obat";
            
        }

        private void buttonTambahPenyakit_Click(object sender, EventArgs e)
        {
            int pos = cboxPenyakit.SelectedIndex;

            foreach (DataGridViewRow row in dgvPenyakit.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(datapenyakit.Tables["tpenyakit"].Rows[pos]["id_penyakit"].ToString()))
                {
                    TampilanPesan.Warning("Penyakit sudah ditambahkan sebelumnya.");
                    return;
                }
            }

            dgvPenyakit.Rows.Add();
            dgvPenyakit[0, dgvPenyakit.RowCount - 1].Value = datapenyakit.Tables["tpenyakit"].Rows[pos]["id_penyakit"];
            dgvPenyakit[1, dgvPenyakit.RowCount - 1].Value = datapenyakit.Tables["tpenyakit"].Rows[pos]["nama_penyakit"];
        }

        private void buttonTambahObat_Click(object sender, EventArgs e)
        {
            int pos = cboxObat.SelectedIndex;

            if (tboxDosis.Text == "")
            {
                TampilanPesan.Warning("Harap isi dosis obat.");
                tboxDosis.Focus();
                return;
            }

            foreach (DataGridViewRow row in dgvObat.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(dataobat.Tables["tobat"].Rows[pos]["id_obat"].ToString()))
                {
                    TampilanPesan.Warning("Obat sudah ditambahkan sebelumnya.");
                    return;
                }
            }

            dgvObat.Rows.Add();
            dgvObat[0, dgvObat.RowCount - 1].Value = dataobat.Tables["tobat"].Rows[pos]["id_obat"];
            dgvObat[1, dgvObat.RowCount - 1].Value = dataobat.Tables["tobat"].Rows[pos]["nama_obat"];
            dgvObat[2, dgvObat.RowCount - 1].Value = tboxDosis.Text;

            tboxDosis.Text = "";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxBiaya.Text == "")
                {
                    TampilanPesan.Warning("Biaya cekup harus diisi.");
                    tboxBiaya.Focus();
                }
                else
                {
                    cekup.id_pasien = id_pasien;
                    cekup.id_dokter = Session.id_dokter;
                    cekup.tanggal_cekup = DateTime.Now.ToString("yyyy-MM-dd");
                    cekup.biaya_cekup = Convert.ToInt32(tboxBiaya.Text);

                    long id_cekup = cekup.InsertCekup();
                    if (id_cekup != 0)
                    {
                        foreach (DataGridViewRow row in dgvPenyakit.Rows)
                        {
                            int id_penyakit = Convert.ToInt32(row.Cells[0].Value);
                            cekup.InsertPenyakit(id_penyakit);
                        }

                        foreach (DataGridViewRow row in dgvObat.Rows)
                        {
                            int id_obat = Convert.ToInt32(row.Cells[0].Value);
                            string dosis = row.Cells[2].Value.ToString();
                            cekup.InsertObat(id_obat, dosis);
                        }

                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception err)
            {
                TampilanPesan.Error(err.ToString());
            }
        }

        private void dgvPenyakit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                dgvPenyakit.Rows.Remove(dgvPenyakit.CurrentRow);
            }
        }

        private void dgvObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                dgvObat.Rows.Remove(dgvObat.CurrentRow);
            }
        }

        

        
    }
}
