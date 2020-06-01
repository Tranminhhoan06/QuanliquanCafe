using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using System.Data;
>>>>>>> Stashed changes

namespace Quanlicafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            fManager f = new fManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
=======
            string id = txbUserName.Text;
            string pass = txbPassword.Text;
            DataProvider d = new DataProvider();
            d.Login(id, pass);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txbUserName.Text = "ADMIN";
            txbPassword.Text = "12345678";
>>>>>>> Stashed changes
        }
    }
}
