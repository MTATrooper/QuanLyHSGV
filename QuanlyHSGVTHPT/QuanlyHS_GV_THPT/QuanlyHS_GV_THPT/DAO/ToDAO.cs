using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyHS_GV_THPT.Models;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.DAO
{
    class ToDAO
    {
        private QuanlyHSGV db = new QuanlyHSGV();
        public List<TOBM> ListTOBM(string searchString)
        {
            var ToBM = db.TOBMs.ToList();
            if(!String.IsNullOrEmpty(searchString))
            {
                ToBM = db.TOBMs.Where(p => p.TENTO.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return ToBM;
        }
        public TOBM FindID(int id)
        {
            return db.TOBMs.Find(id);
        }
        public bool Insert(TOBM to)
        {
            try
            {
                db.TOBMs.Add(to);
                db.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Không thêm được");
                return false;
            }
        }
        public bool Edit(TOBM to, int ID)
        {
            try
            {
                var ToBMEntry = db.TOBMs.Find(ID);
                ToBMEntry.TENTO = to.TENTO;
                ToBMEntry.SOGV = to.SOGV;
                db.SaveChanges();
                return true;
            }
            catch {
                MessageBox.Show("Không sửa được");
                return false;
            }
        }
        public bool Delete(int ID)
        {
            try
            {
                var ToBM = db.TOBMs.Find(ID);
                db.TOBMs.Remove(ToBM);
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
