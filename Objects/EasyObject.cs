using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace LeTien.Objects
{
   

    [NonPersistent(), OptimisticLocking(true)] // <- Không lưu CSDL và OptimisticLocking để quản lý nhiều truy cập đến cùng 1 đối tượng cùng lúc -> XPO tự động ^^!
    public class EasyObject : XPCustomObject
    {
        // Khai báo 1 số hằng số --> tùy ý, cái này để quy định kích thước dữ liệu trong CSDL
        /// <summary>
        /// 32
        /// </summary>
        public const int SIZE_SMALL = 32;
        /// <summary>
        /// 128
        /// </summary>
        public const int SIZE_NORMAL = 128;
        /// <summary>
        /// 256
        /// </summary>
        public const int SIZE_LONG = 256;
        /// <summary>
        /// 512
        /// </summary>
        public const int SIZE_VERY_LONG = 512;
        /// <summary>
        /// 4000
        /// </summary>
        public const int SIZE_MAX = 4000;


        public EasyObject()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public EasyObject(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }


        [Key(true)] // <- true, khóa tự sinh
        public int ID;
        public DateTime LastUpdated;
        [Size(SIZE_NORMAL)]
        public string UpdatedBy;

        [NonPersistent()] // <- Không lưu CSDL
        public bool IsNewObject
        {
            get { return this.Session.IsNewObject(this); }
        }
        protected override void OnSaving()
        {
            //LastUpdated = DateTime.Now;
            //UpdatedBy = User.CurrentUser == null ? "system" : User.CurrentUser.UserName;

            base.OnSaving();
        }


        public static object FindObject(Session s, Type type, string propertiyName, object value)
        {
            if (s == null) s = XpoDefault.Session;
            string strFilter = string.Format("[{0}]=?", propertiyName);
            return s.FindObject(type, CriteriaOperator.Parse(strFilter, value));
        }
        public static T FindObject<T>(string propertiyName, object value)
        {
            return EasyObject.FindObject<T>(null, propertiyName, value);
        }
        public static T FindObject<T>(Session s, string propertiyName, object value)
        {
            if (s == null) s = XpoDefault.Session;
            string strFilter = string.Format("[{0}]=?", propertiyName);
            return s.FindObject<T>(CriteriaOperator.Parse(strFilter, value));
        }
    }

}
