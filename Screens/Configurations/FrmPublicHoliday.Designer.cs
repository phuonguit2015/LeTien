namespace LeTien.Screens
{
    partial class FrmPublicHoliday
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
            this.xpcPublicHoliday = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridUCList = new DevExpress.XtraGrid.GridControl();
            this.grvUCList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPublicHolidayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinNam = new DevExpress.XtraEditors.SpinEdit();
            this.ucMenu = new LeTien.UCMainControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colMauHienThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcPublicHoliday
            // 
            this.xpcPublicHoliday.ObjectType = typeof(LeTien.Objects.PublicHoliday);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridUCList);
            this.layoutControl1.Controls.Add(this.spinNam);
            this.layoutControl1.Controls.Add(this.ucMenu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(986, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridUCList
            // 
            this.gridUCList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUCList.DataSource = this.xpcPublicHoliday;
            this.gridUCList.Location = new System.Drawing.Point(24, 77);
            this.gridUCList.MainView = this.grvUCList;
            this.gridUCList.Name = "gridUCList";
            this.gridUCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit1});
            this.gridUCList.Size = new System.Drawing.Size(938, 315);
            this.gridUCList.TabIndex = 7;
            this.gridUCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUCList});
            // 
            // grvUCList
            // 
            this.grvUCList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPublicHolidayName,
            this.colPublicHolidayStart,
            this.colPublicHolidayEnd,
            this.colPublicHolidayDescription,
            this.colMauHienThi});
            this.grvUCList.GridControl = this.gridUCList;
            this.grvUCList.Name = "grvUCList";
            this.grvUCList.OptionsView.ShowAutoFilterRow = true;
            this.grvUCList.OptionsView.ShowGroupPanel = false;
            this.grvUCList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvUCList_RowClick);
            this.grvUCList.DoubleClick += new System.EventHandler(this.grvUCList_DoubleClick);
            // 
            // colPublicHolidayName
            // 
            this.colPublicHolidayName.FieldName = "PublicHolidayName";
            this.colPublicHolidayName.Name = "colPublicHolidayName";
            this.colPublicHolidayName.Visible = true;
            this.colPublicHolidayName.VisibleIndex = 0;
            // 
            // colPublicHolidayStart
            // 
            this.colPublicHolidayStart.FieldName = "PublicHolidayStart";
            this.colPublicHolidayStart.Name = "colPublicHolidayStart";
            this.colPublicHolidayStart.Visible = true;
            this.colPublicHolidayStart.VisibleIndex = 1;
            // 
            // colPublicHolidayEnd
            // 
            this.colPublicHolidayEnd.FieldName = "PublicHolidayEnd";
            this.colPublicHolidayEnd.Name = "colPublicHolidayEnd";
            this.colPublicHolidayEnd.Visible = true;
            this.colPublicHolidayEnd.VisibleIndex = 2;
            // 
            // colPublicHolidayDescription
            // 
            this.colPublicHolidayDescription.FieldName = "PublicHolidayDescription";
            this.colPublicHolidayDescription.Name = "colPublicHolidayDescription";
            this.colPublicHolidayDescription.Visible = true;
            this.colPublicHolidayDescription.VisibleIndex = 3;
            // 
            // spinNam
            // 
            this.spinNam.EditValue = new decimal(new int[] {
            1090,
            0,
            0,
            0});
            this.spinNam.Location = new System.Drawing.Point(40, 12);
            this.spinNam.Name = "spinNam";
            this.spinNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinNam.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spinNam.Properties.MinValue = new decimal(new int[] {
            1090,
            0,
            0,
            0});
            this.spinNam.Size = new System.Drawing.Size(60, 20);
            this.spinNam.StyleController = this.layoutControl1;
            this.spinNam.TabIndex = 6;
            this.spinNam.EditValueChanged += new System.EventHandler(this.spinNam_EditValueChanged);
            // 
            // ucMenu
            // 
            this.ucMenu.Location = new System.Drawing.Point(104, 12);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(870, 30);
            this.ucMenu.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(986, 416);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ucMenu;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(92, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(874, 34);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinNam;
            this.layoutControlItem2.CustomizationFormText = "Năm:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(92, 24);
            this.layoutControlItem2.Text = "Năm:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(25, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(92, 10);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Danh sách ngày lễ";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(966, 362);
            this.layoutControlGroup2.Text = "Danh sách ngày lễ";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridUCList;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(942, 319);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // colMauHienThi
            // 
            this.colMauHienThi.ColumnEdit = this.repositoryItemColorPickEdit1;
            this.colMauHienThi.FieldName = "MauHienThi";
            this.colMauHienThi.Name = "colMauHienThi";
            this.colMauHienThi.Visible = true;
            this.colMauHienThi.VisibleIndex = 4;
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // FrmPublicHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 416);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPublicHoliday";
            this.Text = "Quản lý ngày lễ";
            this.Load += new System.EventHandler(this.FrmPublicHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcPublicHoliday;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SpinEdit spinNam;
        private UCMainControl ucMenu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridUCList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUCList;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayName;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayStart;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicHolidayDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colMauHienThi;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
    }
}