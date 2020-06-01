using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlicafe
{
    public class DataProvider
    {
        public void Login(string id, string pass)
        {
                if (id == "ADMIN" && pass == "12345678")
                {
                    fManager f = new fManager();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập sai.Mời nhập lại");
        }
    }
}
