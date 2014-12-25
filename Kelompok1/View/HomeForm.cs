using System;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PasienForm fp = new PasienForm();
            fp.MdiParent = this.MdiParent;
            fp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DokterForm fd = new DokterForm();
            fd.MdiParent = this.MdiParent;
            fd.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Session.isResepsionis())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa mengakses menu ini");
                return;
            }
            ObatForm fo = new ObatForm();
            fo.MdiParent = this.MdiParent;
            fo.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Session.isResepsionis())
            {
                TampilanPesan.Warning("Maaf anda tidak bisa mengakses menu ini");
                return;
            }
            PenyakitForm fe = new PenyakitForm();
            fe.MdiParent = this.MdiParent;
            fe.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            About fa = new About();
            fa.MdiParent = this.MdiParent;
            fa.Show();
        }

        
    }
}
