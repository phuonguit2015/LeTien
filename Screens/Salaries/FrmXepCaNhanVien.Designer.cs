namespace LeTien.Screens.Salaries
{
    partial class FrmXepCaNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXepCaNhanVien));
            this.xpcXepCa = new DevExpress.Xpo.XPCollection(this.components);
            this.xpcNhanVien = new DevExpress.Xpo.XPCollection(this.components);
            this.xpcDanhMucCa = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupCa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.dtThang = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnXepCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.txtTenBangChamCong = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnNapLai = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoBangChamCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhatKQ = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcXepCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcDanhMucCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcXepCa
            // 
            this.xpcXepCa.ObjectType = typeof(LeTien.Objects.ChiTietXepCa);
            // 
            // xpcNhanVien
            // 
            this.xpcNhanVien.ObjectType = typeof(LeTien.Objects.Employee);
            // 
            // xpcDanhMucCa
            // 
            this.xpcDanhMucCa.ObjectType = typeof(LeTien.Objects.DanhMucCa);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 55);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(766, 306);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.xpcXepCa;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkupNhanVien,
            this.lkupCa});
            this.gridControl1.Size = new System.Drawing.Size(742, 282);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colNhanVien,
            this.colCa,
            this.colNgay,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNhanVien, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colNhanVien
            // 
            this.colNhanVien.ColumnEdit = this.lkupNhanVien;
            this.colNhanVien.FieldName = "NhanVien!";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 0;
            // 
            // lkupNhanVien
            // 
            this.lkupNhanVien.AutoHeight = false;
            this.lkupNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupNhanVien.DataSource = this.xpcNhanVien;
            this.lkupNhanVien.DisplayMember = "HoTen";
            this.lkupNhanVien.Name = "lkupNhanVien";
            this.lkupNhanVien.ValueMember = "This";
            // 
            // colCa
            // 
            this.colCa.ColumnEdit = this.lkupCa;
            this.colCa.FieldName = "Ca!";
            this.colCa.Name = "colCa";
            this.colCa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCa.Visible = true;
            this.colCa.VisibleIndex = 2;
            this.colCa.Width = 497;
            // 
            // lkupCa
            // 
            this.lkupCa.AutoHeight = false;
            this.lkupCa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupCa.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCa", "Tên Ca"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mô Tả")});
            this.lkupCa.DataSource = this.xpcDanhMucCa;
            this.lkupCa.DisplayMember = "TenCa";
            this.lkupCa.Name = "lkupCa";
            this.lkupCa.ValueMember = "This";
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNgay.OptionsColumn.ReadOnly = true;
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 495;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 70;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(766, 306);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(746, 286);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem2,
            this.txtTenBangChamCong,
            this.btnIn,
            this.btnXuat,
            this.btnNapLai,
            this.btnDong,
            this.barButtonItem1,
            this.dtThang,
            this.btnImportAC,
            this.btnEdit,
            this.btnTaoBangChamCong,
            this.btnCapNhatKQ,
            this.btnXepCa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 19;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(344, 146);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.dtThang),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXepCa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Tháng:";
            this.barStaticItem1.Enabled = false;
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dtThang
            // 
            this.dtThang.Edit = this.repositoryItemDateEdit2;
            this.dtThang.EditValue = new System.DateTime(2015, 3, 31, 22, 42, 16, 547);
            this.dtThang.Id = 12;
            this.dtThang.Name = "dtThang";
            this.dtThang.Width = 120;
            this.dtThang.EditValueChanged += new System.EventHandler(this.dtThang_EditValueChanged);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Mask.EditMask = "M/yyyy";
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // btnXepCa
            // 
            this.btnXepCa.Caption = "TÌM THÔNG TIN XẾP CA";
            this.btnXepCa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXepCa.Glyph")));
            this.btnXepCa.Id = 18;
            this.btnXepCa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXepCa.LargeGlyph")));
            this.btnXepCa.Name = "btnXepCa";
            this.btnXepCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXepCa_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "CHẾ ĐỘ CHỈ ĐỌC";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 14;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "IN";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 6;
            this.btnIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIn.LargeGlyph")));
            this.btnIn.Name = "btnIn";
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "XUẤT EXCEL";
            this.btnXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.Glyph")));
            this.btnXuat.Id = 7;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "ĐÓNG";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 9;
            this.btnDong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDong.LargeGlyph")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(766, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Size = new System.Drawing.Size(766, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 306);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(766, 55);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 306);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Năm:";
            this.barStaticItem2.Enabled = false;
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtTenBangChamCong
            // 
            this.txtTenBangChamCong.AutoFillWidth = true;
            this.txtTenBangChamCong.Caption = "barEditItem1";
            this.txtTenBangChamCong.Edit = this.repositoryItemTextEdit1;
            this.txtTenBangChamCong.Id = 5;
            this.txtTenBangChamCong.Name = "txtTenBangChamCong";
            this.txtTenBangChamCong.Width = 135;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp Lại";
            this.btnNapLai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNapLai.Glyph")));
            this.btnNapLai.Id = 8;
            this.btnNapLai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNapLai.LargeGlyph")));
            this.btnNapLai.Name = "btnNapLai";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnImportAC
            // 
            this.btnImportAC.Caption = "Import";
            this.btnImportAC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnImportAC.Glyph")));
            this.btnImportAC.Id = 13;
            this.btnImportAC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnImportAC.LargeGlyph")));
            this.btnImportAC.Name = "btnImportAC";
            // 
            // btnTaoBangChamCong
            // 
            this.btnTaoBangChamCong.Caption = "Tạo Bảng Chấm Công";
            this.btnTaoBangChamCong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoBangChamCong.Glyph")));
            this.btnTaoBangChamCong.Id = 15;
            this.btnTaoBangChamCong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaoBangChamCong.LargeGlyph")));
            this.btnTaoBangChamCong.Name = "btnTaoBangChamCong";
            // 
            // btnCapNhatKQ
            // 
            this.btnCapNhatKQ.Caption = "Cập Nhật Kết Quả";
            this.btnCapNhatKQ.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKQ.Glyph")));
            this.btnCapNhatKQ.Id = 17;
            this.btnCapNhatKQ.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKQ.LargeGlyph")));
            this.btnCapNhatKQ.Name = "btnCapNhatKQ";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.NullText = "Tháng";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.MinValue = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.NullText = "Năm";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // FrmXepCaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmXepCaNhanVien";
            this.Text = "XẾP CA NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmXepCaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpcXepCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcDanhMucCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcXepCa;
        private DevExpress.Xpo.XPCollection xpcNhanVien;
        private DevExpress.Xpo.XPCollection xpcDanhMucCa;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colCa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupCa;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem dtThang;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem btnXepCa;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnCapNhatKQ;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem txtTenBangChamCong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnNapLai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnImportAC;
        private DevExpress.XtraBars.BarButtonItem btnTaoBangChamCong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}