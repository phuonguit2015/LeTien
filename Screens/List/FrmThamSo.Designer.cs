namespace LeTien.Screens.List
{
    partial class FrmThamSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThamSo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridUCList = new DevExpress.XtraGrid.GridControl();
            this.xpcThamSo = new DevExpress.Xpo.XPCollection(this.components);
            this.grvUCList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenThamSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKieuDuLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colGiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.spinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.dateTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcThamSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEdit,
            this.barButtonItem2,
            this.btnDong,
            this.btnIn,
            this.btnXuat,
            this.btnXoa,
            this.barEditItem1,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "CHẾ ĐỘ CHỈ ĐỌC";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 0;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 6;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "NẠP LẠI";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "IN";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 4;
            this.btnIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIn.LargeGlyph")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnXuat
            // 
            this.btnXuat.Caption = "XUẤT EXCEL";
            this.btnXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.Glyph")));
            this.btnXuat.Id = 5;
            this.btnXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXuat.LargeGlyph")));
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuat_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "ĐÓNG";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 3;
            this.btnDong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDong.LargeGlyph")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(769, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(769, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem1.Id = 7;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridUCList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(769, 377);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridUCList
            // 
            this.gridUCList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUCList.DataSource = this.xpcThamSo;
            this.gridUCList.Location = new System.Drawing.Point(24, 43);
            this.gridUCList.MainView = this.grvUCList;
            this.gridUCList.Name = "gridUCList";
            this.gridUCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.textEdit,
            this.spinEdit,
            this.dateTime});
            this.gridUCList.Size = new System.Drawing.Size(721, 310);
            this.gridUCList.TabIndex = 15;
            this.gridUCList.UseEmbeddedNavigator = true;
            this.gridUCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUCList});
            // 
            // xpcThamSo
            // 
            this.xpcThamSo.ObjectType = typeof(LeTien.Objects.ThamSo);
            // 
            // grvUCList
            // 
            this.grvUCList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenThamSo,
            this.colKieuDuLieu,
            this.colGiaTri,
            this.colOid});
            this.grvUCList.GridControl = this.gridUCList;
            this.grvUCList.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvUCList.Name = "grvUCList";
            this.grvUCList.NewItemRowText = "Thêm thông tin ca ở đây...";
            this.grvUCList.OptionsBehavior.ReadOnly = true;
            this.grvUCList.OptionsSelection.MultiSelect = true;
            this.grvUCList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvUCList.OptionsView.ShowAutoFilterRow = true;
            this.grvUCList.OptionsView.ShowGroupPanel = false;
            this.grvUCList.OptionsView.ShowIndicator = false;
            this.grvUCList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.grvUCList.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.grvUCList_CustomRowCellEdit);
            this.grvUCList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvUCList_SelectionChanged);
            // 
            // colTenThamSo
            // 
            this.colTenThamSo.FieldName = "TenThamSo";
            this.colTenThamSo.Name = "colTenThamSo";
            this.colTenThamSo.Visible = true;
            this.colTenThamSo.VisibleIndex = 1;
            this.colTenThamSo.Width = 172;
            // 
            // colKieuDuLieu
            // 
            this.colKieuDuLieu.ColumnEdit = this.repositoryItemComboBox1;
            this.colKieuDuLieu.FieldName = "KieuDuLieu";
            this.colKieuDuLieu.Name = "colKieuDuLieu";
            this.colKieuDuLieu.Visible = true;
            this.colKieuDuLieu.VisibleIndex = 2;
            this.colKieuDuLieu.Width = 172;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Int",
            "DateTime",
            "String",
            "Double"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colGiaTri
            // 
            this.colGiaTri.FieldName = "GiaTri";
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.Visible = true;
            this.colGiaTri.VisibleIndex = 3;
            this.colGiaTri.Width = 177;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(769, 377);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Thông Tin Tham Số";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(749, 357);
            this.layoutControlGroup2.Text = "Thông Tin Tham Số";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridUCList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(725, 314);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // textEdit
            // 
            this.textEdit.AutoHeight = false;
            this.textEdit.Name = "textEdit";
            // 
            // spinEdit
            // 
            this.spinEdit.AutoHeight = false;
            this.spinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit.Name = "spinEdit";
            // 
            // dateTime
            // 
            this.dateTime.AutoHeight = false;
            this.dateTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateTime.DisplayFormat.FormatString = "HH:mm";
            this.dateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTime.EditFormat.FormatString = "HH:mm";
            this.dateTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTime.Mask.EditMask = "HH:mm";
            this.dateTime.Mask.UseMaskAsDisplayFormat = true;
            this.dateTime.Name = "dateTime";
            this.dateTime.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // FrmThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 401);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Seven Classic";
            this.Name = "FrmThamSo";
            this.Text = "THAM SỐ";
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcThamSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnXuat;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraGrid.GridControl gridUCList;
        private DevExpress.Xpo.XPCollection xpcThamSo;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUCList;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThamSo;
        private DevExpress.XtraGrid.Columns.GridColumn colKieuDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateTime;
    }
}