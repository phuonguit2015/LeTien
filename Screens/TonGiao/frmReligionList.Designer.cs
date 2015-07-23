namespace LeTien.Screens.List
{
    partial class frmReligionList
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridUCList = new DevExpress.XtraGrid.GridControl();
            this.xpcReligion = new DevExpress.Xpo.XPCollection(this.components);
            this.grvUCList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RITextFistname = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RITextLastname = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.R_BranchSelect = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.R_CompentenceSelect = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ucMenu = new LeTien.UCMainControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcReligion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextFistname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_BranchSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_CompentenceSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.ucMenu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(754, 368);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridUCList);
            this.panelControl1.Location = new System.Drawing.Point(27, 74);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 267);
            this.panelControl1.TabIndex = 5;
            // 
            // gridUCList
            // 
            this.gridUCList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUCList.DataSource = this.xpcReligion;
            this.gridUCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUCList.Location = new System.Drawing.Point(2, 2);
            this.gridUCList.MainView = this.grvUCList;
            this.gridUCList.Name = "gridUCList";
            this.gridUCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RITextFistname,
            this.RITextLastname,
            this.R_BranchSelect,
            this.R_CompentenceSelect});
            this.gridUCList.Size = new System.Drawing.Size(696, 263);
            this.gridUCList.TabIndex = 11;
            this.gridUCList.UseEmbeddedNavigator = true;
            this.gridUCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUCList});
            // 
            // xpcReligion
            // 
            this.xpcReligion.DisplayableProperties = "ReligionID;ReligionName";
            this.xpcReligion.ObjectType = typeof(LeTien.Objects.Religion);
            // 
            // grvUCList
            // 
            this.grvUCList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchID,
            this.colBranchName});
            this.grvUCList.GridControl = this.gridUCList;
            this.grvUCList.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvUCList.Name = "grvUCList";
            this.grvUCList.OptionsBehavior.ReadOnly = true;
            this.grvUCList.OptionsSelection.MultiSelect = true;
            this.grvUCList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvUCList.OptionsView.ShowAutoFilterRow = true;
            this.grvUCList.OptionsView.ShowGroupPanel = false;
            this.grvUCList.OptionsView.ShowIndicator = false;
            this.grvUCList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.grvUCList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvUCList_SelectionChanged_1);
            // 
            // colBranchID
            // 
            this.colBranchID.FieldName = "ReligionID";
            this.colBranchID.Name = "colBranchID";
            this.colBranchID.Visible = true;
            this.colBranchID.VisibleIndex = 1;
            this.colBranchID.Width = 128;
            // 
            // colBranchName
            // 
            this.colBranchName.FieldName = "ReligionName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 2;
            this.colBranchName.Width = 263;
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
            // ucMenu
            // 
            this.ucMenu.Location = new System.Drawing.Point(12, 12);
            this.ucMenu.MaximumSize = new System.Drawing.Size(730, 24);
            this.ucMenu.MinimumSize = new System.Drawing.Size(730, 24);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(730, 24);
            this.ucMenu.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(754, 368);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ucMenu;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(734, 28);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Danh sách tôn giáo";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(734, 320);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Text = "Danh sách tôn giáo";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(704, 271);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmReligionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 368);
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Seven Classic";
            this.Name = "frmReligionList";
            this.Text = "DANH SÁCH TÔN GIÁO";
            this.Load += new System.EventHandler(this.frmReligionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcReligion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUCList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextFistname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RITextLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_BranchSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_CompentenceSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UCMainControl ucMenu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public DevExpress.XtraGrid.GridControl gridUCList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUCList;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchID;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RITextFistname;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RITextLastname;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit R_BranchSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit R_CompentenceSelect;
        private DevExpress.Xpo.XPCollection xpcReligion;
        //private DevExpress.Xpo.UnitOfWork UOW;

    }
}