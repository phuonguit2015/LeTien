using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class Religion : XPObject
    {
        public Religion()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Religion(Session session)
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


        #region "Variables"
        [DisplayName ("Mã Tôn Giáo")]
        [Indexed(Unique=true)]        
        public string ReligionID;


        [DisplayName ("Tên Tôn Giáo")]
        public string ReligionName;
        #endregion


    }

}