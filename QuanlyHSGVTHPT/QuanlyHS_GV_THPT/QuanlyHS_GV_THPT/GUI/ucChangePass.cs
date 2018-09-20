using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanlyHS_GV_THPT.DAO;
using QuanlyHS_GV_THPT.Models;

namespace QuanlyHS_GV_THPT.GUI
{
    public partial class ucChangePass : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        private TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        private string username = "";
        private int pq = 0;
        private int id = 0;
        public ucChangePass(int id, int pq, string username)
        {
            InitializeComponent();
            this.id = id;
            this.pq = pq;
            this.username = username;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.Text != txtXNMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo!");
            }
            else
            {
                var acc = db.TAIKHOANs.SingleOrDefault(a => a.Username == username);
                if (acc.Password != txtMKcu.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                }
                else
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.Username = username;
                    tk.Password = txtMKmoi.Text;
                    tk.Permission = pq;
                    bool check = tkDAO.Edit(tk, id);
                    if (check == true)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được mật khẩu!");
                    }
                }
            }
        }
    }
}
