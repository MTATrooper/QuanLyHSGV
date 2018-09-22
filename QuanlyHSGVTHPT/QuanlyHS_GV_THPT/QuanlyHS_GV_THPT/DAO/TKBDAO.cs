using QuanlyHS_GV_THPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class TKBDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<THOIKHOABIEU> ListTKB(string searchString)
        {
            var listTKB = db.THOIKHOABIEUx.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                listTKB = db.THOIKHOABIEUx.Include("GIAOVIEN").Include("LOP").Where(p => p.GIAOVIEN.TENGV.ToUpper().Contains(searchString.ToUpper()) || p.LOP.TENLOP.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return listTKB;
        }
        public THOIKHOABIEU FindID(int id)
        {
            return db.THOIKHOABIEUx.Find(id);
        }
        public bool Insert(THOIKHOABIEU tkb)
        {
            try
            {
                db.THOIKHOABIEUx.Add(tkb);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(THOIKHOABIEU tkb, int ID)
        {
            try
            {
                var TKBEntry = db.THOIKHOABIEUx.Find(ID);
                TKBEntry.THU = tkb.THU;
                TKBEntry.TIET = tkb.TIET;
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
                var tkb = db.THOIKHOABIEUx.Find(ID);
                db.THOIKHOABIEUx.Remove(tkb);
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
