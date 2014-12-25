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
    public partial class LoginForm : Form
    {
        User user;
        public LoginForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tboxUsername.Text;
                string password = tboxPassword.Text;

                object[] data = { username, password };

                if (user.LoginCek(data))
                    this.DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                TampilanPesan.Error(err.ToString());
            }
        }

    }
}
