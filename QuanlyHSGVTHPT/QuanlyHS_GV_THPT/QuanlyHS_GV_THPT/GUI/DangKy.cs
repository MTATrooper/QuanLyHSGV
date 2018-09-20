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
using QuanlyHS_GV_THPT.DAO;
using QuanlyHS_GV_THPT.Models;

namespace QuanlyHS_GV_THPT.GUI
{
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        private TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        private QuanlyHSGV db = new QuanlyHSGV();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btndky_Click(object sender, EventArgs e)
        {
            if(txtpass.Text != txtxn.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo!");
            }
            else
            {
                var acc = db.TAIKHOANs.SingleOrDefault(a => a.Username.ToUpper() == txtusername.Text.ToUpper());
                if(acc != null)
                {
                    MessageBox.Show("Tên người dùng đã được đăng ký. Vui lòng chọn tên khác!", "Thông báo");
                }
                else
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.Username = txtusername.Text;
                    tk.Password = txtpass.Text;
                    if (radioAdmin.Checked == true) tk.Permission = 1;
                    else tk.Permission = 0;
                    bool check = tkDAO.Insert(tk);
                    if(check == true)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tạo được tài khoản!");
                    }
                    this.Close();
                }
            }
        }
    }
}