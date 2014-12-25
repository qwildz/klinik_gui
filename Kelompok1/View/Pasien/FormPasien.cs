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
    public partial class FormPasien : Form
    {
        Pasien pasien;
        private string id_pasien;
        bool update;
        public FormPasien()
        {
            InitializeComponent();
            pasien = new Pasien();
            textBoxNama.Focus();
        }

        public FormPasien(object[] data)
        {
            InitializeComponent();
            pasien = new Pasien();
            id_pasien = data[0].ToString();
            textBoxNama.Text = data[1].ToString();
            comboBoxJenisKelamin.Text = data[2].ToString();
            dateTimePickerLahir.Text = data[3].ToString();
            textBoxAlamat.Text = data[4].ToString();
            comboBoxGolDarah.Text = data[5].ToString();
            textBoxNoTlp.Text = data[6].ToString();

            update = true;
            labelJudul.Text = "Ubah Pasien";
            this.Text = "Ubah Pasien";
            
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text == "")
                {
                    TampilanPesan.Warning("Nama harus diisi.");
                    textBoxNama.Focus();
                }
                else if (textBoxAlamat.Text == "")
                {
                    TampilanPesan.Warning("Alamat harus diisi.");
                    textBoxAlamat.Focus();
                }
                else if (dateTimePickerLahir.Text == "")
                {
                    TampilanPesan.Warning("Tanggal Lahir harus diisi.");
                    dateTimePickerLahir.Focus();
                }
               
                else if (textBoxNoTlp.Text == "")
                {
                    TampilanPesan.Warning("Nomor Telepon harus diisi.");
                    textBoxNoTlp.Focus();
                }
                else
                {
                    if (update)
                    {
                        int.TryParse(this.id_pasien, out pasien.id_pasien);
                        pasien.nama_pasien = textBoxNama.Text;
                        pasien.jenis_kelamin = comboBoxJenisKelamin.Text;
                        pasien.tgl_lahir = dateTimePickerLahir.Value.ToString("yyyy-MM-dd");
                        pasien.alamat = textBoxAlamat.Text;
                        pasien.gol_darah = comboBoxGolDarah.Text;
                        pasien.no_telepon = textBoxNoTlp.Text;

                        int res = pasien.UpdatePasien();
                        if (res == 1)
                        {
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        pasien.nama_pasien = textBoxNama.Text;
                        pasien.jenis_kelamin = comboBoxJenisKelamin.Text;
                        pasien.tgl_lahir = dateTimePickerLahir.Value.ToString("yyyy-MM-dd");
                        pasien.alamat = textBoxAlamat.Text;
                        pasien.gol_darah = comboBoxGolDarah.Text;
                        pasien.no_telepon = textBoxNoTlp.Text;

                        int res = pasien.InsertPasien();
                        if (res == 1)
                        {
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
               
                }
            }
            catch (Exception err)
            {
                TampilanPesan.Error(err.ToString());
            }
        }
    }
}
