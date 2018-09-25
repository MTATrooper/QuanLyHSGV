using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyHS_GV_THPT.DAO;
using QuanlyHS_GV_THPT.Models;

namespace QuanlyHS_GV_THPT.GUI
{
    public partial class ucTo : UserControl
    {
        private ToDAO to = new ToDAO();
        private int index = 0;
        public ucTo(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void Hienthi() {
            try
            {
                TOBM to = GetitembyID();
                txtTen.Text = to.TENTO;
                txtSogv.Text = to.SOGV.ToString();
            }
            catch { }
        }
        private TOBM GetitembyID()
        {
            try
            {
                int id = (int) gridTO.GetRowCellValue(gridTO.FocusedRowHandle, "ID");
                return to.FindID(id);
            }
            catch { return new TOBM(); }
        }
        private void ucTo_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = to.ListTOBM("");
            Hienthi();
        }

        private void gridTO_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridTO_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            txtTen.Text = txtSogv.Text = string.Empty;
            txtTen.Focus();
            btnSua.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            index = 2;
            //txtTen.Text = txtSogv.Text = string.Empty;
            txtTen.Focus();
            btnThem.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mục này?", "Verify!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cur = gridTO.FocusedRowHandle;
                TOBM tobm = GetitembyID();
                bool check = to.Delete(tobm.ID);
                int i = cur == gridTO.RowCount - 1 ? gridTO.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = to.ListTOBM("");
                    if (gridTO.RowCount > 1) gridTO.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TOBM tobm = new TOBM();
            tobm.TENTO = txtTen.Text;
            tobm.SOGV = Convert.ToInt32(txtSogv.Text);
            int i = index == 1 ? gridTO.RowCount : gridTO.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = to.Insert(tobm);
            else if (index == 2)
            {
                int id = GetitembyID().ID;
                check = to.Edit(tobm, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = to.ListTOBM("");
                gridTO.FocusedRowHandle = i;
            }
            else MessageBox.Show("Không thực hiện được thao tác!", "Thông báo!");
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gridControl.Enabled = true;
            index = 0;
            Hienthi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = gridControl.Enabled = true;
            index = 0;
            Hienthi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gridControl.DataSource = to.ListTOBM(txtSearch.Text);
        }
    }
}
