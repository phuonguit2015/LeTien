using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using LeTien.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTien.Screens.Salaries
{
    public partial class FrmXepCaNhanVien : FormBase
    {
        public FrmXepCaNhanVien()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXepCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtThang.EditValue != null)
            {
                ThongTinXepCaTheoThang(DateTime.Parse(dtThang.EditValue.ToString()));
            }
        }

        private void ThongTinXepCaTheoThang(DateTime thang)
        {
            string str = thang.Month.ToString() + "-" + thang.Year.ToString();// Phân biệt bảng xếp ca các tháng
            XPCollection xpc = new XPCollection(xpcXepCa, new BinaryOperator("Key", str, BinaryOperatorType.Equal));
            if (xpc.Count > 0)
            {
                gridControl1.DataSource = xpc;
            }
            else
            {
                XtraMessageBox.Show("Chưa có thông tin xếp ca của tháng này.","Thông Báo");
            }
        }

        private void dtThang_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmXepCaNhanVien_Load(object sender, EventArgs e)
        {
            dtThang.EditValue = DateTime.Now;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.OptionsBehavior.ReadOnly)
            {
                btnEdit.Caption = "CHẾ ĐỘ CHỈNH SỬA";
                gridView1.OptionsBehavior.ReadOnly = false;
                foreach (GridColumn col in gridView1.Columns)
                {
                    col.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                btnEdit.Caption = "CHẾ ĐỘ CHỈ ĐỌC";
                foreach (GridColumn col in gridView1.Columns)
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                string _id = gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], colOid).ToString();

                using (var uow = new UnitOfWork())
                {
                    ChiTietXepCa br = uow.FindObject<ChiTietXepCa>(CriteriaOperator.Parse("Oid = ?", _id));
                    if (br != null)
                    {
                        br.Delete();
                        uow.CommitChanges();
                        uow.PurgeDeletedObjects();
                    }
                }
            }
            RefreshData();
        }

        private void RefreshData()
        {
            UOW.ReloadChangedObjects();
            xpcXepCa.Reload();
            gridControl1.DataSource = xpcXepCa;
        }
        private void grvUCList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btnXoa.Enabled = false;
            if (gridView1.SelectedRowsCount > 0)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
    }
}
