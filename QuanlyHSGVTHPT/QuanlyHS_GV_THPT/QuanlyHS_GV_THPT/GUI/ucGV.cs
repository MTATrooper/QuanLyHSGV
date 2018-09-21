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
    public partial class ucGV : UserControl
    {
        private GiaoVienDAO gvDAO = new GiaoVienDAO();
        private int index = 0;
        public ucGV(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private GIAOVIEN GetItembyID()
        {
            try
            {
                int id = (int)gridGV.GetRowCellValue(gridGV.FocusedRowHandle, "ID");
                return gvDAO.FindID(id);
            }
            catch { return new GIAOVIEN(); }
        }
        private void Hienthi()
        {
            try
            {
                GIAOVIEN gv = GetItembyID();
                txtTen.Text = gv.TENGV;
                txtSDT.Text = gv.SDT;
                txtDC.Text = gv.DIACHI;
                dateNS.Text = gv.NGAYSINH.ToString();
                cbBTO.Text = gv.TOBM.TENTO;
            }
            catch { }
        }

        private void ucGV_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = gvDAO.ListGV("");
            ToDAO toDAO = new ToDAO();
            cbBTO.DataSource = toDAO.ListTOBM("");
            cbBTO.ValueMember = "ID";
            cbBTO.DisplayMember = "TENTO";
            Hienthi();
        }

        private void gridGV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridGV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridGV_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            txtTen.Text = txtSDT.Text = txtDC.Text = string.Empty;
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
                int cur = gridGV.FocusedRowHandle;
                GIAOVIEN gv = GetItembyID();
                bool check = gvDAO.Delete(gv.ID);
                int i = cur == gridGV.RowCount - 1 ? gridGV.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = gvDAO.ListGV("");
                    if (gridGV.RowCount > 1) gridGV.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GIAOVIEN gv = new GIAOVIEN();
            gv.TENGV = txtTen.Text;
            gv.NGAYSINH = Convert.ToDateTime(dateNS.Text);
            gv.SDT = txtSDT.Text;
            gv.DIACHI = txtDC.Text;
            gv.TOBMID = (int) cbBTO.SelectedValue;
            int i = index == 1 ? gridGV.RowCount : gridGV.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = gvDAO.Insert(gv);
            else if (index == 2)
            {
                int id = GetItembyID().ID;
                check = gvDAO.Edit(gv, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = gvDAO.ListGV("");
                gridGV.FocusedRowHandle = i;
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
            gridControl.DataSource = gvDAO.ListGV(txtSearch.Text);
        }
    }
}
