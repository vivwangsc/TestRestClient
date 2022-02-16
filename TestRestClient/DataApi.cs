using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestSharp;
//using Newtonsoft.Json;
using System.Reflection;
using System.Collections;

namespace TestRestClient

{
    /***
     *本类处理与远程端的所有数据交互的过程
     * 1、获取数据 
     */
    public class DataApi<T> where T : new()
    {
        //静态的基础地址
        public String EntityName { get; set; }

        /// <summary>
        /// 获取类对应的远程服务地址
        /// </summary>
        /// <returns></returns>
        private String getWeburl()
        {
            MemberInfo typeinfo = typeof(T);
            //调用GetCustomAttributes方法获取与BookAttribute类有关的属性列表，该方法返回一个对象数组
            WeburlAttribute attr = typeinfo.GetCustomAttribute(typeof(WeburlAttribute)) as WeburlAttribute;
            return attr.WebUrl;
        }


        public DataTable getData() 
        {
            //WebapiClient
            List<T>  list = getList();
            if (list == null) return null;

            //继续转换为datatable试试，毕竟datatable具有强大的数据处理功能。
            try
            {
                DataTable dt = FillDataTable(list);
                dt.AcceptChanges();
                return dt;
            }
            catch(Exception ex)
            {
                //设置全局错误信息
                //GlobalVariable.errorCode = -1;
                //GlobalVariable.errorMessage = ex.ToString();
                return null;
            }
        }

        ///// <summary>
        ///// 根据主键返回对象，如果为null则无
        ///// </summary>
        ///// <param name="id">主键</param>
        ///// <returns></returns>
        //public T getOne(String id)
        //{
        //    List<String> ss;
        //    return T;
        //}

        public List<T> getList()
        {
            //RestRequest request = new RestRequest(getWeburl() + "findAll");
            //JsonResult result = bwUtility.executeAPI(EntityName, request);
            //if (!result.success)
            //{
            //    //设置全局错误信息
            //    GlobalVariable.errorCode = -1;
            //    GlobalVariable.errorMessage = result.msg;
            //    return null;
            //}
            //List<T> list = JsonConvert.DeserializeObject<List<T>>(result.data.ToString());
            //return list;
            return null;
        }


        public int update(DataTable dt)
        {
            DataTable changes = dt.GetChanges();
            DataView dvAdd = new DataView(dt);
            dvAdd.RowStateFilter = DataViewRowState.Added;
            DataTable dtAdd = dvAdd.ToTable();
            DataView dvMdy = new DataView(dt);
            dvMdy.RowStateFilter = DataViewRowState.ModifiedCurrent;
            DataTable dtMdy = dvMdy.ToTable();
            DataView dvDel = new DataView(dt);
            dvDel.RowStateFilter = DataViewRowState.Deleted;
            DataTable dtDel = dvDel.ToTable();
            Hashtable hshTable = new Hashtable();
            //String sAdd = JsonConvert.SerializeObject(dtAdd);
            //String sMdy = JsonConvert.SerializeObject(dtMdy);
            //String sDel = JsonConvert.SerializeObject(dtDel);

            ////提交到服务器去修改，注意，修改后要及时更新本地数据。
            ////首先测试数据的修改。
            //RestRequest request = new RestRequest(getWeburl() + "doUpdate", Method.POST);
            ////添加参数数据
            //request.AddParameter("add", sAdd);
            //request.AddParameter("mdy", sMdy);
            //request.AddParameter("del", sDel);

            //JsonResult result = bwUtility.executeAPI(EntityName, request);
            //if (!result.success)
            //{
            //    bwUtility.ShowError(result.msg);
            //    return -1;
            //}

            //List<T> list1 = JsonConvert.DeserializeObject<List<T>>(result.data.ToString());

            ////返回修改版本号
            ////如果有版本号字段则开始如下处理
            //if (dt.Columns.Contains("version"))
            //{
            //    foreach (T entity in list1)
            //    {
            //        //从datatable里面查找，然后替换
            //        //通过反射的方式来操作
            //        DataRow row = dt.Rows.Find(bwUtility.GetObjectPropertyValue(entity,"id"));
            //        row["version"] = bwUtility.GetObjectPropertyValue(entity, "version");
            //    }
            //}
            //dt.AcceptChanges();
            return 1;
        }


        #region DataTable转换成实体类

        /// <summary>
        /// 填充对象列表：用DataSet的第一个表填充实体类
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <returns></returns>
        public List<T> FillModel(DataSet ds)
        {
            if (ds == null || ds.Tables[0] == null || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return FillModel(ds.Tables[0]);
            }
        }

        /// <summary>  
        /// 填充对象列表：用DataSet的第index个表填充实体类
        /// </summary>  
        public List<T> FillModel(DataSet ds, int index)
        {
            if (ds == null || ds.Tables.Count <= index || ds.Tables[index].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return FillModel(ds.Tables[index]);
            }
        }

        /// <summary>  
        /// 填充对象列表：用DataTable填充实体类
        /// </summary>  
        public List<T> FillModel(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            List<T> modelList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                //T model = (T)Activator.CreateInstance(typeof(T));  
                T model = new T();
                for (int i = 0; i < dr.Table.Columns.Count; i++)
                {
                    PropertyInfo propertyInfo = model.GetType().GetProperty(dr.Table.Columns[i].ColumnName);
                    if (propertyInfo != null && dr[i] != DBNull.Value)
                        propertyInfo.SetValue(model, dr[i], null);
                }

                modelList.Add(model);
            }
            return modelList;
        }

        /// <summary>  
        /// 填充对象：用DataRow填充实体类
        /// </summary>  
        public T FillModel(DataRow dr)
        {
            if (dr == null)
            {
                return default(T);
            }

            //T model = (T)Activator.CreateInstance(typeof(T));  
            T model = new T();

            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                PropertyInfo propertyInfo = model.GetType().GetProperty(dr.Table.Columns[i].ColumnName);
                if (propertyInfo != null && dr[i] != DBNull.Value)
                    propertyInfo.SetValue(model, dr[i], null);
            }
            return model;
        }

        #endregion

        #region 实体类转换成DataTable

        /// <summary>
        /// 实体类转换成DataSet
        /// </summary>
        /// <param name="modelList">实体类列表</param>
        /// <returns></returns>
        public DataSet FillDataSet(List<T> modelList)
        {
            if (modelList == null || modelList.Count == 0)
            {
                return null;
            }
            else
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(FillDataTable(modelList));
                return ds;
            }
        }

        /// <summary>
        /// 实体类转换成DataTable
        /// </summary>
        /// <param name="modelList">实体类列表</param>
        /// <returns></returns>
        public DataTable FillDataTable(List<T> modelList)
        {
            if (modelList == null || modelList.Count == 0)
            {
                return null;
            }
            DataTable dt = CreateData(modelList[0]);

            foreach (T model in modelList)
            {
                DataRow dataRow = dt.NewRow();
                foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
                {
                    dataRow[propertyInfo.Name] = propertyInfo.GetValue(model, null);
                }
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        /// <summary>
        /// 根据实体类得到表结构
        /// </summary>
        /// <param name="model">实体类</param>
        /// <returns></returns>
        private DataTable CreateData(T model)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(propertyInfo.Name, propertyInfo.PropertyType));
            }
            //尝试自动设定主键，这样比较方便。
            try
            {
                DataColumn[] cols = new DataColumn[] { dataTable.Columns["id"] };
                dataTable.PrimaryKey = cols;
            }
            catch (Exception ex)
            {
                ;
            }
            return dataTable;
        }

        #endregion
    }
}
