namespace QuanlyHS_GV_THPT.GUI
{
    partial class ucLOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLOP));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.SYSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDlop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLOP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(28, 345);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 19);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Sỹ số";
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(110, 342);
            this.txtSS.Name = "txtSS";
            this.txtSS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Properties.Appearance.Options.UseFont = true;
            this.txtSS.Size = new System.Drawing.Size(160, 28);
            this.txtSS.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(28, 259);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 19);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Tên lớp";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(110, 256);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(179, 28);
            this.txtTen.TabIndex = 22;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(663, 98);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(27, 23);
            this.simpleButton1.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(422, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(497, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(160, 28);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(203, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(78, 153);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SYSO
            // 
            this.SYSO.Caption = "Sỹ số";
            this.SYSO.FieldName = "SYSO";
            this.SYSO.Name = "SYSO";
            this.SYSO.Visible = true;
            this.SYSO.VisibleIndex = 2;
            this.SYSO.Width = 179;
            // 
            // TENLOP
            // 
            this.TENLOP.Caption = "Tên lớp";
            this.TENLOP.FieldName = "TENLOP";
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.Visible = true;
            this.TENLOP.VisibleIndex = 1;
            this.TENLOP.Width = 300;
            // 
            // IDlop
            // 
            this.IDlop.Caption = "ID";
            this.IDlop.FieldName = "ID";
            this.IDlop.Name = "IDlop";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 50;
            // 
            // gridLOP
            // 
            this.gridLOP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.IDlop,
            this.TENLOP,
            this.SYSO});
            this.gridLOP.GridControl = this.gridControl;
            this.gridLOP.Name = "gridLOP";
            this.gridLOP.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLOP.OptionsView.ShowGroupPanel = false;
            this.gridLOP.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridLOP_CustomDrawCell);
            this.gridLOP.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLOP_FocusedRowChanged);
            this.gridLOP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridLOP_KeyDown);
            this.gridLOP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridLOP_KeyDown);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(355, 141);
            this.gridControl.MainView = this.gridLOP;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(547, 255);
            this.gridControl.TabIndex = 13;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridLOP});
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(139, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ucLOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridControl);
            this.Name = "ucLOP";
            this.Size = new System.Drawing.Size(940, 492);
            this.Load += new System.EventHandler(this.ucLOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn SYSO;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn IDlop;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLOP;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}
