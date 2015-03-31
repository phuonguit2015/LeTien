namespace LeTien.Screens.User
{
    partial class FrmUserList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.UserList_Control = new LeTien.UCMainControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionUser = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colusername = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpassword = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colview_user = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.RI_CheckViewUser = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coledit_user = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colview_employee = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.RI_CheckViewEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coledit_employee = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_CheckViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_CheckViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.UserList_Control);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(889, 411);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // UserList_Control
            // 
            this.UserList_Control.Location = new System.Drawing.Point(12, 12);
            this.UserList_Control.Name = "UserList_Control";
            this.UserList_Control.Size = new System.Drawing.Size(865, 40);
            this.UserList_Control.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.xpCollectionUser;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 56);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RI_CheckViewUser,
            this.RI_CheckViewEmployee});
            this.gridControl1.Size = new System.Drawing.Size(865, 343);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // xpCollectionUser
            // 
            this.xpCollectionUser.ObjectType = typeof(LeTien.Objects.User);
            this.xpCollectionUser.Session = this.session1;
            this.xpCollectionUser.CollectionChanged += new DevExpress.Xpo.XPCollectionChangedEventHandler(this.xpCollectionUser_CollectionChanged);
            // 
            // session1
            // 
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand5});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colOid,
            this.colusername,
            this.colview_user,
            this.coledit_user,
            this.colpassword,
            this.colview_employee,
            this.coledit_employee});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsCustomization.AllowGroup = false;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.bandedGridView1_ShowingEditor);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Tên đăng nhập";
            this.gridBand1.Columns.Add(this.colOid);
            this.gridBand1.Columns.Add(this.colusername);
            this.gridBand1.Columns.Add(this.colpassword);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 122;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.AllowFocus = false;
            this.colusername.OptionsColumn.ShowCaption = false;
            this.colusername.Visible = true;
            this.colusername.Width = 122;
            // 
            // colpassword
            // 
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.ShowCaption = false;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Quyền người dùng";
            this.gridBand2.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4});
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Xem";
            this.gridBand3.Columns.Add(this.colview_user);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 75;
            // 
            // colview_user
            // 
            this.colview_user.ColumnEdit = this.RI_CheckViewUser;
            this.colview_user.FieldName = "view_user";
            this.colview_user.Name = "colview_user";
            this.colview_user.OptionsColumn.ShowCaption = false;
            this.colview_user.Visible = true;
            // 
            // RI_CheckViewUser
            // 
            this.RI_CheckViewUser.AutoHeight = false;
            this.RI_CheckViewUser.Name = "RI_CheckViewUser";
            this.RI_CheckViewUser.CheckedChanged += new System.EventHandler(this.RI_CheckViewUser_CheckedChanged);
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Sửa";
            this.gridBand4.Columns.Add(this.coledit_user);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 75;
            // 
            // coledit_user
            // 
            this.coledit_user.FieldName = "edit_user";
            this.coledit_user.Name = "coledit_user";
            this.coledit_user.OptionsColumn.ShowCaption = false;
            this.coledit_user.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Quyền nhân sự";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand6,
            this.gridBand7});
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 2;
            this.gridBand5.Width = 150;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Xem";
            this.gridBand6.Columns.Add(this.colview_employee);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 0;
            this.gridBand6.Width = 75;
            // 
            // colview_employee
            // 
            this.colview_employee.ColumnEdit = this.RI_CheckViewEmployee;
            this.colview_employee.FieldName = "view_employee";
            this.colview_employee.Name = "colview_employee";
            this.colview_employee.OptionsColumn.ShowCaption = false;
            this.colview_employee.Visible = true;
            // 
            // RI_CheckViewEmployee
            // 
            this.RI_CheckViewEmployee.AutoHeight = false;
            this.RI_CheckViewEmployee.Name = "RI_CheckViewEmployee";
            this.RI_CheckViewEmployee.CheckedChanged += new System.EventHandler(this.RI_CheckViewEmployee_CheckedChanged);
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "Sửa";
            this.gridBand7.Columns.Add(this.coledit_employee);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 75;
            // 
            // coledit_employee
            // 
            this.coledit_employee.FieldName = "edit_employee";
            this.coledit_employee.Name = "coledit_employee";
            this.coledit_employee.OptionsColumn.ShowCaption = false;
            this.coledit_employee.Visible = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(889, 411);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(869, 347);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.UserList_Control;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(869, 44);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 411);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmUserList";
            this.Text = "Danh sách người dùng";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_CheckViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RI_CheckViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UCMainControl UserList_Control;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Xpo.Session session1;
        private DevExpress.Xpo.XPCollection xpCollectionUser;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colusername;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpassword;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colview_user;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coledit_user;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colview_employee;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coledit_employee;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RI_CheckViewUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RI_CheckViewEmployee;

    }
}