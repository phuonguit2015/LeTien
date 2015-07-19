namespace LeTien.Screens
{
    partial class FrmChamCong
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpcChamCong = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBangChamCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHieuSuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay31 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpcChamCong;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 397);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // xpcChamCong
            // 
            this.xpcChamCong.ObjectType = typeof(LeTien.Objects.ChamCong);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colTenBangChamCong,
            this.gridColumn1,
            this.gridColumn2,
            this.colThang,
            this.gridColumn3,
            this.gridColumn4,
            this.colKetQua,
            this.colFirstDate,
            this.colLastDate,
            this.colHieuSuat,
            this.colNgay1,
            this.colNgay2,
            this.colNgay3,
            this.colNgay4,
            this.colNgay5,
            this.colNgay6,
            this.colNgay7,
            this.colNgay8,
            this.colNgay9,
            this.colNgay10,
            this.colNgay11,
            this.colNgay12,
            this.colNgay13,
            this.colNgay14,
            this.colNgay15,
            this.colNgay16,
            this.colNgay17,
            this.colNgay18,
            this.colNgay19,
            this.colNgay20,
            this.colNgay21,
            this.colNgay22,
            this.colNgay23,
            this.colNgay24,
            this.colNgay25,
            this.colNgay26,
            this.colNgay27,
            this.colNgay28,
            this.colNgay29,
            this.colNgay30,
            this.colNgay31});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            // 
            // colTenBangChamCong
            // 
            this.colTenBangChamCong.FieldName = "TenBangChamCong";
            this.colTenBangChamCong.Name = "colTenBangChamCong";
            this.colTenBangChamCong.Visible = true;
            this.colTenBangChamCong.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "NhanVien!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "NhanVien!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // colThang
            // 
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "LoaiDuLieuChamCong!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "LoaiDuLieuChamCong!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // colKetQua
            // 
            this.colKetQua.FieldName = "KetQua";
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.Visible = true;
            this.colKetQua.VisibleIndex = 7;
            // 
            // colFirstDate
            // 
            this.colFirstDate.FieldName = "FirstDate";
            this.colFirstDate.Name = "colFirstDate";
            this.colFirstDate.Visible = true;
            this.colFirstDate.VisibleIndex = 8;
            // 
            // colLastDate
            // 
            this.colLastDate.FieldName = "LastDate";
            this.colLastDate.Name = "colLastDate";
            this.colLastDate.Visible = true;
            this.colLastDate.VisibleIndex = 9;
            // 
            // colHieuSuat
            // 
            this.colHieuSuat.FieldName = "HieuSuat";
            this.colHieuSuat.Name = "colHieuSuat";
            this.colHieuSuat.Visible = true;
            this.colHieuSuat.VisibleIndex = 10;
            // 
            // colNgay1
            // 
            this.colNgay1.FieldName = "Ngay1";
            this.colNgay1.Name = "colNgay1";
            this.colNgay1.Visible = true;
            this.colNgay1.VisibleIndex = 11;
            // 
            // colNgay2
            // 
            this.colNgay2.FieldName = "Ngay2";
            this.colNgay2.Name = "colNgay2";
            this.colNgay2.Visible = true;
            this.colNgay2.VisibleIndex = 12;
            // 
            // colNgay3
            // 
            this.colNgay3.FieldName = "Ngay3";
            this.colNgay3.Name = "colNgay3";
            this.colNgay3.Visible = true;
            this.colNgay3.VisibleIndex = 13;
            // 
            // colNgay4
            // 
            this.colNgay4.FieldName = "Ngay4";
            this.colNgay4.Name = "colNgay4";
            this.colNgay4.Visible = true;
            this.colNgay4.VisibleIndex = 14;
            // 
            // colNgay5
            // 
            this.colNgay5.FieldName = "Ngay5";
            this.colNgay5.Name = "colNgay5";
            this.colNgay5.Visible = true;
            this.colNgay5.VisibleIndex = 15;
            // 
            // colNgay6
            // 
            this.colNgay6.FieldName = "Ngay6";
            this.colNgay6.Name = "colNgay6";
            this.colNgay6.Visible = true;
            this.colNgay6.VisibleIndex = 16;
            // 
            // colNgay7
            // 
            this.colNgay7.FieldName = "Ngay7";
            this.colNgay7.Name = "colNgay7";
            this.colNgay7.Visible = true;
            this.colNgay7.VisibleIndex = 17;
            // 
            // colNgay8
            // 
            this.colNgay8.FieldName = "Ngay8";
            this.colNgay8.Name = "colNgay8";
            this.colNgay8.Visible = true;
            this.colNgay8.VisibleIndex = 18;
            // 
            // colNgay9
            // 
            this.colNgay9.FieldName = "Ngay9";
            this.colNgay9.Name = "colNgay9";
            this.colNgay9.Visible = true;
            this.colNgay9.VisibleIndex = 19;
            // 
            // colNgay10
            // 
            this.colNgay10.FieldName = "Ngay10";
            this.colNgay10.Name = "colNgay10";
            this.colNgay10.Visible = true;
            this.colNgay10.VisibleIndex = 20;
            // 
            // colNgay11
            // 
            this.colNgay11.FieldName = "Ngay11";
            this.colNgay11.Name = "colNgay11";
            this.colNgay11.Visible = true;
            this.colNgay11.VisibleIndex = 21;
            // 
            // colNgay12
            // 
            this.colNgay12.FieldName = "Ngay12";
            this.colNgay12.Name = "colNgay12";
            this.colNgay12.Visible = true;
            this.colNgay12.VisibleIndex = 22;
            // 
            // colNgay13
            // 
            this.colNgay13.FieldName = "Ngay13";
            this.colNgay13.Name = "colNgay13";
            this.colNgay13.Visible = true;
            this.colNgay13.VisibleIndex = 23;
            // 
            // colNgay14
            // 
            this.colNgay14.FieldName = "Ngay14";
            this.colNgay14.Name = "colNgay14";
            this.colNgay14.Visible = true;
            this.colNgay14.VisibleIndex = 24;
            // 
            // colNgay15
            // 
            this.colNgay15.FieldName = "Ngay15";
            this.colNgay15.Name = "colNgay15";
            this.colNgay15.Visible = true;
            this.colNgay15.VisibleIndex = 25;
            // 
            // colNgay16
            // 
            this.colNgay16.FieldName = "Ngay16";
            this.colNgay16.Name = "colNgay16";
            this.colNgay16.Visible = true;
            this.colNgay16.VisibleIndex = 26;
            // 
            // colNgay17
            // 
            this.colNgay17.FieldName = "Ngay17";
            this.colNgay17.Name = "colNgay17";
            this.colNgay17.Visible = true;
            this.colNgay17.VisibleIndex = 27;
            // 
            // colNgay18
            // 
            this.colNgay18.FieldName = "Ngay18";
            this.colNgay18.Name = "colNgay18";
            this.colNgay18.Visible = true;
            this.colNgay18.VisibleIndex = 28;
            // 
            // colNgay19
            // 
            this.colNgay19.FieldName = "Ngay19";
            this.colNgay19.Name = "colNgay19";
            this.colNgay19.Visible = true;
            this.colNgay19.VisibleIndex = 29;
            // 
            // colNgay20
            // 
            this.colNgay20.FieldName = "Ngay20";
            this.colNgay20.Name = "colNgay20";
            this.colNgay20.Visible = true;
            this.colNgay20.VisibleIndex = 30;
            // 
            // colNgay21
            // 
            this.colNgay21.FieldName = "Ngay21";
            this.colNgay21.Name = "colNgay21";
            this.colNgay21.Visible = true;
            this.colNgay21.VisibleIndex = 31;
            // 
            // colNgay22
            // 
            this.colNgay22.FieldName = "Ngay22";
            this.colNgay22.Name = "colNgay22";
            this.colNgay22.Visible = true;
            this.colNgay22.VisibleIndex = 32;
            // 
            // colNgay23
            // 
            this.colNgay23.FieldName = "Ngay23";
            this.colNgay23.Name = "colNgay23";
            this.colNgay23.Visible = true;
            this.colNgay23.VisibleIndex = 33;
            // 
            // colNgay24
            // 
            this.colNgay24.FieldName = "Ngay24";
            this.colNgay24.Name = "colNgay24";
            this.colNgay24.Visible = true;
            this.colNgay24.VisibleIndex = 34;
            // 
            // colNgay25
            // 
            this.colNgay25.FieldName = "Ngay25";
            this.colNgay25.Name = "colNgay25";
            this.colNgay25.Visible = true;
            this.colNgay25.VisibleIndex = 35;
            // 
            // colNgay26
            // 
            this.colNgay26.FieldName = "Ngay26";
            this.colNgay26.Name = "colNgay26";
            this.colNgay26.Visible = true;
            this.colNgay26.VisibleIndex = 36;
            // 
            // colNgay27
            // 
            this.colNgay27.FieldName = "Ngay27";
            this.colNgay27.Name = "colNgay27";
            this.colNgay27.Visible = true;
            this.colNgay27.VisibleIndex = 37;
            // 
            // colNgay28
            // 
            this.colNgay28.FieldName = "Ngay28";
            this.colNgay28.Name = "colNgay28";
            this.colNgay28.Visible = true;
            this.colNgay28.VisibleIndex = 38;
            // 
            // colNgay29
            // 
            this.colNgay29.FieldName = "Ngay29";
            this.colNgay29.Name = "colNgay29";
            this.colNgay29.Visible = true;
            this.colNgay29.VisibleIndex = 39;
            // 
            // colNgay30
            // 
            this.colNgay30.FieldName = "Ngay30";
            this.colNgay30.Name = "colNgay30";
            this.colNgay30.Visible = true;
            this.colNgay30.VisibleIndex = 40;
            // 
            // colNgay31
            // 
            this.colNgay31.FieldName = "Ngay31";
            this.colNgay31.Name = "colNgay31";
            this.colNgay31.Visible = true;
            this.colNgay31.VisibleIndex = 41;
            // 
            // FrmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 397);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmChamCong";
            this.Text = "FrmChamCong";
            this.Load += new System.EventHandler(this.FrmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection xpcChamCong;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBangChamCong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQua;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHieuSuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay2;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay3;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay4;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay5;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay6;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay7;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay8;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay9;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay10;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay11;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay12;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay13;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay14;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay15;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay16;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay17;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay18;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay19;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay20;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay21;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay22;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay23;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay24;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay25;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay26;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay27;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay28;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay29;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay30;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay31;
    }
}