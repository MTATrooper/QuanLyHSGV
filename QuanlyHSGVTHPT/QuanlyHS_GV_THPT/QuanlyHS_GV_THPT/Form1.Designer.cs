namespace QuanlyHS_GV_THPT
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnLOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnHS = new DevExpress.XtraBars.BarButtonItem();
            this.btnLich = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangepass = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnHDSD = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnTo,
            this.btnGV,
            this.btnMH,
            this.btnLOP,
            this.btnHS,
            this.btnLich,
            this.btnChangepass,
            this.btnAddTK,
            this.btnLogout,
            this.btnHDSD});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(933, 143);
            // 
            // btnTo
            // 
            this.btnTo.Caption = "Tổ bộ môn";
            this.btnTo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTo.Glyph")));
            this.btnTo.Id = 1;
            this.btnTo.Name = "btnTo";
            this.btnTo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTo_ItemClick);
            // 
            // btnGV
            // 
            this.btnGV.Caption = "Giáo viên";
            this.btnGV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGV.Glyph")));
            this.btnGV.Id = 2;
            this.btnGV.Name = "btnGV";
            this.btnGV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
            // 
            // btnMH
            // 
            this.btnMH.Caption = "Môn học";
            this.btnMH.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMH.Glyph")));
            this.btnMH.Id = 3;
            this.btnMH.Name = "btnMH";
            this.btnMH.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMH_ItemClick);
            // 
            // btnLOP
            // 
            this.btnLOP.Caption = "Lớp";
            this.btnLOP.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLOP.Glyph")));
            this.btnLOP.Id = 4;
            this.btnLOP.Name = "btnLOP";
            this.btnLOP.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLOP_ItemClick);
            // 
            // btnHS
            // 
            this.btnHS.Caption = "Học sinh";
            this.btnHS.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHS.Glyph")));
            this.btnHS.Id = 5;
            this.btnHS.Name = "btnHS";
            this.btnHS.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHS_ItemClick);
            // 
            // btnLich
            // 
            this.btnLich.Caption = "Phân công lịch dạy";
            this.btnLich.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLich.Glyph")));
            this.btnLich.Id = 6;
            this.btnLich.Name = "btnLich";
            this.btnLich.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLich.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLich_ItemClick);
            // 
            // btnChangepass
            // 
            this.btnChangepass.Caption = "Đổi mật khẩu";
            this.btnChangepass.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChangepass.Glyph")));
            this.btnChangepass.Id = 7;
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnChangepass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangepass_ItemClick);
            // 
            // btnAddTK
            // 
            this.btnAddTK.Caption = "Tạo tài khoản";
            this.btnAddTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddTK.Glyph")));
            this.btnAddTK.Id = 8;
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAddTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddTK_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 9;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLOP);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHS);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLich);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChangepass);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddTK);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 143);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(933, 462);
            this.panelMain.TabIndex = 1;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHDSD);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btnHDSD
            // 
            this.btnHDSD.Caption = "Hướng dẫn sử dụng phần mềm";
            this.btnHDSD.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHDSD.Glyph")));
            this.btnHDSD.Id = 10;
            this.btnHDSD.Name = "btnHDSD";
            this.btnHDSD.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnHDSD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHDSD_ItemClick);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 605);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý Học sinh, Giáo viên THPT";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTo;
        private DevExpress.XtraBars.BarButtonItem btnGV;
        private DevExpress.XtraBars.BarButtonItem btnMH;
        private DevExpress.XtraBars.BarButtonItem btnLOP;
        private DevExpress.XtraBars.BarButtonItem btnHS;
        private DevExpress.XtraBars.BarButtonItem btnLich;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraBars.BarButtonItem btnChangepass;
        private DevExpress.XtraBars.BarButtonItem btnAddTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnHDSD;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

