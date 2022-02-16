using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestRestClient.ruoyi
{

    public partial class sys_user_post
    {
        public sys_user_post(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
