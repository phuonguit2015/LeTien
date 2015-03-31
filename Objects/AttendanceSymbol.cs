using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace LeTien.Objects
{

    public class AttendanceSymbol : XPObject
    {
        public AttendanceSymbol()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public AttendanceSymbol(Session session)
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

        public string SymbolID;
        public string SymbolName;
        public int SymbolColor;
        public string SymbolValue;
        public string SymbolDescription;
        public static DevExpress.Xpo.DB.SelectedData GetAllAttendanceSymbols(Session session)
        {
            return session.ExecuteQuery("SELECT * FROM `AttendanceSymbol`");
        }
    }

}