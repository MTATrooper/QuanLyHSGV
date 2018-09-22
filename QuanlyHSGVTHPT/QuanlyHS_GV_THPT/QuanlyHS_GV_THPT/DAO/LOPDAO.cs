using QuanlyHS_GV_THPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class LOPDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<LOP> ListLOP(string searchString)
        {
            var listlop = db.LOPs.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                listlop = db.LOPs.Where(p => p.TENLOP.ToUpper().Contains(searchString)).ToList();
            }
            return listlop;
        }
        public LOP FindID(int id)
        {
            return db.LOPs.Find(id);
        }
        public bool Insert(LOP lop)
        {
            try
            {
                db.LOPs.Add(lop);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(LOP lop, int ID)
        {
            try
            {
                var LOPEntry = db.LOPs.Find(ID);
                LOPEntry.TENLOP = lop.TENLOP;
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
                var lop = db.LOPs.Find(ID);
                db.LOPs.Remove(lop);
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
