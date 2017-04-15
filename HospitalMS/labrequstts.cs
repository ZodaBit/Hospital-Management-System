using System;
using DevExpress.Xpo;

namespace HospitalMS
{

    public class labrequstts : XPObject
    {
        public labrequstts()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public labrequstts(Session session)
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
    }

}