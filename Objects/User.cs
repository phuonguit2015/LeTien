using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class User : XPObject
    {
        public User()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public User(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public string username
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }
        public bool view_user
        {
            get;
            set;
        }
        public bool edit_user
        {
            get;
            set;
        }
        public bool view_employee
        {
            get;
            set;
        }
        public bool edit_employee
        {
            get;
            set;
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        
    }

}