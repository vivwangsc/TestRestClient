using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestRestClient.ruoyi
{

    public partial class sys_dict_data
    {
        public sys_dict_data(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
