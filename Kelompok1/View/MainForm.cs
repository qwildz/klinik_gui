using System;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            HomeForm f = new HomeForm();
            f.MdiParent = this;
            f.Show();
        }

        private void dataUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Session.isAdmin())     
            {
                TampilanPesan.Warning("Maaf anda tidak bisa mengakses menu ini");
                return;
            }

            UserForm f = new UserForm();
            f.ShowDialog();
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(Session.id_user);
            int id_dokter = Convert.ToInt32(Session.id_dokter);
            string username = Convert.ToString(Session.username);
            string level = Convert.ToString(Session.level);

            object[] data = { id_user, username, level, id_dokter };
            FormUser f = new FormUser(data);
            f.ChangePassword();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fe = new About();
            fe.MdiParent = this.MdiParent;
            fe.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Apakah anda ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (konfirmasi == DialogResult.Yes)
            {
                Application.Restart();
            }
            
        }
    }
}
