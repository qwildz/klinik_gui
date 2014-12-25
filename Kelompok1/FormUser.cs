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
    public partial class FormUser : Form
    {
        User user;
        Dokter dokter;
        private string id_user;
        private string username;
        bool update, chgpassword;
        public FormUser()
        {
            InitializeComponent();
            user = new User();
            dokter = new Dokter();
        }

        public FormUser(object[] data)
        {
            InitializeComponent();
            user = new User();
            dokter = new Dokter();
            id_user = data[0].ToString();
            username = data[1].ToString();
            tboxUsername.Text = data[1].ToString();
            cboxLevel.Text = data[2].ToString();
            cboxDokter.SelectedValue = Convert.ToInt32(data[3]);
            tboxPassword.ReadOnly = true;
            tboxPasswordKonfirmasi.ReadOnly = true;

            update = true;
            this.Text = "Update User";
            labelJudul.Text = "Update User";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxUsername.Text == "")
                {
                    TampilanPesan.Warning("Username harus diisi.");
                    tboxUsername.Focus();
                }
                else if(tboxPassword.Text == "" && !update)
                {
                    TampilanPesan.Warning("Password harus diisi.");
                    tboxPasswordKonfirmasi.Focus();
                }
                else if (tboxPasswordKonfirmasi.Text == "" && !update)
                {
                    TampilanPesan.Warning("Konfirmasi Password harus diisi.");
                    tboxPasswordKonfirmasi.Focus();
                }
                else if (tboxPassword.Text != tboxPasswordKonfirmasi.Text && !update)
                {
                    TampilanPesan.Warning("Password tidak cocok.");
                    tboxPassword.Focus();
                }
                else if (cboxLevel.Text == "dokter" && Convert.ToInt32(cboxDokter.SelectedValue) == 0)
                {
                    TampilanPesan.Warning("Dokter harus dipilih.");
                    cboxDokter.Focus();                        
                }
                else
                {
                    if (chgpassword)
                    {
                        user.password = tboxPassword.Text;
                        user.id_user = Convert.ToInt32(id_user);
                        int ress = user.UpdatePassword();

                        if (ress == 1)
                        {
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                        return;
                    }

                    if (username != tboxUsername.Text)
                    {
                        if (user.CekUsername(tboxUsername.Text))
                        {
                            TampilanPesan.Warning("Username tidak tersedia.");
                            tboxUsername.Focus();
                            return;
                        }
                    }
                    user.username = tboxUsername.Text;
                    user.password = tboxPassword.Text;
                    user.level = cboxLevel.Text;
                    if (cboxLevel.Text == "dokter")
                        user.id_dokter = Convert.ToInt32(cboxDokter.SelectedValue);
                    else
                        user.id_dokter = 0;

                    int res;
                    if (update)
                    {
                        user.id_user = Convert.ToInt32(id_user);
                        res = user.UpdateUser();
                    }
                    else
                    {
                        res = user.InsertUser();
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

        private void FormUser_Load(object sender, EventArgs e)
        {
            DataSet data = dokter.LoadDokter();
            DataTable datadokter = data.Tables["tdokter"];

            //DataRow kosong = datadokter.Rows[0];
            
            //kosong["id_dokter"] = 0;
            //kosong["nama_dokter"] = "{Bukan Dokter}";
            //kosong["spesialis"] = "-";
            //datadokter.Rows.InsertAt(kosong, 0);

            cboxDokter.DataSource = datadokter;
            cboxDokter.ValueMember = "id_dokter";
            cboxDokter.DisplayMember = "nama_dokter";
        }

        public void ChangePassword()
        {
            tboxUsername.Visible = false;
            lUsername.Visible = false;
            tboxPassword.ReadOnly = false;
            tboxPasswordKonfirmasi.ReadOnly = false;
            cboxLevel.Visible = false;
            lLevel.Visible = false;
            cboxDokter.Visible = false;
            lDokter.Visible = false;
            chgpassword = true;

            this.Text = "Update Password";
            labelJudul.Text = "Update Password";
        }
    }
}
