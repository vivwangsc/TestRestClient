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

    public partial class gen_table : XPLiteObject
    {
        long ftable_id;
        [Key(true)]
        public long table_id
        {
            get { return ftable_id; }
            set { SetPropertyValue<long>(nameof(table_id), ref ftable_id, value); }
        }
        string ftable_name;
        [Size(200)]
        [ColumnDefaultValue("")]
        public string table_name
        {
            get { return ftable_name; }
            set { SetPropertyValue<string>(nameof(table_name), ref ftable_name, value); }
        }
        string ftable_comment;
        [Size(500)]
        [ColumnDefaultValue("")]
        public string table_comment
        {
            get { return ftable_comment; }
            set { SetPropertyValue<string>(nameof(table_comment), ref ftable_comment, value); }
        }
        string fsub_table_name;
        [Size(64)]
        public string sub_table_name
        {
            get { return fsub_table_name; }
            set { SetPropertyValue<string>(nameof(sub_table_name), ref fsub_table_name, value); }
        }
        string fsub_table_fk_name;
        [Size(64)]
        public string sub_table_fk_name
        {
            get { return fsub_table_fk_name; }
            set { SetPropertyValue<string>(nameof(sub_table_fk_name), ref fsub_table_fk_name, value); }
        }
        string fclass_name;
        [ColumnDefaultValue("")]
        public string class_name
        {
            get { return fclass_name; }
            set { SetPropertyValue<string>(nameof(class_name), ref fclass_name, value); }
        }
        string ftpl_category;
        [Size(200)]
        [ColumnDefaultValue("crud")]
        public string tpl_category
        {
            get { return ftpl_category; }
            set { SetPropertyValue<string>(nameof(tpl_category), ref ftpl_category, value); }
        }
        string fpackage_name;
        public string package_name
        {
            get { return fpackage_name; }
            set { SetPropertyValue<string>(nameof(package_name), ref fpackage_name, value); }
        }
        string fmodule_name;
        [Size(30)]
        public string module_name
        {
            get { return fmodule_name; }
            set { SetPropertyValue<string>(nameof(module_name), ref fmodule_name, value); }
        }
        string fbusiness_name;
        [Size(30)]
        public string business_name
        {
            get { return fbusiness_name; }
            set { SetPropertyValue<string>(nameof(business_name), ref fbusiness_name, value); }
        }
        string ffunction_name;
        [Size(50)]
        public string function_name
        {
            get { return ffunction_name; }
            set { SetPropertyValue<string>(nameof(function_name), ref ffunction_name, value); }
        }
        string ffunction_author;
        [Size(50)]
        public string function_author
        {
            get { return ffunction_author; }
            set { SetPropertyValue<string>(nameof(function_author), ref ffunction_author, value); }
        }
        char fgen_type;
        [ColumnDefaultValue('0')]
        public char gen_type
        {
            get { return fgen_type; }
            set { SetPropertyValue<char>(nameof(gen_type), ref fgen_type, value); }
        }
        string fgen_path;
        [Size(200)]
        [ColumnDefaultValue("/")]
        public string gen_path
        {
            get { return fgen_path; }
            set { SetPropertyValue<string>(nameof(gen_path), ref fgen_path, value); }
        }
        string foptions;
        [Size(1000)]
        public string options
        {
            get { return foptions; }
            set { SetPropertyValue<string>(nameof(options), ref foptions, value); }
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
        public string remark
        {
            get { return fremark; }
            set { SetPropertyValue<string>(nameof(remark), ref fremark, value); }
        }
    }

}