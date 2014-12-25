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
    public partial class UserForm : Form
    {
        User user;
        public UserForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            DataSet table = user.LoadUser();
            dgvPenyakit.DataSource = table;
            dgvPenyakit.DataMember = "tuser";
        }

        private void buttonHapusPenyakit_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(dgvPenyakit.CurrentRow.Cells["id_user"].Value);
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (konfirmasi == DialogResult.Yes)
            {
                user.DeleteUser(id_user);

                UserForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void buttonUbahPenyakit_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(dgvPenyakit.CurrentRow.Cells["id_user"].Value);
            int id_dokter = (! dgvPenyakit.CurrentRow.Cells["id_dokter"].Value.GetType().ToString().Equals("System.DBNull")) ? Convert.ToInt32(dgvPenyakit.CurrentRow.Cells["id_dokter"].Value) : 0;
            string username = Convert.ToString(dgvPenyakit.CurrentRow.Cells["username"].Value);
            string level = Convert.ToString(dgvPenyakit.CurrentRow.Cells["level"].Value);

            object[] data = { id_user, username, level, id_dokter };
            FormUser f = new FormUser(data);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                UserForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                UserForm_Load(sender.ToString(), EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(dgvPenyakit.CurrentRow.Cells["id_user"].Value);
            int id_dokter = (!dgvPenyakit.CurrentRow.Cells["id_dokter"].Value.GetType().ToString().Equals("System.DBNull")) ? Convert.ToInt32(dgvPenyakit.CurrentRow.Cells["id_dokter"].Value) : 0;
            string username = Convert.ToString(dgvPenyakit.CurrentRow.Cells["username"].Value);
            string level = Convert.ToString(dgvPenyakit.CurrentRow.Cells["level"].Value);

            object[] data = { id_user, username, level, id_dokter };
            FormUser f = new FormUser(data);
            f.ChangePassword();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                UserForm_Load(sender.ToString(), EventArgs.Empty);
        }


    }
}
