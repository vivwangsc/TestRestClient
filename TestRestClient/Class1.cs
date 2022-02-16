using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRestClient
{
    partial class Class1 : global::System.Data.DataSet
    {
        public DataTable sys_config { get; set;}

    }

    /// <summary>
    /// sys_config的实体类
    /// </summary>
    public partial class sys_config
    {
        public Int32 config_id { get; set; }
        public string config_name { get; set; }
        public string config_value { get; set; }
        public string config_key { get; set; }
        char config_type { get; set; }
        public string create_by { get; set; }
        public DateTime create_time { get; set; }
        public string update_by { get; set; }
        public DateTime update_time { get; set; }
        public string remark { get; set; }
    }


}
