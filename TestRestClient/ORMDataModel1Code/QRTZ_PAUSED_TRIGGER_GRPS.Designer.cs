﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace TestRestClient.ruoyi
{

    public partial class QRTZ_PAUSED_TRIGGER_GRPS : XPLiteObject
    {
        public struct CompoundKey1Struct
        {
            [Size(120)]
            [Persistent("sched_name")]
            public string sched_name { get; set; }
            [Size(200)]
            [Persistent("trigger_group")]
            public string trigger_group { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
