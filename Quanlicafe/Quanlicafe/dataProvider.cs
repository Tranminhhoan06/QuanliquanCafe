using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlicafe
{
    public class dataProvider
    {
        public void login(string id, string pass)
        {
            fLogin fl = new fLogin();
            fManager f = new fManager();
            if (id == "ADMIN" && pass == "1234")
                f.ShowDialog();
            else
                MessageBox.Show("Mật khẩu hoặc tên đăng nhập sai. Mời nhập lại");
        }
    }
}
