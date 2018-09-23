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
    public partial class ucHS : UserControl
    {
        private HocSinhDAO hsDAO = new HocSinhDAO();
        private int index = 0;
        public ucHS(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private HOCSINH GetItembyID()
        {
            try
            {
                int id = (int)gridHS.GetRowCellValue(gridHS.FocusedRowHandle, "ID");
                return hsDAO.FindID(id);
            }
            catch { return new HOCSINH(); }
        }
        private void Hienthi()
        {
            try
            {
                HOCSINH hs = GetItembyID();
                txtTen.Text = hs.HOTEN;
                txtDC.Text = hs.DIACHI;
                dateNS.Text = hs.NGAYSINH.ToString();
                cbBLOP.Text = hs.LOP.TENLOP;
            }
            catch { }
        }

        private void ucHS_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = hsDAO.ListHS("");
            LOPDAO lopDAO = new LOPDAO();
            cbBLOP.DataSource = lopDAO.ListLOP("");
            cbBLOP.ValueMember = "ID";
            cbBLOP.DisplayMember = "TENLOP";
            Hienthi();
        }

        private void gridHS_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridHS_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridHS_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            txtTen.Text = txtDC.Text = string.Empty;
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
                int cur = gridHS.FocusedRowHandle;
                HOCSINH hs = GetItembyID();
                bool check = hsDAO.Delete(hs.ID);
                int i = cur == gridHS.RowCount - 1 ? gridHS.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = hsDAO.ListHS("");
                    if (gridHS.RowCount > 1) gridHS.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HOCSINH hs = new HOCSINH();
            hs.HOTEN = txtTen.Text;
            hs.NGAYSINH = Convert.ToDateTime(dateNS.Text);
            hs.DIACHI = txtDC.Text;
            hs.LOPID = (int)cbBLOP.SelectedValue;
            int i = index == 1 ? gridHS.RowCount : gridHS.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = hsDAO.Insert(hs);
            else if (index == 2)
            {
                int id = GetItembyID().ID;
                check = hsDAO.Edit(hs, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = hsDAO.ListHS("");
                gridHS.FocusedRowHandle = i;
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
            gridControl.DataSource = hsDAO.ListHS(txtSearch.Text);
        }
    }
}
