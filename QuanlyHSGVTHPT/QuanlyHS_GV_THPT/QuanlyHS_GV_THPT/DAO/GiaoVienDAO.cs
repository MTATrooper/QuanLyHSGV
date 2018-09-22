using QuanlyHS_GV_THPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class GiaoVienDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<GIAOVIEN> ListGV(string searchString)
        {
            var listgv = db.GIAOVIENs.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                listgv = db.GIAOVIENs.Include("TOBM").Where(p => p.TENGV.ToUpper().Contains(searchString.ToUpper()) || p.TOBM.TENTO.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return listgv;
        }
        public GIAOVIEN FindID(int id)
        {
            return db.GIAOVIENs.Find(id);
        }
        public bool Insert(GIAOVIEN gv)
        {
            try
            {
                db.GIAOVIENs.Add(gv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(GIAOVIEN gv, int ID)
        {
            try
            {
                var GVEntry = db.GIAOVIENs.Find(ID);
                GVEntry.TENGV = gv.TENGV;
                GVEntry.NGAYSINH = gv.NGAYSINH;
                GVEntry.SDT = gv.SDT;
                GVEntry.DIACHI = gv.DIACHI;
                GVEntry.TOBMID = gv.TOBMID;
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
                var GV = db.GIAOVIENs.Find(ID);
                db.GIAOVIENs.Remove(GV);
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
