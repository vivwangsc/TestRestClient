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

    public partial class QRTZ_CALENDARS : XPLiteObject
    {
        byte[] fcalendar;
        [Size(SizeAttribute.Unlimited)]
        [MemberDesignTimeVisibility(true)]
        public byte[] calendar
        {
            get { return fcalendar; }
            set { SetPropertyValue<byte[]>(nameof(calendar), ref fcalendar, value); }
        }
        public struct CompoundKey1Struct
        {
            [Size(120)]
            [Persistent("sched_name")]
            public string sched_name { get; set; }
            [Size(200)]
            [Persistent("calendar_name")]
            public string calendar_name { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
