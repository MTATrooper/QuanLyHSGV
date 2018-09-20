using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanlyHS_GV_THPT.Models;

namespace QuanlyHS_GV_THPT.GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var acc = db.TAIKHOANs.SingleOrDefault(a => a.Username == txtusername.Text && a.Password == txtpass.Text);
            if(acc == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo!");
            }
            else
            {
                int id = acc.ID;
                int pq = acc.Permission;
                string username = acc.Username;
                FormMain form = new FormMain(id, pq, username);
                this.Hide();
                form.ShowDialog();
                txtusername.Text = txtpass.Text = "";
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}