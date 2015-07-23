using System;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;
using LeTien.Utils;
namespace LeTien.Objects
{

    public partial class Branch : XPObject, IDXDataErrorInfo
    {
        //public Session curSession;

       
        public Branch()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Branch(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.

            //this.curSession = session;
        }

    

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        #region "Variables"

        [DisplayName ("Mã Chi Nhánh")]
        [Indexed(Unique = true)]
        public string BranchID;
        
        [DisplayName ("Tên Chi Nhánh")]
        public string BranchName;

        [DisplayName ("Địa Chỉ")]
        public string BranchAddress;


        [DisplayName ("Số Điện Thoại")]
        public string PhoneNumber;

        #endregion

        public static string GetNumberOfEmployeesByBranchOid(string Oid, Session session)
        {
            DevExpress.Xpo.DB.SelectedData  res =   session.ExecuteQuery("SELECT COUNT(*) FROM `NhanVien` WHERE `Chinhanh` = " + Oid);

            if (res.ResultSet[0].Rows.Length > 0)
            {
                return res.ResultSet[0].Rows[0].Values[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName == "BranchID" && BranchID == "" ||
                propertyName == "BranchName" && BranchName == "")
            {
                info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName);
            }
        }
        // IDXDataErrorInfo.GetError method
        public void GetError(ErrorInfo info) { } 

    }

}