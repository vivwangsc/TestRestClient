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

    public partial class sys_notice : XPLiteObject
    {
        int fnotice_id;
        [Key(true)]
        public int notice_id
        {
            get { return fnotice_id; }
            set { SetPropertyValue<int>(nameof(notice_id), ref fnotice_id, value); }
        }
        string fnotice_title;
        [Size(50)]
        public string notice_title
        {
            get { return fnotice_title; }
            set { SetPropertyValue<string>(nameof(notice_title), ref fnotice_title, value); }
        }
        char fnotice_type;
        public char notice_type
        {
            get { return fnotice_type; }
            set { SetPropertyValue<char>(nameof(notice_type), ref fnotice_type, value); }
        }
        string fnotice_content;
        [Size(2000)]
        public string notice_content
        {
            get { return fnotice_content; }
            set { SetPropertyValue<string>(nameof(notice_content), ref fnotice_content, value); }
        }
        char fstatus;
        [ColumnDefaultValue('0')]
        public char status
        {
            get { return fstatus; }
            set { SetPropertyValue<char>(nameof(status), ref fstatus, value); }
        }
        string fcreate_by;
        [Size(64)]
        [ColumnDefaultValue("")]
        public string create_by
        {
            get { return fcreate_by; }
            set { SetPropertyValue<string>(nameof(create_by), ref fcreate_by, value); }
        }
        DateTime fcreate_time;
        public DateTime create_time
        {
            get { return fcreate_time; }
            set { SetPropertyValue<DateTime>(nameof(create_time), ref fcreate_time, value); }
        }
        string fupdate_by;
        [Size(64)]
        [ColumnDefaultValue("")]
        public string update_by
        {
            get { return fupdate_by; }
            set { SetPropertyValue<string>(nameof(update_by), ref fupdate_by, value); }
        }
        DateTime fupdate_time;
        public DateTime update_time
        {
            get { return fupdate_time; }
            set { SetPropertyValue<DateTime>(nameof(update_time), ref fupdate_time, value); }
        }
        string fremark;
        [Size(255)]
        public string remark
        {
            get { return fremark; }
            set { SetPropertyValue<string>(nameof(remark), ref fremark, value); }
        }
    }

}