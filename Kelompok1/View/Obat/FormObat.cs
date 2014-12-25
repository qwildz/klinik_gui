using System;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class FormObat : Form
    {
        Obat obat;
        private string id_obat;
        bool update;
        public FormObat()
        {
            InitializeComponent();
            obat = new Obat();
            textBoxNObat.Focus();
        }

        public FormObat(object[] data)
        {
            InitializeComponent();
            obat = new Obat();
            id_obat = data[0].ToString();
            textBoxNObat.Text = data[1].ToString();
            comboBoxJObat.Text = data[2].ToString();

            update = true;
            labelJudul.Text = "Ubah Obat";
            this.Text = "Ubah Obat";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNObat.Text == "")
                {
                    TampilanPesan.Warning("Nama obat harus diisi.");
                    textBoxNObat.Focus();
                }
                else if (comboBoxJObat.Text == "")
                {
                    TampilanPesan.Warning("Jenis obat harus diisi.");
                    comboBoxJObat.Focus();
                }
                else
                {
                    obat.nama_obat = textBoxNObat.Text;
                    obat.jenis_obat = comboBoxJObat.Text;
                    int res;
                    if (update)
                    {
                        obat.id_obat = Convert.ToInt32(id_obat);

                        res = obat.UpdateObat();
                    }
                    else
                    {
                        res = obat.InsertObat();
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
