namespace LeTien.Screens.Configurations
{
  partial class FrmDBServer
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.txtMayChuCSDL = new DevExpress.XtraEditors.TextEdit();
      this.txtMatKhauCSDL = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.Btn_Cancle = new System.Windows.Forms.Button();
      this.Btn_Login = new System.Windows.Forms.Button();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtTaiKhoanCSDL = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtTenCSDL = new DevExpress.XtraEditors.TextEdit();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtMayChuCSDL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCSDL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoanCSDL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTenCSDL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.txtTenCSDL);
      this.layoutControl1.Controls.Add(this.txtTaiKhoanCSDL);
      this.layoutControl1.Controls.Add(this.Btn_Cancle);
      this.layoutControl1.Controls.Add(this.Btn_Login);
      this.layoutControl1.Controls.Add(this.txtMayChuCSDL);
      this.layoutControl1.Controls.Add(this.txtMatKhauCSDL);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1051, 330, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(407, 162);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // txtMayChuCSDL
      // 
      this.txtMayChuCSDL.EditValue = "localhost";
      this.txtMayChuCSDL.Location = new System.Drawing.Point(90, 12);
      this.txtMayChuCSDL.Name = "txtMayChuCSDL";
      this.txtMayChuCSDL.Size = new System.Drawing.Size(305, 20);
      this.txtMayChuCSDL.StyleController = this.layoutControl1;
      this.txtMayChuCSDL.TabIndex = 5;
      // 
      // txtMatKhauCSDL
      // 
      this.txtMatKhauCSDL.Location = new System.Drawing.Point(90, 96);
      this.txtMatKhauCSDL.Name = "txtMatKhauCSDL";
      this.txtMatKhauCSDL.Properties.PasswordChar = '*';
      this.txtMatKhauCSDL.Size = new System.Drawing.Size(305, 20);
      this.txtMatKhauCSDL.StyleController = this.layoutControl1;
      this.txtMatKhauCSDL.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem3,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem7});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(407, 162);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtMayChuCSDL;
      this.layoutControlItem2.CustomizationFormText = "Tên đăng nhập";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(387, 24);
      this.layoutControlItem2.Text = "Máy chủ dữ liệu";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtMatKhauCSDL;
      this.layoutControlItem1.CustomizationFormText = "Mật khẩu";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 84);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(387, 24);
      this.layoutControlItem1.Text = "Mật khẩu";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
      // 
      // emptySpaceItem3
      // 
      this.emptySpaceItem3.AllowHotTrack = false;
      this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
      this.emptySpaceItem3.Location = new System.Drawing.Point(0, 108);
      this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 28);
      this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 28);
      this.emptySpaceItem3.Name = "emptySpaceItem3";
      this.emptySpaceItem3.Size = new System.Drawing.Size(113, 34);
      this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem3.Text = "emptySpaceItem3";
      this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem5
      // 
      this.emptySpaceItem5.AllowHotTrack = false;
      this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem4";
      this.emptySpaceItem5.Location = new System.Drawing.Point(226, 60);
      this.emptySpaceItem5.MaxSize = new System.Drawing.Size(93, 0);
      this.emptySpaceItem5.MinSize = new System.Drawing.Size(93, 10);
      this.emptySpaceItem5.Name = "emptySpaceItem4";
      this.emptySpaceItem5.Size = new System.Drawing.Size(93, 28);
      this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem5.Text = "emptySpaceItem4";
      this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
      // 
      // Btn_Cancle
      // 
      this.Btn_Cancle.Image = global::LeTien.Properties.Resources.cancel_16x16;
      this.Btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Btn_Cancle.Location = new System.Drawing.Point(125, 120);
      this.Btn_Cancle.Name = "Btn_Cancle";
      this.Btn_Cancle.Size = new System.Drawing.Size(132, 30);
      this.Btn_Cancle.TabIndex = 7;
      this.Btn_Cancle.Text = "Thoát";
      this.Btn_Cancle.UseVisualStyleBackColor = true;
      // 
      // Btn_Login
      // 
      this.Btn_Login.Image = global::LeTien.Properties.Resources.customer_16x16;
      this.Btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Btn_Login.Location = new System.Drawing.Point(261, 120);
      this.Btn_Login.Name = "Btn_Login";
      this.Btn_Login.Size = new System.Drawing.Size(134, 30);
      this.Btn_Login.TabIndex = 6;
      this.Btn_Login.Text = "Lưu";
      this.Btn_Login.UseVisualStyleBackColor = true;
      this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.Btn_Login;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(249, 108);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(24, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(138, 34);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.Btn_Cancle;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(113, 108);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(24, 24);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(136, 34);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // txtTaiKhoanCSDL
      // 
      this.txtTaiKhoanCSDL.EditValue = "root";
      this.txtTaiKhoanCSDL.Location = new System.Drawing.Point(90, 72);
      this.txtTaiKhoanCSDL.Name = "txtTaiKhoanCSDL";
      this.txtTaiKhoanCSDL.Properties.PasswordChar = '*';
      this.txtTaiKhoanCSDL.Size = new System.Drawing.Size(305, 20);
      this.txtTaiKhoanCSDL.StyleController = this.layoutControl1;
      this.txtTaiKhoanCSDL.TabIndex = 5;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.txtTaiKhoanCSDL;
      this.layoutControlItem5.CustomizationFormText = "Mật khẩu";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem5.Name = "layoutControlItem1";
      this.layoutControlItem5.Size = new System.Drawing.Size(387, 24);
      this.layoutControlItem5.Text = "Mật khẩu";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 13);
      this.layoutControlItem5.TextToControlDistance = 5;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.txtTaiKhoanCSDL;
      this.layoutControlItem6.CustomizationFormText = "Tài khoản";
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(387, 24);
      this.layoutControlItem6.Text = "Tài khoản";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(75, 13);
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.txtTenCSDL;
      this.layoutControlItem7.CustomizationFormText = "Tên CSDL";
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(387, 24);
      this.layoutControlItem7.Text = "Tên CSDL";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(75, 13);
      // 
      // txtTenCSDL
      // 
      this.txtTenCSDL.EditValue = "LeTien";
      this.txtTenCSDL.Location = new System.Drawing.Point(90, 36);
      this.txtTenCSDL.Name = "txtTenCSDL";
      this.txtTenCSDL.Size = new System.Drawing.Size(305, 20);
      this.txtTenCSDL.StyleController = this.layoutControl1;
      this.txtTenCSDL.TabIndex = 6;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
      this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 12);
      this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 12);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(387, 12);
      this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // FrmDBServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(407, 162);
      this.Controls.Add(this.layoutControl1);
      this.Name = "FrmDBServer";
      this.Text = "FrmDBServer";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtMayChuCSDL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCSDL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoanCSDL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTenCSDL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private System.Windows.Forms.Button Btn_Cancle;
    private System.Windows.Forms.Button Btn_Login;
    private DevExpress.XtraEditors.TextEdit txtMayChuCSDL;
    private DevExpress.XtraEditors.TextEdit txtMatKhauCSDL;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    private DevExpress.XtraEditors.TextEdit txtTaiKhoanCSDL;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraEditors.TextEdit txtTenCSDL;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
  }
}