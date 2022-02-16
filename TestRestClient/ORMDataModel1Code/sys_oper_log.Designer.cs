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

    public partial class sys_oper_log : XPLiteObject
    {
        long foper_id;
        [Key(true)]
        public long oper_id
        {
            get { return foper_id; }
            set { SetPropertyValue<long>(nameof(oper_id), ref foper_id, value); }
        }
        string ftitle;
        [Size(50)]
        [ColumnDefaultValue("")]
        public string title
        {
            get { return ftitle; }
            set { SetPropertyValue<string>(nameof(title), ref ftitle, value); }
        }
        int fbusiness_type;
        [ColumnDefaultValue(0)]
        public int business_type
        {
            get { return fbusiness_type; }
            set { SetPropertyValue<int>(nameof(business_type), ref fbusiness_type, value); }
        }
        string fmethod;
        [ColumnDefaultValue("")]
        public string method
        {
            get { return fmethod; }
            set { SetPropertyValue<string>(nameof(method), ref fmethod, value); }
        }
        string frequest_method;
        [Size(10)]
        [ColumnDefaultValue("")]
        public string request_method
        {
            get { return frequest_method; }
            set { SetPropertyValue<string>(nameof(request_method), ref frequest_method, value); }
        }
        int foperator_type;
        [ColumnDefaultValue(0)]
        public int operator_type
        {
            get { return foperator_type; }
            set { SetPropertyValue<int>(nameof(operator_type), ref foperator_type, value); }
        }
        string foper_name;
        [Size(50)]
        [ColumnDefaultValue("")]
        public string oper_name
        {
            get { return foper_name; }
            set { SetPropertyValue<string>(nameof(oper_name), ref foper_name, value); }
        }
        string fdept_name;
        [Size(50)]
        [ColumnDefaultValue("")]
        public string dept_name
        {
            get { return fdept_name; }
            set { SetPropertyValue<string>(nameof(dept_name), ref fdept_name, value); }
        }
        string foper_url;
        [Size(255)]
        [ColumnDefaultValue("")]
        public string oper_url
        {
            get { return foper_url; }
            set { SetPropertyValue<string>(nameof(oper_url), ref foper_url, value); }
        }
        string foper_ip;
        [Size(50)]
        [ColumnDefaultValue("")]
        public string oper_ip
        {
            get { return foper_ip; }
            set { SetPropertyValue<string>(nameof(oper_ip), ref foper_ip, value); }
        }
        string foper_location;
        [Size(255)]
        [ColumnDefaultValue("")]
        public string oper_location
        {
            get { return foper_location; }
            set { SetPropertyValue<string>(nameof(oper_location), ref foper_location, value); }
        }
        string foper_param;
        [Size(2000)]
        [ColumnDefaultValue("")]
        public string oper_param
        {
            get { return foper_param; }
            set { SetPropertyValue<string>(nameof(oper_param), ref foper_param, value); }
        }
        string fjson_result;
        [Size(2000)]
        [ColumnDefaultValue("")]
        public string json_result
        {
            get { return fjson_result; }
            set { SetPropertyValue<string>(nameof(json_result), ref fjson_result, value); }
        }
        int fstatus;
        [ColumnDefaultValue(0)]
        public int status
        {
            get { return fstatus; }
            set { SetPropertyValue<int>(nameof(status), ref fstatus, value); }
        }
        string ferror_msg;
        [Size(2000)]
        [ColumnDefaultValue("")]
        public string error_msg
        {
            get { return ferror_msg; }
            set { SetPropertyValue<string>(nameof(error_msg), ref ferror_msg, value); }
        }
        DateTime foper_time;
        public DateTime oper_time
        {
            get { return foper_time; }
            set { SetPropertyValue<DateTime>(nameof(oper_time), ref foper_time, value); }
        }
    }

}