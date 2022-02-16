using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRestClient
{
    //仅限用于类，且可以多次使用属性
    [AttributeUsage(AttributeTargets.Class)]
    //继承自Attribute类
    public class SqlAttribute : Attribute
    {
        private string _sql;//私有字段

        /// <summary>
        　　 /// 书本名称属性
        　　/// </summary>
        public string sql
        {
            get { return _sql; }
            set { _sql = value; }
        }
        //构造函数，设置属性参数
        public void sqlAttribute(string strUrl)
        {
            this._sql = strUrl;
        }
    }
}
