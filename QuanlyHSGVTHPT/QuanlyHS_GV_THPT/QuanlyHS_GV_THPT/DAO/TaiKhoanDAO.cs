using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyHS_GV_THPT.Models;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class TaiKhoanDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public TAIKHOAN FindID(int id)
        {
            return db.TAIKHOANs.Find(id);
        }
        public bool Insert(TAIKHOAN tk)
        {
            try
            {
                db.TAIKHOANs.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(TAIKHOAN tk, int ID)
        {
            try
            {
                var TKEntry = db.TAIKHOANs.Find(ID);
                TKEntry.Username = tk.Username;
                TKEntry.Password = tk.Password;
                TKEntry.Permission = tk.Permission;
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không sửa được");
                return false;
            }
        }
        public bool Delete(int ID)
        {
            try
            {
                var tk = db.TAIKHOANs.Find(ID);
                db.TAIKHOANs.Remove(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Bạn không thể xóa mục này!");
                return false;
            }
        }
    }
}
