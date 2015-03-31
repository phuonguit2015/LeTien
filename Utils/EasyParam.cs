/* ----------------------------------- File Header -------------------------------------------*
	File				:	EasyParam.cs
	Project Code		:	
	Author	    		:	Nhan Tran
	Created On	    	:	15/12/2007 
	Last Modified	   	:	15/12/2007 
----------------------------------------------------------------------------------------------*
	Type				:	c sharp file
	Description			:   Hàm tiện ích truy vấn đến tham số (chưa có thì tạo luôn trong CSDL)
	Developer's Note	:	
	Bugs				:	
	See Also			:	
	Revision History	:	
	Traceability        :	
	Necessary Files		:	
---------------------------------------------------------------------------------------------*/

using System;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using LeTien.Objects;



namespace LeTien.Utils
{
    public enum DataType
    {
        [Description("Chuỗi ký tự")]            String              = 0,
        [Description("Đúng/Sai")]               Bool                = 1,
        [Description("Ngày giờ")]               DateTime            = 2,
        [Description("Số nguyên")]              Int32               = 3,
        [Description("Số thập phân")]           Decimal             = 4
    }
    public enum ParamCategory
    {
        /// <summary>
        /// Mặc định
        /// </summary>
        [Description("Mặc định")]
        Default = 0,
        /// <summary>
        /// Hệ thống
        /// </summary>
        [Description("Hệ thống")]
        System = 1,
        /// <summary>
        /// Định dạng ngày giờ
        /// </summary>
        [Description("Định dạng ngày giờ")]
        DateTimeFormat = 2,
        /// <summary>
        /// Định dạng tiền
        /// </summary>
        [Description("Định dạng số tiền")]
        MoneyFormat = 3,
        /// <summary>
        /// Định dạng số
        /// </summary>
        [Description("Định dạng số")]
        NumberFormat = 4,
        /// <summary>
        /// Cấu hình
        /// </summary>
        [Description("Cấu hình")]
        UserConfig = 5,
        /// <summary>
        /// Thông tin doanh nghiệp
        /// </summary>
        [Description("Thông tin doanh nghiệp")]
        CompanyInfo = 6,
        /// <summary>
        /// Nghiệp vụ
        /// </summary>
        [Description("Nghiệp vụ")]
        Setting = 7,
        /// <summary>
        /// Phát sinh
        /// </summary>
        [Description("Phát sinh")]
        Generate = 99
    }

    
    public class EasyParam : EasyObject
    {
        public EasyParam() : base() { }
        public EasyParam(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            AllowChange = true;
            ValueType = DataType.String;
            ParamCategory = ParamCategory.Default;
        }
        
       
        public string ParamCode;
        public string Value;
        
        [NonPersistent()]
        public Object OptionValue
        {
            get
            {
                Object value;
                switch (ValueType)
                {
                    case DataType.Bool:
                        try { value = Convert.ToBoolean(Value); }
                        catch { value = Value; ;}
                        break;
                    case DataType.DateTime:
                        try { value = Convert.ToDateTime(Value); }
                        catch { value = Value; }
                        break;
                    case DataType.Decimal:
                        try { value = Convert.ToDecimal(Value); }
                        catch { value = Value; }
                        break;
                    case DataType.Int32:
                        try { value = Convert.ToInt32(Value); }
                        catch { value = Value; }
                        break;
                    default: value = Value; break;
                }
                return value;
            }
            set
            {
                if (AllowChange && value != null)
                    Value = value.ToString();
            }
        }

        public DataType ValueType;
        public bool AllowChange; //<<<-- tạm thời chưa có tác dụng gì
        public ParamCategory ParamCategory;

        /// <summary>
        /// Lấy giá trị tham số bởi displayCode
        /// </summary>
        /// <param name="displayCode"></param>
        /// <param name="value">Giá trị trả về</param>
        public static void GetValue(string displayCode, out object value)
        {
            EasyParam c = EasyObject.FindObject<EasyParam>("ParamCode", displayCode);
            if (c == null)
            {
                value = null;
                return;
            }
            switch (c.ValueType)
            {
                case DataType.Bool:     value = Convert.ToBoolean(c.OptionValue); break;
                case DataType.DateTime: value = Convert.ToDateTime(c.OptionValue); break;
                case DataType.Decimal:  value = Convert.ToDecimal(c.OptionValue); break;
                case DataType.Int32:    value = Convert.ToInt32(c.OptionValue); break;
                default:                value = c.OptionValue; break;
            }
        }
        /// <summary>
        /// Lấy giá trị tham số bởi tên tham số,  nếu không có -> tạo tham số với giá trị mặc định
        /// </summary>
        /// <param name="paramCode">Tên tham số</param>
        /// <param name="value">Giá trị trả về</param>
        /// <param name="category">Loại tham số</param>
        /// <param name="defaultValue">Giá trị mặc định</param>
        /// <param name="type">Kiểu dữ liệu</param>
        public static void GetValue(string paramCode, out object value, ParamCategory category, object defaultValue, DataType type)
        {
            EasyParam c = EasyParam.FindObject<EasyParam>("ParamCode", paramCode);
            if (c == null)
            {
                c = new EasyParam();
                c.ParamCode = paramCode;
                c.ParamCategory = category;
                c.OptionValue = defaultValue;
                c.ValueType = type;
                c.Save();
      
            }
            switch (c.ValueType)
            {
                case DataType.Bool: value = Convert.ToBoolean(c.OptionValue); break;
                case DataType.DateTime: value = Convert.ToDateTime(c.OptionValue); break;
                case DataType.Decimal: value = Convert.ToDecimal(c.OptionValue); break;
                case DataType.Int32: value = Convert.ToInt32(c.OptionValue); break;
                default: value = c.OptionValue; break;
            }
        }
        public static void SetValue(string paramCode, object value)
        {
            EasyParam c = EasyParam.FindObject<EasyParam>("ParamCode", paramCode);
            if (c == null)
            {
                value = null;
                return;
            }
            c.OptionValue = value;
            c.Save();
        }
       
    }

   

}