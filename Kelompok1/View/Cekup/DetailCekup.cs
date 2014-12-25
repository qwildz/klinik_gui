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
    public partial class DetailCekup : Form
    {
        Cekup cekup = new Cekup();
        int id;
        public DetailCekup(int id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void DetailCekup_Load(object sender, EventArgs e)
        {
            DataSet detail = cekup.LoadDetailCekup(id);

            DataRow datacekup = detail.Tables["tcekup"].Rows[0];

            txtNamaPasien.Text = datacekup["nama_pasien"].ToString();
            txtNamaDokter.Text = datacekup["nama_dokter"].ToString();
            txtSpesialis.Text = datacekup["spesialis"].ToString();
            txtBiaya.Text = "Rp. " + datacekup["biaya_cekup"].ToString();
            txtTanggal.Text = DateTime.Parse(datacekup["tanggal_cekup"].ToString()).ToString("dd-MM-yyyy");

            dgvPenyakit.DataSource = detail;
            dgvPenyakit.DataMember = "tcekuppenyakit";

            dgvObat.DataSource = detail;
            dgvObat.DataMember = "tresep";
        }
    }
}
