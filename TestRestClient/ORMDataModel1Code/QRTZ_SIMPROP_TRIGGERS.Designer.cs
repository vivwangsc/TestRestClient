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

    public partial class QRTZ_SIMPROP_TRIGGERS : XPLiteObject
    {
        string fstr_prop_1;
        [Size(512)]
        public string str_prop_1
        {
            get { return fstr_prop_1; }
            set { SetPropertyValue<string>(nameof(str_prop_1), ref fstr_prop_1, value); }
        }
        string fstr_prop_2;
        [Size(512)]
        public string str_prop_2
        {
            get { return fstr_prop_2; }
            set { SetPropertyValue<string>(nameof(str_prop_2), ref fstr_prop_2, value); }
        }
        string fstr_prop_3;
        [Size(512)]
        public string str_prop_3
        {
            get { return fstr_prop_3; }
            set { SetPropertyValue<string>(nameof(str_prop_3), ref fstr_prop_3, value); }
        }
        int fint_prop_1;
        public int int_prop_1
        {
            get { return fint_prop_1; }
            set { SetPropertyValue<int>(nameof(int_prop_1), ref fint_prop_1, value); }
        }
        int fint_prop_2;
        public int int_prop_2
        {
            get { return fint_prop_2; }
            set { SetPropertyValue<int>(nameof(int_prop_2), ref fint_prop_2, value); }
        }
        long flong_prop_1;
        public long long_prop_1
        {
            get { return flong_prop_1; }
            set { SetPropertyValue<long>(nameof(long_prop_1), ref flong_prop_1, value); }
        }
        long flong_prop_2;
        public long long_prop_2
        {
            get { return flong_prop_2; }
            set { SetPropertyValue<long>(nameof(long_prop_2), ref flong_prop_2, value); }
        }
        decimal fdec_prop_1;
        public decimal dec_prop_1
        {
            get { return fdec_prop_1; }
            set { SetPropertyValue<decimal>(nameof(dec_prop_1), ref fdec_prop_1, value); }
        }
        decimal fdec_prop_2;
        public decimal dec_prop_2
        {
            get { return fdec_prop_2; }
            set { SetPropertyValue<decimal>(nameof(dec_prop_2), ref fdec_prop_2, value); }
        }
        string fbool_prop_1;
        [Size(1)]
        public string bool_prop_1
        {
            get { return fbool_prop_1; }
            set { SetPropertyValue<string>(nameof(bool_prop_1), ref fbool_prop_1, value); }
        }
        string fbool_prop_2;
        [Size(1)]
        public string bool_prop_2
        {
            get { return fbool_prop_2; }
            set { SetPropertyValue<string>(nameof(bool_prop_2), ref fbool_prop_2, value); }
        }
        public struct CompoundKey1Struct
        {
            [Size(120)]
            [Persistent("sched_name")]
            public string sched_name { get; set; }
            [Size(200)]
            [Persistent("trigger_name")]
            public string trigger_name { get; set; }
            [Size(200)]
            [Persistent("trigger_group")]
            public string trigger_group { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}