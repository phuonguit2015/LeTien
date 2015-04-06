namespace LeTien.Screens.Employees
{
    partial class FormEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucMenu = new LeTien.UCMainControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionEmployee = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTenTiengNhat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNoiSinh = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoCMND = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayCapCMND = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNoiCapCMND = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoTK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiaChiThuongTru = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiaChiTamTru = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayVaoLam = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayVaoBHXH = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTienPhuCap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLuongCoBan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoBHXH = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTonGiao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayVaoHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTinhTrangHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.RITextFistname = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RITextLastname = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.R_BranchSelect = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.R_CompentenceSelect = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpCollectionBranch = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollectionCompentence = new DevExpress.Xpo.XPCollection(this.components);
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MaNhanVien = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand19 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand21 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand20 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand22 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand23 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand24 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand25 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand15 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand26 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextFistname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_BranchSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_CompentenceSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCompentence)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ucMenu);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1056, 496);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ucMenu
            // 
            this.ucMenu.Location = new System.Drawing.Point(12, 12);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(1032, 31);
            this.ucMenu.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(24, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 372);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.xpCollectionEmployee;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RITextFistname,
            this.RITextLastname,
            this.R_BranchSelect,
            this.R_CompentenceSelect});
            this.gridControl1.Size = new System.Drawing.Size(1004, 368);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // xpCollectionEmployee
            // 
            this.xpCollectionEmployee.DisplayableProperties = resources.GetString("xpCollectionEmployee.DisplayableProperties");
            this.xpCollectionEmployee.ObjectType = typeof(LeTien.Objects.Employee);
            this.xpCollectionEmployee.Session = this.session1;
            this.xpCollectionEmployee.CollectionChanged += new DevExpress.Xpo.XPCollectionChangedEventHandler(this.xpCollectionEmployee_CollectionChanged);
            // 
            // session1
            // 
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.MaNhanVien,
            this.gridBand2,
            this.gridBand3,
            this.gridBand19,
            this.gridBand21,
            this.gridBand10,
            this.gridBand4,
            this.gridBand9,
            this.gridBand8,
            this.gridBand1,
            this.gridBand11,
            this.gridBand12,
            this.gridBand13,
            this.gridBand20,
            this.gridBand22,
            this.gridBand23,
            this.gridBand24,
            this.gridBand25,
            this.gridBand15,
            this.gridBand26,
            this.gridBand14});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colMaNhanVien,
            this.colHo,
            this.colTen,
            this.colTenTiengNhat,
            this.colDiaChiTamTru,
            this.colDiaChiThuongTru,
            this.colGioiTinh,
            this.colLuongCoBan,
            this.colChucVu,
            this.colTienPhuCap,
            this.colNgayCapCMND,
            this.colNgaySinh,
            this.colNgayVaoBHXH,
            this.colNgayVaoLam,
            this.colNoiCapCMND,
            this.colNoiSinh,
            this.colSoBHXH,
            this.colSoCMND,
            this.colSoDT,
            this.colSoTK,
            this.colTonGiao,
            this.colNgayVaoHopDong,
            this.colTinhTrangHopDong,
            this.colHopDong});
            this.bandedGridView1.CustomizationFormBounds = new System.Drawing.Rectangle(756, 391, 216, 208);
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.bandedGridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.bandedGridView1_RowClick);
            this.bandedGridView1.DoubleClick += new System.EventHandler(this.bandedGridView1_DoubleClick);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.ShowCaption = false;
            this.colMaNhanVien.Visible = true;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.ShowCaption = false;
            this.colHo.Visible = true;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ShowCaption = false;
            this.colTen.Visible = true;
            // 
            // colTenTiengNhat
            // 
            this.colTenTiengNhat.FieldName = "TenTiengNhat";
            this.colTenTiengNhat.Name = "colTenTiengNhat";
            this.colTenTiengNhat.OptionsColumn.ShowCaption = false;
            this.colTenTiengNhat.Visible = true;
            this.colTenTiengNhat.Width = 83;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Chức Vụ";
            this.colChucVu.FieldName = "ChucVu.CompetenceName";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsColumn.ShowCaption = false;
            this.colChucVu.Visible = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "iGioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.ShowCaption = false;
            this.colGioiTinh.Visible = true;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.ShowCaption = false;
            this.colNgaySinh.Visible = true;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.FieldName = "NoiSinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.OptionsColumn.ShowCaption = false;
            this.colNoiSinh.Visible = true;
            // 
            // colSoCMND
            // 
            this.colSoCMND.FieldName = "SoCMND";
            this.colSoCMND.Name = "colSoCMND";
            this.colSoCMND.OptionsColumn.ShowCaption = false;
            this.colSoCMND.Visible = true;
            // 
            // colNgayCapCMND
            // 
            this.colNgayCapCMND.FieldName = "NgayCapCMND";
            this.colNgayCapCMND.Name = "colNgayCapCMND";
            this.colNgayCapCMND.OptionsColumn.ShowCaption = false;
            this.colNgayCapCMND.Visible = true;
            this.colNgayCapCMND.Width = 89;
            // 
            // colNoiCapCMND
            // 
            this.colNoiCapCMND.FieldName = "NoiCapCMND";
            this.colNoiCapCMND.Name = "colNoiCapCMND";
            this.colNoiCapCMND.OptionsColumn.ShowCaption = false;
            this.colNoiCapCMND.Visible = true;
            this.colNoiCapCMND.Width = 79;
            // 
            // colSoTK
            // 
            this.colSoTK.FieldName = "SoTaiKhoan";
            this.colSoTK.Name = "colSoTK";
            this.colSoTK.OptionsColumn.ShowCaption = false;
            this.colSoTK.Visible = true;
            // 
            // colSoDT
            // 
            this.colSoDT.FieldName = "SoDienThoai";
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.OptionsColumn.ShowCaption = false;
            this.colSoDT.Visible = true;
            // 
            // colDiaChiThuongTru
            // 
            this.colDiaChiThuongTru.FieldName = "DiaChiThuongTru";
            this.colDiaChiThuongTru.Name = "colDiaChiThuongTru";
            this.colDiaChiThuongTru.OptionsColumn.ShowCaption = false;
            this.colDiaChiThuongTru.Visible = true;
            this.colDiaChiThuongTru.Width = 101;
            // 
            // colDiaChiTamTru
            // 
            this.colDiaChiTamTru.FieldName = "DiaChiTamTru";
            this.colDiaChiTamTru.Name = "colDiaChiTamTru";
            this.colDiaChiTamTru.OptionsColumn.ShowCaption = false;
            this.colDiaChiTamTru.Visible = true;
            this.colDiaChiTamTru.Width = 85;
            // 
            // colNgayVaoLam
            // 
            this.colNgayVaoLam.FieldName = "NgayVaoLam";
            this.colNgayVaoLam.Name = "colNgayVaoLam";
            this.colNgayVaoLam.OptionsColumn.ShowCaption = false;
            this.colNgayVaoLam.Visible = true;
            this.colNgayVaoLam.Width = 78;
            // 
            // colNgayVaoBHXH
            // 
            this.colNgayVaoBHXH.FieldName = "NgayVaoBHXH";
            this.colNgayVaoBHXH.Name = "colNgayVaoBHXH";
            this.colNgayVaoBHXH.OptionsColumn.ShowCaption = false;
            this.colNgayVaoBHXH.Visible = true;
            this.colNgayVaoBHXH.Width = 85;
            // 
            // colTienPhuCap
            // 
            this.colTienPhuCap.Caption = "Phụ Cấp Chức Vụ";
            this.colTienPhuCap.FieldName = "MaChucVu.Allowance";
            this.colTienPhuCap.Name = "colTienPhuCap";
            this.colTienPhuCap.OptionsColumn.ShowCaption = false;
            this.colTienPhuCap.Visible = true;
            this.colTienPhuCap.Width = 93;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.FieldName = "LuongCoBan";
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.OptionsColumn.ShowCaption = false;
            this.colLuongCoBan.Visible = true;
            this.colLuongCoBan.Width = 76;
            // 
            // colSoBHXH
            // 
            this.colSoBHXH.FieldName = "SoBHXH";
            this.colSoBHXH.Name = "colSoBHXH";
            this.colSoBHXH.OptionsColumn.ShowCaption = false;
            this.colSoBHXH.Visible = true;
            // 
            // colTonGiao
            // 
            this.colTonGiao.FieldName = "TonGiao.ReligionName";
            this.colTonGiao.Name = "colTonGiao";
            this.colTonGiao.OptionsColumn.ShowCaption = false;
            this.colTonGiao.Visible = true;
            this.colTonGiao.Width = 123;
            // 
            // colNgayVaoHopDong
            // 
            this.colNgayVaoHopDong.Caption = "Ngày Vào Hợp Đồng";
            this.colNgayVaoHopDong.FieldName = "HopDong.NgayKy";
            this.colNgayVaoHopDong.Name = "colNgayVaoHopDong";
            this.colNgayVaoHopDong.OptionsColumn.ShowCaption = false;
            this.colNgayVaoHopDong.Visible = true;
            // 
            // colTinhTrangHopDong
            // 
            this.colTinhTrangHopDong.Name = "colTinhTrangHopDong";
            this.colTinhTrangHopDong.OptionsColumn.ShowCaption = false;
            this.colTinhTrangHopDong.Visible = true;
            // 
            // colHopDong
            // 
            this.colHopDong.FieldName = "HopDong.LoaiHopDong";
            this.colHopDong.Name = "colHopDong";
            this.colHopDong.OptionsColumn.ShowCaption = false;
            this.colHopDong.Visible = true;
            // 
            // RITextFistname
            // 
            this.RITextFistname.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.RITextFistname.AutoHeight = false;
            this.RITextFistname.Name = "RITextFistname";
            this.RITextFistname.NullValuePrompt = "Chưa nhập dữ liệu";
            this.RITextFistname.NullValuePromptShowForEmptyValue = true;
            this.RITextFistname.ShowNullValuePromptWhenFocused = true;
            // 
            // RITextLastname
            // 
            this.RITextLastname.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.RITextLastname.AutoHeight = false;
            this.RITextLastname.Name = "RITextLastname";
            this.RITextLastname.NullValuePrompt = "Chưa nhập dữ liệu";
            this.RITextLastname.NullValuePromptShowForEmptyValue = true;
            this.RITextLastname.ShowNullValuePromptWhenFocused = true;
            // 
            // R_BranchSelect
            // 
            this.R_BranchSelect.AutoHeight = false;
            this.R_BranchSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.R_BranchSelect.DisplayMember = "BranchName";
            this.R_BranchSelect.Name = "R_BranchSelect";
            this.R_BranchSelect.NullText = "";
            this.R_BranchSelect.NullValuePrompt = "Chưa nhập dữ liệu";
            this.R_BranchSelect.NullValuePromptShowForEmptyValue = true;
            // 
            // R_CompentenceSelect
            // 
            this.R_CompentenceSelect.AutoHeight = false;
            this.R_CompentenceSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.R_CompentenceSelect.DisplayMember = "CompetenceName";
            this.R_CompentenceSelect.Name = "R_CompentenceSelect";
            this.R_CompentenceSelect.NullText = "";
            this.R_CompentenceSelect.NullValuePrompt = "Chưa nhập dữ liệu";
            this.R_CompentenceSelect.NullValuePromptShowForEmptyValue = true;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1036, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1036, 24);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1056, 496);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Danh sách nhân viên";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 35);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1036, 419);
            this.layoutControlGroup2.Text = "Danh sách nhân viên";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1012, 376);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 454);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1036, 22);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ucMenu;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1036, 35);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // xpCollectionBranch
            // 
            this.xpCollectionBranch.Session = this.session1;
            // 
            // xpCollectionCompentence
            // 
            this.xpCollectionCompentence.Session = this.session1;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "Mã nhân viên";
            this.MaNhanVien.Columns.Add(this.colMaNhanVien);
            this.MaNhanVien.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.VisibleIndex = 0;
            this.MaNhanVien.Width = 75;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Họ lót";
            this.gridBand2.Columns.Add(this.colHo);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 75;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Tên";
            this.gridBand3.Columns.Add(this.colTen);
            this.gridBand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 75;
            // 
            // gridBand19
            // 
            this.gridBand19.Caption = "Tên Tiếng Nhật";
            this.gridBand19.Columns.Add(this.colTenTiengNhat);
            this.gridBand19.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand19.Name = "gridBand19";
            this.gridBand19.VisibleIndex = 3;
            this.gridBand19.Width = 83;
            // 
            // gridBand21
            // 
            this.gridBand21.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.gridBand21.AppearanceHeader.BorderColor = System.Drawing.Color.White;
            this.gridBand21.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand21.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand21.AppearanceHeader.Options.UseBorderColor = true;
            this.gridBand21.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand21.Caption = "Chức Vụ";
            this.gridBand21.Columns.Add(this.colChucVu);
            this.gridBand21.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand21.Name = "gridBand21";
            this.gridBand21.VisibleIndex = 4;
            this.gridBand21.Width = 75;
            // 
            // gridBand10
            // 
            this.gridBand10.Caption = "Giới tính";
            this.gridBand10.Columns.Add(this.colGioiTinh);
            this.gridBand10.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.VisibleIndex = 5;
            this.gridBand10.Width = 75;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ngày sinh";
            this.gridBand4.Columns.Add(this.colNgaySinh);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 6;
            this.gridBand4.Width = 75;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "Nơi sinh";
            this.gridBand9.Columns.Add(this.colNoiSinh);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 7;
            this.gridBand9.Width = 75;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "CMND";
            this.gridBand8.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand5,
            this.gridBand6,
            this.gridBand7});
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 8;
            this.gridBand8.Width = 243;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Số CMND";
            this.gridBand5.Columns.Add(this.colSoCMND);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 0;
            this.gridBand5.Width = 75;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Ngày cấp";
            this.gridBand6.Columns.Add(this.colNgayCapCMND);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 1;
            this.gridBand6.Width = 89;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "Nơi cấp";
            this.gridBand7.Columns.Add(this.colNoiCapCMND);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 2;
            this.gridBand7.Width = 79;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Số Tài Khoản Ngân Hàng";
            this.gridBand1.Columns.Add(this.colSoTK);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 9;
            this.gridBand1.Width = 75;
            // 
            // gridBand11
            // 
            this.gridBand11.Caption = "Số ĐTDĐ";
            this.gridBand11.Columns.Add(this.colSoDT);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.VisibleIndex = 10;
            this.gridBand11.Width = 75;
            // 
            // gridBand12
            // 
            this.gridBand12.Caption = "Địa chỉ thường trú";
            this.gridBand12.Columns.Add(this.colDiaChiThuongTru);
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 11;
            this.gridBand12.Width = 101;
            // 
            // gridBand13
            // 
            this.gridBand13.Caption = "Địa chỉ tạm trú";
            this.gridBand13.Columns.Add(this.colDiaChiTamTru);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.VisibleIndex = 12;
            this.gridBand13.Width = 85;
            // 
            // gridBand20
            // 
            this.gridBand20.Caption = "Ngày Vào Làm";
            this.gridBand20.Columns.Add(this.colNgayVaoLam);
            this.gridBand20.Name = "gridBand20";
            this.gridBand20.VisibleIndex = 13;
            this.gridBand20.Width = 78;
            // 
            // gridBand22
            // 
            this.gridBand22.Caption = "Ngày Vào Hợp Đồng";
            this.gridBand22.Columns.Add(this.colNgayVaoHopDong);
            this.gridBand22.Name = "gridBand22";
            this.gridBand22.VisibleIndex = 14;
            this.gridBand22.Width = 75;
            // 
            // gridBand23
            // 
            this.gridBand23.Caption = "Ngày Vào Bảo Hiểm";
            this.gridBand23.Columns.Add(this.colNgayVaoBHXH);
            this.gridBand23.Name = "gridBand23";
            this.gridBand23.VisibleIndex = 15;
            this.gridBand23.Width = 85;
            // 
            // gridBand24
            // 
            this.gridBand24.Caption = "Tình Trạng Hợp Đồng";
            this.gridBand24.Columns.Add(this.colHopDong);
            this.gridBand24.Name = "gridBand24";
            this.gridBand24.VisibleIndex = 16;
            this.gridBand24.Width = 75;
            // 
            // gridBand25
            // 
            this.gridBand25.Caption = "Phụ Cấp Chức Vụ";
            this.gridBand25.Columns.Add(this.colTienPhuCap);
            this.gridBand25.Name = "gridBand25";
            this.gridBand25.VisibleIndex = 17;
            this.gridBand25.Width = 93;
            // 
            // gridBand15
            // 
            this.gridBand15.Caption = "Lương cơ bản";
            this.gridBand15.Columns.Add(this.colLuongCoBan);
            this.gridBand15.Name = "gridBand15";
            this.gridBand15.VisibleIndex = 18;
            this.gridBand15.Width = 76;
            // 
            // gridBand26
            // 
            this.gridBand26.Caption = "Bảo Hiểm Xã Hội";
            this.gridBand26.Columns.Add(this.colSoBHXH);
            this.gridBand26.Name = "gridBand26";
            this.gridBand26.VisibleIndex = 19;
            this.gridBand26.Width = 75;
            // 
            // gridBand14
            // 
            this.gridBand14.Caption = "Tôn Giáo";
            this.gridBand14.Columns.Add(this.colTonGiao);
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.VisibleIndex = 20;
            this.gridBand14.Width = 123;
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 496);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormEmployeeList";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.FormEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextFistname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_BranchSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_CompentenceSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCompentence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.XPCollection xpCollectionEmployee;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.Xpo.XPCollection xpCollectionBranch;
        private DevExpress.Xpo.XPCollection xpCollectionCompentence;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RITextFistname;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RITextLastname;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit R_BranchSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit R_CompentenceSelect;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;

       
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTenTiengNhat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colChucVu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGioiTinh;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgaySinh;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNoiSinh;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoCMND;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayCapCMND;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNoiCapCMND;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoTK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoDT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiaChiThuongTru;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiaChiTamTru;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayVaoLam;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayVaoBHXH;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTienPhuCap;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLuongCoBan;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoBHXH;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTonGiao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayVaoHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTinhTrangHopDong;
        private UCMainControl ucMenu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand MaNhanVien;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand19;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand21;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand20;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand22;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand23;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand24;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand25;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand15;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand26;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
    }
}