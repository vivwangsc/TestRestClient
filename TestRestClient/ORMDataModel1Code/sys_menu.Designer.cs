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

    public partial class sys_menu : XPLiteObject
    {
        long fmenu_id;
        [Key(true)]
        public long menu_id
        {
            get { return fmenu_id; }
            set { SetPropertyValue<long>(nameof(menu_id), ref fmenu_id, value); }
        }
        string fmenu_name;
        [Size(50)]
        public string menu_name
        {
            get { return fmenu_name; }
            set { SetPropertyValue<string>(nameof(menu_name), ref fmenu_name, value); }
        }
        long fparent_id;
        [ColumnDefaultValue(0)]
        public long parent_id
        {
            get { return fparent_id; }
            set { SetPropertyValue<long>(nameof(parent_id), ref fparent_id, value); }
        }
        int forder_num;
        [ColumnDefaultValue(0)]
        public int order_num
        {
            get { return forder_num; }
            set { SetPropertyValue<int>(nameof(order_num), ref forder_num, value); }
        }
        string furl;
        [Size(200)]
        [ColumnDefaultValue("#")]
        public string url
        {
            get { return furl; }
            set { SetPropertyValue<string>(nameof(url), ref furl, value); }
        }
        string ftarget;
        [Size(20)]
        [ColumnDefaultValue("")]
        public string target
        {
            get { return ftarget; }
            set { SetPropertyValue<string>(nameof(target), ref ftarget, value); }
        }
        char fmenu_type;
        [ColumnDefaultValue("")]
        public char menu_type
        {
            get { return fmenu_type; }
            set { SetPropertyValue<char>(nameof(menu_type), ref fmenu_type, value); }
        }
        char fvisible;
        [ColumnDefaultValue('0')]
        public char visible
        {
            get { return fvisible; }
            set { SetPropertyValue<char>(nameof(visible), ref fvisible, value); }
        }
        string fperms;
        public string perms
        {
            get { return fperms; }
            set { SetPropertyValue<string>(nameof(perms), ref fperms, value); }
        }
        string ficon;
        [ColumnDefaultValue("#")]
        public string icon
        {
            get { return ficon; }
            set { SetPropertyValue<string>(nameof(icon), ref ficon, value); }
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
        [Size(500)]
        [ColumnDefaultValue("")]
        public string remark
        {
            get { return fremark; }
            set { SetPropertyValue<string>(nameof(remark), ref fremark, value); }
        }
    }

}