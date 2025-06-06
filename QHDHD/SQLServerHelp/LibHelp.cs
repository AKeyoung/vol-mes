using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public class LibHelp
    {
        private string msgModel = "{{\"code\":{0},\"message\":\"{1}\",\"result\":\"{2}\"}}";
        /// <summary>
        /// 返回自定义消息内容
        /// </summary>
        /// <param name="stateText">状态</param>
        /// <param name="stateCode">状态代码</param>
        /// <param name="stateValue">消息内容</param>
        /// <returns></returns>
        public HttpResponseMessage returnMsg(string stateText, int stateCode, string stateValue)
        {
            string returnJson = string.Format(msgModel, stateCode, stateText, stateValue);
            return new HttpResponseMessage { Content = new StringContent(returnJson, System.Text.Encoding.UTF8, "application/json") };
        }
        /// <summary>
        /// 返回系统定义消息内容
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public HttpResponseMessage returnMsgOnlyValue(string jsonStr)
        {
            return new HttpResponseMessage { Content = new StringContent(jsonStr, System.Text.Encoding.UTF8, "application/json") };
        }
        /// <summary>
        /// 将JSON数据转换成MODEL
        /// </summary>
        /// <param name="insertStr"></param>
        /// <param name="createId"></param>
        /// <param name="ob">MODEL对象</param>
        /// <returns></returns>
        public object jsonToModel(string insertStr, object ob)
        {
            JObject jo = new JObject();
            jo = JObject.Parse(insertStr);
            PropertyInfo[] modelInfo = ob.GetType().GetProperties();
            for (int i = 0; i < modelInfo.Length; i++)
            {
                string dataType = modelInfo[i].PropertyType.FullName;
                if (dataType == "System.Guid")
                {
                    try
                    {
                        modelInfo[i].SetValue(ob, (Guid)jo[modelInfo[i].Name], null);
                    }
                    catch { }
                }
                if (dataType == "System.String")
                {
                    try
                    {
                        modelInfo[i].SetValue(ob, (string)jo[modelInfo[i].Name], null);
                    }
                    catch { }
                }
                if (dataType == "System.Int32")
                {
                    try
                    {
                        modelInfo[i].SetValue(ob, (int)jo[modelInfo[i].Name], null);
                    }
                    catch { }
                }
            }
            return ob;
        }

        /// <summary>
        /// 创建INSERT语句
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="t"></param>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public static string CreateInserSql<T>(T t, string tablename)
        {
            string sql = @"insert into {2} ({0}) values ({1}) select @@identity as id";
            string column = "", values = "";
            PropertyInfo[] pf = t.GetType().GetProperties();
            foreach (var item in pf)
            {
                if (item.Name == "id") continue;
                column += item.Name + ",";
                if (item.PropertyType.FullName == "System.String")
                {
                    var ss = item.GetValue(t);
                    if (item.GetValue(t) != null)
                    {
                        try
                        {
                            values += "'" + item.GetValue(t).ToString() + "',";
                        }
                        catch
                        {
                            values += "'',";
                        }
                    }
                    else
                    {
                        values += "'',";
                    }
                }
                else if (item.PropertyType.FullName == "System.Datetime")
                {
                    var ss = item.GetValue(t);
                    if (item.GetValue(t) != null)
                    {
                        try
                        {
                            values += "'" + item.GetValue(t).ToString() + "',";
                        }
                        catch
                        {
                            values += "'',";
                        }
                    }
                    else
                    {
                        values += "'',";
                    }
                }
                else
                {
                    values += item.GetValue(t).ToString() + ",";
                }
            }
            column = column.TrimEnd(',');
            values = values.TrimEnd(',');
            sql = string.Format(sql, column, values, tablename);
            return sql;
        }

        /// <summary>
        /// 创建UPDATE语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string GenerateUpdateStatement<T>(T entity, string tableName, string strKey) where T : class
        {
            var properties = entity.GetType().GetProperties();
            var setClauses = new List<string>();
            var whereClause = "";

            foreach (var property in properties)
            {
                if (property.Name.ToLower() == strKey.ToLower())
                {
                    whereClause = $"{property.Name} = {GetValueForSQL(property.GetValue(entity))}";
                }
                else
                {
                    setClauses.Add($"{property.Name} = {GetValueForSQL(property.GetValue(entity))}");
                }
            }

            return $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {whereClause}";
        }

        /// <summary>
        /// 创建DELETE 语句
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static string GenerareDelSql(string tableName, string strKey,string strValue)
        {
    

            string str = @"Delete from {0} where {1}='{2}'";
            str = string.Format(str, tableName, strKey, strValue);
            return str;
        }

        /// <summary>
        /// 创建删除语句
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static string GenerateDeleteStatement(string tableName, Dictionary<string, object> conditions)
        {
            StringBuilder deleteStatement = new StringBuilder($"DELETE FROM {tableName} WHERE ");

            int conditionCount = 0;
            foreach (var condition in conditions)
            {
                if (conditionCount > 0)
                {
                    deleteStatement.Append(" AND ");
                }

                // 根据值的类型来正确格式化条件值在SQL语句中的表示
                if (condition.Value is string)
                {
                    deleteStatement.Append($"{condition.Key} = '{condition.Value}'");
                }
                else if (condition.Value is DateTime)
                {
                    deleteStatement.Append($"{condition.Key} = '{((DateTime)condition.Value).ToString("yyyy-MM-dd HH:mm:ss")}'");
                }
                else
                {
                    deleteStatement.Append($"{condition.Key} = {condition.Value}");
                }

                conditionCount++;
            }

            return deleteStatement.ToString();
        }

        /// <summary>
        /// 转换类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetValueForSQL(object value)
        {
            if (value == null)
            {
                return "NULL";
            }
            else if (value is string strValue)
            {
                strValue = strValue.Replace("'", "''");
                return $"'{strValue}'";
            }
            else if (value is DateTime dateTimeValue)
            {
                return $"'{dateTimeValue:yyyy-MM-dd HH:mm:ss}'";
            }
            else if (value is bool boolValue)
            {
                return boolValue ? "1" : "0";
            }
            else if (value is Enum enumValue)
            {
                return Convert.ToInt32(enumValue).ToString();
            }
            else
            {
                return value.ToString();
            }
        }


        /// <summary>
        /// 根据条件查询最大序号
        /// </summary>
        /// <param name="strTableName"></param>
        /// <param name="strMaxField"></param>
        /// <returns></returns>
        public static T GetMaxValueFromTable<T>(string tableName, string fieldName) where T : class
        {

            string query = $"SELECT * FROM {tableName} WHERE {fieldName} = (SELECT MAX({fieldName}) FROM {tableName})";

            return DbHelp<T>.QueryFirst(query);
        }



        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<string> UploadAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return "-1";
            }
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "/upload");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filePath;
            //return Ok(new { fileName = file.FileName, filePath = filePath });
        }

        /// <summary>
        /// 计算数据偏移值
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="number">数量</param>
        /// <returns></returns>
        public static int PageNumber(int page,int number)
        {
            return (page - 1) * 10;
        }
    }
}
