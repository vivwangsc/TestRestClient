using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestRestClient.ruoyi
{

    public partial class QRTZ_SCHEDULER_STATE
    {
        public QRTZ_SCHEDULER_STATE(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
