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
    public partial class FormPenyakit : Form
    {
        Penyakit penyakit;
        private string id_penyakit;
        bool update;
        public FormPenyakit()
        {
            InitializeComponent();
            penyakit = new Penyakit();
            textBoxnamapenyakit.Focus();

        }

        public FormPenyakit(object[] data)
        {
            InitializeComponent();
            penyakit = new Penyakit();
            id_penyakit = data[0].ToString();
            textBoxnamapenyakit.Text = data[1].ToString();

            update = true;
            labelJudul.Text = "Ubah Penyakit";
            this.Text = "Ubah Penyakit";
        }

        private void buttonsimpannamapenyakit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxnamapenyakit.Text == "")
                {
                    TampilanPesan.Warning("Nama Penyakit harus diisi.");
                    textBoxnamapenyakit.Focus();
                }
                
                else
                {
                   penyakit.nama_penyakit = textBoxnamapenyakit.Text;

                   int res;
                   if (update)
                   {
                       penyakit.id_penyakit = Convert.ToInt32(id_penyakit);

                       res = penyakit.UpdateObat();
                   }
                   else
                   {
                       res = penyakit.InsertPenyakit();
                   }

                   if (res == 1)
                    {
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
    }
}

