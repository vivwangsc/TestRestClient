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
    public class TableCommentAttribute : Attribute
    {
        private string _comment;//私有字段

        /// <summary>
        　　 /// 表的名称
        　　/// </summary>
        public string comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        //构造函数，设置属性参数
        public TableCommentAttribute(string strUrl)
        {
            this._comment = strUrl;
        }
    }
}
