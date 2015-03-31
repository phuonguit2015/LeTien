using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class Chant : XPObject
    {
        public Chant()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Chant(Session session)
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
        public string ChantName;
        public TimeSpan ChantStart;
    }

}