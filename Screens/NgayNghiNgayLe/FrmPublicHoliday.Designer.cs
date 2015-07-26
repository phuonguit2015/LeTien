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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicHoliday));
            this.xpcPublicHoliday = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.gridUCList = new DevExpress.XtraGrid.GridControl();
            this.grvUCList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPublicHolidayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicHolidayDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMauHienThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinNam = new DevExpress.XtraEditors.SpinEdit();
            this.ucMenu = new LeTien.UCMainControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpcPublicHoliday
            // 
            this.xpcPublicHoliday.ObjectType = typeof(LeTien.Objects.PublicHoliday);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLoc);
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
            // btnLoc
            // 
            this.btnLoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Appearance.Options.UseFont = true;
            this.btnLoc.AutoWidthInLayoutControl = true;
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(909, 73);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(53, 23);
            this.btnLoc.StyleController = this.layoutControl1;
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "LỌC";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // gridUCList
            // 
            this.gridUCList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUCList.DataSource = this.xpcPublicHoliday;
            this.gridUCList.Location = new System.Drawing.Point(29, 105);
            this.gridUCList.MainView = this.grvUCList;
            this.gridUCList.Margin = new System.Windows.Forms.Padding(5);
            this.gridUCList.Name = "gridUCList";
            this.gridUCList.Padding = new System.Windows.Forms.Padding(5);
            this.gridUCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit1});
            this.gridUCList.Size = new System.Drawing.Size(928, 282);
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
            this.colMauHienThi,
            this.colOid});
            this.grvUCList.GridControl = this.gridUCList;
            this.grvUCList.Name = "grvUCList";
            this.grvUCList.OptionsSelection.MultiSelect = true;
            this.grvUCList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvUCList.OptionsView.ShowAutoFilterRow = true;
            this.grvUCList.OptionsView.ShowGroupPanel = false;
            this.grvUCList.OptionsView.ShowIndicator = false;
            this.grvUCList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvUCList_SelectionChanged);
            // 
            // colPublicHolidayName
            // 
            this.colPublicHolidayName.FieldName = "PublicHolidayName";
            this.colPublicHolidayName.Name = "colPublicHolidayName";
            this.colPublicHolidayName.Visible = true;
            this.colPublicHolidayName.VisibleIndex = 1;
            this.colPublicHolidayName.Width = 179;
            // 
            // colPublicHolidayStart
            // 
            this.colPublicHolidayStart.FieldName = "PublicHolidayStart";
            this.colPublicHolidayStart.Name = "colPublicHolidayStart";
            this.colPublicHolidayStart.Visible = true;
            this.colPublicHolidayStart.VisibleIndex = 2;
            this.colPublicHolidayStart.Width = 179;
            // 
            // colPublicHolidayEnd
            // 
            this.colPublicHolidayEnd.FieldName = "PublicHolidayEnd";
            this.colPublicHolidayEnd.Name = "colPublicHolidayEnd";
            this.colPublicHolidayEnd.Visible = true;
            this.colPublicHolidayEnd.VisibleIndex = 3;
            this.colPublicHolidayEnd.Width = 179;
            // 
            // colPublicHolidayDescription
            // 
            this.colPublicHolidayDescription.FieldName = "PublicHolidayDescription";
            this.colPublicHolidayDescription.Name = "colPublicHolidayDescription";
            this.colPublicHolidayDescription.Visible = true;
            this.colPublicHolidayDescription.VisibleIndex = 4;
            this.colPublicHolidayDescription.Width = 179;
            // 
            // colMauHienThi
            // 
            this.colMauHienThi.ColumnEdit = this.repositoryItemColorPickEdit1;
            this.colMauHienThi.FieldName = "MauHienThi";
            this.colMauHienThi.Name = "colMauHienThi";
            this.colMauHienThi.Visible = true;
            this.colMauHienThi.VisibleIndex = 5;
            this.colMauHienThi.Width = 185;
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // colOid
            // 
            this.colOid.Caption = "OID";
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // spinNam
            // 
            this.spinNam.EditValue = new decimal(new int[] {
            1090,
            0,
            0,
            0});
            this.spinNam.Location = new System.Drawing.Point(850, 73);
            this.spinNam.MaximumSize = new System.Drawing.Size(55, 22);
            this.spinNam.Name = "spinNam";
            this.spinNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinNam.Properties.Appearance.Options.UseFont = true;
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
            this.spinNam.Size = new System.Drawing.Size(55, 22);
            this.spinNam.StyleController = this.layoutControl1;
            this.spinNam.TabIndex = 6;
            // 
            // ucMenu
            // 
            this.ucMenu.Location = new System.Drawing.Point(12, 12);
            this.ucMenu.MaximumSize = new System.Drawing.Size(641, 26);
            this.ucMenu.MinimumSize = new System.Drawing.Size(641, 26);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(641, 26);
            this.ucMenu.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(986, 416);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Danh sách ngày lễ";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(966, 366);
            this.layoutControlGroup2.Text = "Danh sách ngày nghĩ lễ";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ucMenu;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(966, 30);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(727, 27);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.BestFitWeight = 120;
            this.layoutControlItem2.Control = this.spinNam;
            this.layoutControlItem2.CustomizationFormText = "Năm:";
            this.layoutControlItem2.Location = new System.Drawing.Point(727, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(158, 27);
            this.layoutControlItem2.Text = "LỌC THEO NĂM";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 16);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridUCList;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(942, 296);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnLoc;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(885, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(57, 27);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.BestFitWeight = 120;
            this.layoutControlItem4.Control = this.spinNam;
            this.layoutControlItem4.CustomizationFormText = "Năm:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(942, 24);
            this.layoutControlItem4.Text = "LỌC THEO NĂM";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 16);
            this.layoutControlItem4.TextToControlDistance = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ucMenu;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(589, 30);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmPublicHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 416);
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Seven Classic";
            this.Name = "FrmPublicHoliday";
            this.Text = "QUẢN LÝ NGÀY NGHĨ LỄ";
            this.Load += new System.EventHandler(this.FrmPublicHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcPublicHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpcPublicHoliday;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SpinEdit spinNam;
        private UCMainControl ucMenu;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}