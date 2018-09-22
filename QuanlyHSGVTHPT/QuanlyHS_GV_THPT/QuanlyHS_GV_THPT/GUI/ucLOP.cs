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
    public partial class ucLOP : UserControl
    {
        private LOPDAO lopDAO = new LOPDAO();
        private int index = 0;
        public ucLOP(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void Hienthi()
        {
            try
            {
                LOP lop = GetitembyID();
                txtTen.Text = lop.TENLOP;
                txtSS.Text = lop.SYSO.ToString();
            }
            catch { }
        }
        private LOP GetitembyID()
        {
            try
            {
                int id = (int)gridLOP.GetRowCellValue(gridLOP.FocusedRowHandle, "ID");
                return lopDAO.FindID(id);
            }
            catch { return new LOP(); }
        }

        private void ucLOP_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = lopDAO.ListLOP("");
            Hienthi();
        }

        private void gridLOP_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridLOP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridLOP_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            txtTen.Text = txtSS.Text = string.Empty;
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
                int cur = gridLOP.FocusedRowHandle;
                LOP lop = GetitembyID();
                bool check = lopDAO.Delete(lop.ID);
                int i = cur == gridLOP.RowCount - 1 ? gridLOP.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = lopDAO.ListLOP("");
                    if (gridLOP.RowCount > 1) gridLOP.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LOP lop = new LOP();
            lop.TENLOP = txtTen.Text;
            lop.SYSO = Convert.ToInt32(txtSS.Text);
            int i = index == 1 ? gridLOP.RowCount : gridLOP.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = lopDAO.Insert(lop);
            else if (index == 2)
            {
                int id = GetitembyID().ID;
                check = lopDAO.Edit(lop, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = lopDAO.ListLOP("");
                gridLOP.FocusedRowHandle = i;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gridControl.DataSource = lopDAO.ListLOP(txtSearch.Text);
        }
    }
}
