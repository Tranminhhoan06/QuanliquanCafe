using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< Updated upstream
using System.Data.SqlClient;
using Quanlicafe.DAO;
=======
>>>>>>> Stashed changes

namespace Quanlicafe
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
<<<<<<< Updated upstream
            load();
        }

        void load()
        {
            string query = "SELECT * FROM dbo.TAIKHOAN";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.Execute(query);
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThôngtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile f = new fProfile();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();
        }
=======
        }


>>>>>>> Stashed changes

    }
}
