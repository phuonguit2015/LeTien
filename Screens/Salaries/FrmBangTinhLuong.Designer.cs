namespace LeTien.Screens.Salaries
{
    partial class FrmBangTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBangTinhLuong));
            this.xpcChiTietLuong = new DevExpress.Xpo.XPCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.d = new DevExpress.XtraBars.BarStaticItem();
            this.dtThang = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiDuLieuTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldLoaiDLTinhLuongNhomDuLieu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGiaTri1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNhanVienHoTen1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpcNhanVien = new DevExpress.Xpo.XPCollection(this.components);
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupMucTienLuong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpcMucTienLuong = new DevExpress.Xpo.XPCollection(this.components);
            this.colGiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChiTietLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMucTienLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcMucTienLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcChiTietLuong
            // 
            this.xpcChiTietLuong.ObjectType = typeof(LeTien.Objects.ChiTietTienLuong);
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
            this.btnLoaiDuLieuTinhLuong,
            this.d,
            this.dtThang,
            this.btnTinhLuong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.d),
            new DevExpress.XtraBars.LinkPersistInfo(this.dtThang),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoaiDuLieuTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // d
            // 
            this.d.Caption = "Tháng";
            this.d.Id = 1;
            this.d.Name = "d";
            this.d.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dtThang
            // 
            this.dtThang.Edit = this.repositoryItemDateEdit1;
            this.dtThang.Id = 2;
            this.dtThang.Name = "dtThang";
            this.dtThang.Width = 114;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repositoryItemDateEdit1.Mask.EditMask = "M/yyyy";
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.NullDate = new System.DateTime(2015, 4, 6, 15, 11, 12, 804);
            this.repositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính Lương";
            this.btnTinhLuong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.Glyph")));
            this.btnTinhLuong.Id = 3;
            this.btnTinhLuong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.LargeGlyph")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnLoaiDuLieuTinhLuong
            // 
            this.btnLoaiDuLieuTinhLuong.Caption = "Loại Dữ Liệu Tính Lương";
            this.btnLoaiDuLieuTinhLuong.Id = 0;
            this.btnLoaiDuLieuTinhLuong.Name = "btnLoaiDuLieuTinhLuong";
            this.btnLoaiDuLieuTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiDuLieuTinhLuong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(618, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 368);
            this.barDockControlBottom.Size = new System.Drawing.Size(618, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(618, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(618, 344);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(24, 43);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(570, 277);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(564, 249);
            this.xtraTabPage1.Text = "Xem Chi Tiết Lương";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pivotGridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(564, 249);
            this.panelControl1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.xpcChiTietLuong;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldLoaiDLTinhLuongNhomDuLieu,
            this.fieldGiaTri1,
            this.fieldNhanVienHoTen1,
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu});
            this.pivotGridControl1.Location = new System.Drawing.Point(2, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(560, 245);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldLoaiDLTinhLuongNhomDuLieu
            // 
            this.fieldLoaiDLTinhLuongNhomDuLieu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLoaiDLTinhLuongNhomDuLieu.AreaIndex = 0;
            this.fieldLoaiDLTinhLuongNhomDuLieu.Caption = "Nhóm Mục Tiền Lương";
            this.fieldLoaiDLTinhLuongNhomDuLieu.FieldName = "LoaiDLTinhLuong.NhomDuLieu";
            this.fieldLoaiDLTinhLuongNhomDuLieu.Name = "fieldLoaiDLTinhLuongNhomDuLieu";
            // 
            // fieldGiaTri1
            // 
            this.fieldGiaTri1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGiaTri1.AreaIndex = 0;
            this.fieldGiaTri1.Caption = "Giá Trị";
            this.fieldGiaTri1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldGiaTri1.FieldName = "GiaTri";
            this.fieldGiaTri1.Name = "fieldGiaTri1";
            // 
            // fieldNhanVienHoTen1
            // 
            this.fieldNhanVienHoTen1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNhanVienHoTen1.AreaIndex = 0;
            this.fieldNhanVienHoTen1.Caption = "Họ và Tên";
            this.fieldNhanVienHoTen1.FieldName = "NhanVien.HoTen";
            this.fieldNhanVienHoTen1.Name = "fieldNhanVienHoTen1";
            // 
            // fieldLoaiDLTinhLuongTenLoaiDuLieu
            // 
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu.AreaIndex = 1;
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu.Caption = "Mục Tiền Lương";
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu.FieldName = "LoaiDLTinhLuong.TenLoaiDuLieu";
            this.fieldLoaiDLTinhLuongTenLoaiDuLieu.Name = "fieldLoaiDLTinhLuongTenLoaiDuLieu";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(564, 249);
            this.xtraTabPage2.Text = "Sửa Chi Tiết Lương";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.xpcChiTietLuong;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkupNhanVien,
            this.lkupMucTienLuong});
            this.gridControl1.Size = new System.Drawing.Size(564, 249);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThang,
            this.gridColumn1,
            this.gridColumn3,
            this.colGiaTri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colThang
            // 
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.lkupNhanVien;
            this.gridColumn1.FieldName = "NhanVien!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // lkupNhanVien
            // 
            this.lkupNhanVien.AutoHeight = false;
            this.lkupNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupNhanVien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhanVien", "Mã Nhân Viên", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho", "Họ lót", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkupNhanVien.DataSource = this.xpcNhanVien;
            this.lkupNhanVien.DisplayMember = "HoTen";
            this.lkupNhanVien.Name = "lkupNhanVien";
            this.lkupNhanVien.NullText = "[Chọn Nhân Viên]";
            this.lkupNhanVien.ValueMember = "This";
            // 
            // xpcNhanVien
            // 
            this.xpcNhanVien.ObjectType = typeof(LeTien.Objects.Employee);
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.lkupMucTienLuong;
            this.gridColumn3.FieldName = "LoaiDLTinhLuong!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // lkupMucTienLuong
            // 
            this.lkupMucTienLuong.AutoHeight = false;
            this.lkupMucTienLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupMucTienLuong.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiDuLieu", "Mục Tiền Lương", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkupMucTienLuong.DataSource = this.xpcMucTienLuong;
            this.lkupMucTienLuong.DisplayMember = "TenLoaiDuLieu";
            this.lkupMucTienLuong.Name = "lkupMucTienLuong";
            this.lkupMucTienLuong.NullText = "[Chọn Mục Tiền Lương]";
            this.lkupMucTienLuong.ValueMember = "This";
            // 
            // xpcMucTienLuong
            // 
            this.xpcMucTienLuong.ObjectType = typeof(LeTien.Objects.LoaiDuLieuTinhLuong);
            this.xpcMucTienLuong.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[CongThuc]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // colGiaTri
            // 
            this.colGiaTri.FieldName = "GiaTri";
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.Visible = true;
            this.colGiaTri.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(618, 344);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Chi Tiết Lương";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(598, 324);
            this.layoutControlGroup2.Text = "Chi Tiết Lương";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(574, 281);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmBangTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 368);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBangTinhLuong";
            this.Text = "Bảng Tính Lương";
            ((System.ComponentModel.ISupportInitialize)(this.xpcChiTietLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMucTienLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcMucTienLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcChiTietLuong;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDuLieuTinhLuong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraBars.BarStaticItem d;
        private DevExpress.XtraBars.BarEditItem dtThang;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupNhanVien;
        private DevExpress.Xpo.XPCollection xpcNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupMucTienLuong;
        private DevExpress.Xpo.XPCollection xpcMucTienLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTri;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLoaiDLTinhLuongNhomDuLieu;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGiaTri1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNhanVienHoTen1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLoaiDLTinhLuongTenLoaiDuLieu;
    }
}