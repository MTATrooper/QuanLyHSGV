namespace QuanlyHS_GV_THPT.GUI
{
    partial class ucLICH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLICH));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.TIET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDlich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbBLOP = new System.Windows.Forms.ComboBox();
            this.cbBGV = new System.Windows.Forms.ComboBox();
            this.cbBThu = new System.Windows.Forms.ComboBox();
            this.cbBTiet = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(156, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Tên giáo viên";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(852, 175);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(27, 23);
            this.simpleButton1.TabIndex = 61;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(611, 176);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(686, 173);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(160, 28);
            this.txtSearch.TabIndex = 59;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(177, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(86, 360);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(222, 308);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // TIET
            // 
            this.TIET.Caption = "Tiết";
            this.TIET.FieldName = "TIET";
            this.TIET.Name = "TIET";
            this.TIET.Visible = true;
            this.TIET.VisibleIndex = 4;
            this.TIET.Width = 70;
            // 
            // THU
            // 
            this.THU.Caption = "Thứ";
            this.THU.FieldName = "THU";
            this.THU.Name = "THU";
            this.THU.Visible = true;
            this.THU.VisibleIndex = 3;
            this.THU.Width = 183;
            // 
            // TENLOP
            // 
            this.TENLOP.Caption = "Lớp";
            this.TENLOP.FieldName = "LOP.TENLOP";
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Visible = true;
            this.TENLOP.VisibleIndex = 2;
            this.TENLOP.Width = 70;
            // 
            // TENGV
            // 
            this.TENGV.Caption = "Giáo viên";
            this.TENGV.FieldName = "GIAOVIEN.TENGV";
            this.TENGV.Name = "TENGV";
            this.TENGV.Visible = true;
            this.TENGV.VisibleIndex = 1;
            this.TENGV.Width = 139;
            // 
            // IDlich
            // 
            this.IDlich.Caption = "ID";
            this.IDlich.FieldName = "ID";
            this.IDlich.Name = "IDlich";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 32;
            // 
            // gridLich
            // 
            this.gridLich.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.IDlich,
            this.TENGV,
            this.TENLOP,
            this.THU,
            this.TIET});
            this.gridLich.GridControl = this.gridControl;
            this.gridLich.Name = "gridLich";
            this.gridLich.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLich.OptionsView.ShowGroupPanel = false;
            this.gridLich.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridLich_CustomDrawCell);
            this.gridLich.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLich_FocusedRowChanged);
            this.gridLich.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridLich_KeyDown);
            this.gridLich.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridLich_KeyDown);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(333, 215);
            this.gridControl.MainView = this.gridLich;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(596, 235);
            this.gridControl.TabIndex = 53;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridLich});
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(489, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 19);
            this.labelControl6.TabIndex = 67;
            this.labelControl6.Text = "Lớp";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(192, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 19);
            this.labelControl5.TabIndex = 66;
            this.labelControl5.Text = "Thứ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(124, 308);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbBLOP
            // 
            this.cbBLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBLOP.FormattingEnabled = true;
            this.cbBLOP.Location = new System.Drawing.Point(531, 35);
            this.cbBLOP.Name = "cbBLOP";
            this.cbBLOP.Size = new System.Drawing.Size(160, 27);
            this.cbBLOP.TabIndex = 69;
            // 
            // cbBGV
            // 
            this.cbBGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBGV.FormattingEnabled = true;
            this.cbBGV.Location = new System.Drawing.Point(243, 32);
            this.cbBGV.Name = "cbBGV";
            this.cbBGV.Size = new System.Drawing.Size(160, 27);
            this.cbBGV.TabIndex = 70;
            // 
            // cbBThu
            // 
            this.cbBThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBThu.FormattingEnabled = true;
            this.cbBThu.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbBThu.Location = new System.Drawing.Point(243, 104);
            this.cbBThu.Name = "cbBThu";
            this.cbBThu.Size = new System.Drawing.Size(99, 27);
            this.cbBThu.TabIndex = 71;
            // 
            // cbBTiet
            // 
            this.cbBTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBTiet.FormattingEnabled = true;
            this.cbBTiet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "1-2",
            "2-3",
            "3-4",
            "4-5"});
            this.cbBTiet.Location = new System.Drawing.Point(531, 101);
            this.cbBTiet.Name = "cbBTiet";
            this.cbBTiet.Size = new System.Drawing.Size(99, 27);
            this.cbBTiet.TabIndex = 73;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(480, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 19);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Tiết";
            // 
            // ucLICH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbBTiet);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbBThu);
            this.Controls.Add(this.cbBGV);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbBLOP);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnThem);
            this.Name = "ucLICH";
            this.Size = new System.Drawing.Size(981, 501);
            this.Load += new System.EventHandler(this.ucLICH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn TIET;
        private DevExpress.XtraGrid.Columns.GridColumn THU;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn TENGV;
        private DevExpress.XtraGrid.Columns.GridColumn IDlich;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLich;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.ComboBox cbBLOP;
        private System.Windows.Forms.ComboBox cbBGV;
        private System.Windows.Forms.ComboBox cbBThu;
        private System.Windows.Forms.ComboBox cbBTiet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
