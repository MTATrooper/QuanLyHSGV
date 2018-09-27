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
    public partial class ucLICH : UserControl
    {
        private TKBDAO lichDAO = new TKBDAO();
        private int index = 0;
        public ucLICH(int pq)
        {
            InitializeComponent();
            if (pq == 0) btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private THOIKHOABIEU GetItembyID()
        {
            try
            {
                int id = (int)gridLich.GetRowCellValue(gridLich.FocusedRowHandle, "ID");
                return lichDAO.FindID(id);
            }
            catch { return new THOIKHOABIEU(); }
        }
        private void Hienthi()
        {
            try
            {
                THOIKHOABIEU lich = GetItembyID();
                cbBGV.Text = lich.GIAOVIEN.TENGV;
                cbBLOP.Text = lich.LOP.TENLOP;
                cbBThu.Text = lich.THU;
                cbBTiet.Text = lich.TIET;
            }
            catch { }
        }

        private void ucLICH_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = lichDAO.ListTKB("");
            GiaoVienDAO gvDAO = new GiaoVienDAO();
            cbBGV.DataSource = gvDAO.ListGV("");
            cbBGV.ValueMember = "ID";
            cbBGV.DisplayMember = "TENGV";
            LOPDAO lopDAO = new LOPDAO();
            cbBLOP.DataSource = lopDAO.ListLOP("");
            cbBLOP.ValueMember = "ID";
            cbBLOP.DisplayMember = "TENLOP";
            Hienthi();
        }

        private void gridLich_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == STT) e.DisplayText = Convert.ToString(e.RowHandle + 1);
        }

        private void gridLich_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Hienthi();
        }

        private void gridLich_KeyDown(object sender, KeyEventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            index = 1;
            cbBGV.Focus();
            cbBThu.Text = cbBTiet.Text = string.Empty;
            btnSua.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            index = 2;
            cbBGV.Focus();
            btnThem.Enabled = btnXoa.Enabled = gridControl.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mục này?", "Verify!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cur = gridLich.FocusedRowHandle;
                THOIKHOABIEU tkb = GetItembyID();
                bool check = lichDAO.Delete(tkb.ID);
                int i = cur == gridLich.RowCount - 1 ? gridLich.RowCount - 2 : cur;
                if (check != false)
                {
                    gridControl.DataSource = lichDAO.ListTKB("");
                    if (gridLich.RowCount > 1) gridLich.FocusedRowHandle = i;
                }
                else MessageBox.Show("Không xóa được mục này!", "Thông báo!");
                Hienthi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            THOIKHOABIEU tkb = new THOIKHOABIEU();
            tkb.MAGV = (int)cbBGV.SelectedValue;
            tkb.MALOP = (int)cbBLOP.SelectedValue;
            tkb.THU = cbBThu.SelectedItem.ToString();
            tkb.TIET = cbBTiet.SelectedItem.ToString();
            int i = index == 1 ? gridLich.RowCount : gridLich.FocusedRowHandle;
            bool check = false;
            if (index == 1) check = lichDAO.Insert(tkb);
            else if (index == 2)
            {
                int id = GetItembyID().ID;
                check = lichDAO.Edit(tkb, id);
            }
            else return;
            if (check != false)
            {
                gridControl.DataSource = lichDAO.ListTKB("");
                gridLich.FocusedRowHandle = i;
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
            gridControl.DataSource = lichDAO.ListTKB(txtSearch.Text);
        }
    }
}
