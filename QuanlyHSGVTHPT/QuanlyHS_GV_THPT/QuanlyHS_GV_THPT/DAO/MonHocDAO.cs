using QuanlyHS_GV_THPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class MonHocDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<MONHOC> ListMH(string searchString)
        {
            var listMH = db.MONHOCs.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                listMH = db.MONHOCs.Where(p => p.TENMH.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return listMH;
        }
        public MONHOC FindID(int id)
        {
            return db.MONHOCs.Find(id);
        }
        public bool Insert(MONHOC mon)
        {
            try
            {
                db.MONHOCs.Add(mon);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(MONHOC mon, int ID)
        {
            try
            {
                var MONHOCEntry = db.MONHOCs.Find(ID);
                MONHOCEntry.TENMH = mon.TENMH;
                MONHOCEntry.TOBMID = mon.TOBMID;
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
                var mon = db.MONHOCs.Find(ID);
                db.MONHOCs.Remove(mon);
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
