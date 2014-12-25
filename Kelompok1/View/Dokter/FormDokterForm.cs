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
    public partial class FormDokterForm : Form
    {
        Dokter dokter;
        private string id_dokter;
        bool update;
        public FormDokterForm()
        {
            InitializeComponent();
            dokter = new Dokter();
            textBoxNamaDokter.Focus();
        }
         public FormDokterForm(object[] data)
        {
            InitializeComponent();
            dokter = new Dokter();
            id_dokter = data[0].ToString();
            textBoxNamaDokter.Text = data[1].ToString();
            textBoxSpesialis.Text = data[2].ToString();
            textBoxAlamat.Text = data[3].ToString();
            textBoxNoTelp.Text = data[4].ToString();
            update = true;
            labelTambah.Text = "Ubah Dokter";
            this.Text = "Ubah Dokter";

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaDokter.Text == "")
                {
                    MessageBox.Show("Warning : Nama dokter harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNamaDokter.Focus();
                }
                else if (textBoxSpesialis.Text == "")
                {
                    MessageBox.Show("Warning : Jenis spesialis dokter harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxSpesialis.Focus();
                }
                else if (textBoxAlamat.Text == "")
                {
                    MessageBox.Show("Warning : Alamat dokter harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAlamat.Focus();
                }
                else if (textBoxNoTelp.Text == "")
                {
                    MessageBox.Show("Warning : No. Telepon dokter harus di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNoTelp.Focus();
                }
                else
                {
                    if (update)
                    {
                        int.TryParse(this.id_dokter, out dokter.id_dokter);
                        dokter.nama_dokter = textBoxNamaDokter.Text;
                        dokter.spesialis = textBoxSpesialis.Text;
                        dokter.alamat = textBoxAlamat.Text;
                        dokter.no_telepon = textBoxNoTelp.Text;

                        int res = dokter.UpdateDokter();

                        if (res == 1)
                        {
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        dokter.nama_dokter = textBoxNamaDokter.Text;
                        dokter.spesialis = textBoxSpesialis.Text;
                        dokter.alamat = textBoxAlamat.Text;
                        dokter.no_telepon = textBoxNoTelp.Text;

                        int res = dokter.InsertDokter();

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
                MessageBox.Show("Error : " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNoTelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSimpan_Click(sender.ToString(), EventArgs.Empty);
            }

        }

        
    }
}
