using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRestClient.ruoyi;

namespace TestRestClient
{
 
    public partial class Form1 : Form

    {
        String Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2NDU1MjYyMjEsInVzZXJuYW1lIjoiYWRtaW4ifQ.as76JxpyE_ouctgws9UVAgQLvjzdPhLm_r0uIVoNKxg";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ruoyiDataSet.sys_config”中。您可以根据需要移动或删除它。
            //this.sys_configTableAdapter.Fill(this.ruoyiDataSet.sys_config);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:99/app/");
            var request = new RestRequest("system/config/list");
            request.AddHeader("token", Token);
            //var sout = await client.PostAsync(request);
            //richTextBox1.Text = sout.Content;
            
            var sout = await client.PostAsync<AjaxResult>(request);
            richTextBox1.Text = sout.data.ToString();
            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            List<sys_config> list = JsonConvert.DeserializeObject<List<sys_config>>(sout.data.ToString(),jsSetting);
            foreach (sys_config model in list)
            {
                DataRow dataRow = ruoyiDataSet.sys_config.NewRow();
                foreach (PropertyInfo propertyInfo in typeof(sys_config).GetProperties())
                {
                    dataRow[propertyInfo.Name] = propertyInfo.GetValue(model, null);
                }
                ruoyiDataSet.sys_config.Rows.Add(dataRow);
            }

            richTextBox1.Text = sout.data.ToString();


            //sys_config sconfig = new sys_config(null);
            //sconfig.config_key = 




        }
    }

    public class AjaxResult
    {
        public String msg { get; set; }
        public int code { get; set; }

        public Object data { get; set; }

    }

}
