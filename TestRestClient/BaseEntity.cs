using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 基础对象类库
/// </summary>
namespace TestRestClient
{
    public abstract class  BaseEntity
    {
        //抽象方法，必须提供的服务路径

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public String id { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public int version{ get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public String extInfo { get; set; }

    }
}
