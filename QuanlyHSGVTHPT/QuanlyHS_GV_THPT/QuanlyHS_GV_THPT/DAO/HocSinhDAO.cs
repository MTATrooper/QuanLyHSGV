using QuanlyHS_GV_THPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class HocSinhDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<HOCSINH> ListHS(string searchString)
        {
            var lisths = db.HOCSINHs.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                lisths = db.HOCSINHs.Include("LOP").Where(p => p.HOTEN.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return lisths;
        }
        public HOCSINH FindID(int id)
        {
            return db.HOCSINHs.Find(id);
        }
        public bool Insert(HOCSINH hs)
        {
            try
            {
                db.HOCSINHs.Add(hs);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(HOCSINH hs, int ID)
        {
            try
            {
                var hsEntry = db.HOCSINHs.Find(ID);
                hsEntry.HOTEN = hs.HOTEN;
                hsEntry.NGAYSINH = hs.NGAYSINH;
                hsEntry.DIACHI = hs.DIACHI;
                hsEntry.LOPID = hs.LOPID;
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
                var hs = db.HOCSINHs.Find(ID);
                db.HOCSINHs.Remove(hs);
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
