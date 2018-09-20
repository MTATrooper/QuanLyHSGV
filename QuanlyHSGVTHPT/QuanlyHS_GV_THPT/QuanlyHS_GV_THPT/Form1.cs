using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanlyHS_GV_THPT.GUI;

namespace QuanlyHS_GV_THPT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int id = 0;
        private int pq = 0;
        private string username = "";
        public FormMain(int id, int pq, string username)
        {
            InitializeComponent();
            this.id = id;
            this.pq = pq;
            this.username = username;
            if (this.pq == 0) btnAddTK.Enabled = false;
        }

        private void btnTo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucTo to = new ucTo(pq);
            panelMain.Controls.Add(to);
            to.Dock = DockStyle.Fill;
        }

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucGV gv = new ucGV(pq);
            panelMain.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucMH mh = new ucMH(pq);
            panelMain.Controls.Add(mh);
            mh.Dock = DockStyle.Fill;
        }

        private void btnLOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucLOP lop = new ucLOP(pq);
            panelMain.Controls.Add(lop);
            lop.Dock = DockStyle.Fill;
        }

        private void btnHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucHS hs = new ucHS(pq);
            panelMain.Controls.Add(hs);
            hs.Dock = DockStyle.Fill;
        }

        private void btnLich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucLICH lich = new ucLICH(pq);
            panelMain.Controls.Add(lich);
            lich.Dock = DockStyle.Fill;
        }

        private void btnAddTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void btnChangepass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucChangePass pass = new ucChangePass(id,pq,username);
            panelMain.Controls.Add(pass);
            pass.Dock = DockStyle.Fill;
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHDSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucHDSD pass = new ucHDSD();
            panelMain.Controls.Add(pass);
            pass.Dock = DockStyle.Fill;
        }
    }
}
