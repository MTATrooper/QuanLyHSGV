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
    public partial class ucMH : UserControl
    {
        private MonHocDAO mhDAO = new MonHocDAO();
        private int index = 0;
        public ucMH(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private MONHOC GetItembyID()
        {
            try
            {
                int id = (int)gridMH.GetRowCellValue(gridMH.FocusedRowHandle, "ID");
                return mhDAO.FindID(id);
            }
            catch { return new MONHOC(); }
        }
        private void Hienthi()
        {
            try
            {
                MONHOC mh = GetItembyID();
                txtTen.Text = mh.TENMH;
                cbBTO.Text = mh.TOBM.TENTO;
            }
            catch { }
        }

        private void ucMH_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = mhDAO.ListMH("");
            ToDAO toDAO = new ToDAO();
            cbBTO.DataSource = toDAO.ListTOBM("");
            cbBTO.ValueMember = "ID";
            cbBTO.DisplayMember = "TENTO";
            Hienthi();
        }

        private void gridMH_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridMH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridMH_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            txtTen.Text = string.Empty;
            txtTen.Focus();
            btnSua.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            index = 2;
            txtTen.Focus();
            btnThem.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mục này?", "Verify!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cur = gridMH.FocusedRowHandle;
                MONHOC mh = GetItembyID();
                bool check = mhDAO.Delete(mh.ID);
                int i = cur == gridMH.RowCount - 1 ? gridMH.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = mhDAO.ListMH("");
                    if (gridMH.RowCount > 1) gridMH.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MONHOC mh = new MONHOC();
            mh.TENMH = txtTen.Text;
            mh.TOBMID = (int)cbBTO.SelectedValue;
            int i = index == 1 ? gridMH.RowCount : gridMH.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = mhDAO.Insert(mh);
            else if (index == 2)
            {
                int id = GetItembyID().ID;
                check = mhDAO.Edit(mh, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = mhDAO.ListMH("");
                gridMH.FocusedRowHandle = i;
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
            gridControl.DataSource = mhDAO.ListMH(txtSearch.Text);
        }
    }
}
