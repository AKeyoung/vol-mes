using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using VOL.Core.Configuration;

namespace Help
{
    public class DbHelp<T> where T : class
    {
        // 数据库连接字符串，从配置中获取
        public static string connectionString = AppSetting.DbConnectionString2;

        // 开启事务并返回事务对象和连接对象
        public static (SqlTransaction, SqlConnection) BeginTransaction()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();
            return (transaction, con);
        }

        // 通用的执行 SQL 语句方法，处理事务和异常
        private static void ExecuteWithTransaction(Action<SqlConnection, SqlTransaction> action, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            if (connection == null)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (transaction == null)
                    {
                        using (transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                action(connection, transaction);
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw ex;
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            action(connection, transaction);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            else
            {
                if (transaction == null)
                {
                    using (transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            action(connection, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
                else
                {
                    try
                    {
                        action(connection, transaction);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        // 查询列表（返回类型为 List）
        public static List<T> Query(string sql, object param = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            List<T> result = null;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.Query<T>(sql, param, trans).ToList();
            }, transaction, connection);
            return result;
        }

        // 带参数查询列表（支持匿名对象传参）
        public static List<T> QueryWithParams(string sql, object param, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            List<T> result = null;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.Query<T>(sql, param, trans).ToList();
            }, transaction, connection);
            return result;
        }

        // 查询单条数据，如果没有则返回默认值（带参数）
        public static T QuerySingleOrDefaultWithParams(string sql, object param, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            T result = default;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.QueryFirstOrDefault<T>(sql, param, trans);
            }, transaction, connection);
            return result;
        }

        // 查询第一个数据
        public static T QueryFirst(string sql, object param = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            T result = default;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.QueryFirst<T>(sql, param, trans);
            }, transaction, connection);
            return result;
        }

        // 查询第一个数据，若没有则返回默认值
        public static T QueryFirstOrDefault(string sql, object param = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            T result = null;//default;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.QueryFirstOrDefault<T>(sql, param, trans);
            }, transaction, connection);
            return result;
        }

        // 查询单条数据
        public static T QuerySingle(string sql, object param = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            T result = default;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.QuerySingle<T>(sql, param, trans);
            }, transaction, connection);
            return result;
        }

        // 插入、更新、删除操作
        public static int Execute(string sql, object param = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            int result = 0;
            ExecuteWithTransaction((conn, trans) =>
            {
                result = conn.Execute(sql, param, trans);
            }, transaction, connection);
            return result;
        }

        // 执行非查询语句（插入、更新、删除），使用参数字典
        public static int ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            int result = 0;
            ExecuteWithTransaction((conn, trans) =>
            {
                using (SqlCommand command = new SqlCommand(sql, conn, trans))
                {
                    if (parameters != null)
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }
                    result = command.ExecuteNonQuery();
                }
            }, transaction, connection);
            return result;
        }

        // 新增的方法，用于支持以匿名对象形式传递参数的数据库增删改操作
        public static int ExecuteNonQueryWithObject(string sql, object anonymousObject, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            // 通过反射获取匿名对象的属性及其对应的值，并添加到参数字典中
            PropertyInfo[] properties = anonymousObject.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                parameters.Add(property.Name, property.GetValue(anonymousObject));
            }
            return ExecuteNonQuery(sql, parameters, transaction, connection);
        }

        // 新增的方法，用于执行包含 OUTPUT INSERTED.Id 的插入语句并返回自增 ID
        public static int ExecuteNonQueryWithObjectAndReturnIdentity(string sql, object anonymousObject, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            // 通过反射获取匿名对象的属性及其对应的值，并添加到参数字典中
            PropertyInfo[] properties = anonymousObject.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                parameters.Add(property.Name, property.GetValue(anonymousObject));
            }
            int result = 0;
            ExecuteWithTransaction((conn, trans) =>
            {
                if (conn is SqlConnection sqlConnection)
                {
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection, trans))
                    {
                        if (parameters != null)
                        {
                            foreach (var pair in parameters)
                            {
                                command.Parameters.AddWithValue(pair.Key, pair.Value);
                            }
                        }
                        // 执行查询并获取结果
                        object id = command.ExecuteScalar();
                        if (id != null)
                        {
                            result = Convert.ToInt32(id);
                        }
                    }
                }
            }, transaction, connection);
            return result;
        }

        // 新增的批量处理方法，用于处理多条 SQL 语句及其对应参数的情况
        public static int ExecuteBatchNonQuery(List<SqlWithParameters> sqlWithParametersList)
        {
            int totalAffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var sqlWithParam in sqlWithParametersList)
                        {
                            string sql = sqlWithParam.Sql;
                            object parametersObject = sqlWithParam.Parameters;

                            Dictionary<string, object> parameters = null;
                            if (parametersObject is Dictionary<string, object> dictionaryParameters)
                            {
                                parameters = dictionaryParameters;
                            }
                            else
                            {
                                parameters = new Dictionary<string, object>();
                                PropertyInfo[] properties = parametersObject.GetType().GetProperties();
                                foreach (PropertyInfo property in properties)
                                {
                                    parameters.Add(property.Name, property.GetValue(parametersObject));
                                }
                            }

                            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                            {
                                // 遍历参数字典，为每个参数添加到SqlCommand的参数集合中，使用合适的参数类型添加方式，避免特殊字符问题
                                foreach (var pair in parameters)
                                {
                                    // 根据参数值的类型，选择合适的添加参数方法，这里简单示例几种常见类型，可根据实际情况扩展更多类型判断
                                    if (pair.Value is string strValue)
                                    {
                                        command.Parameters.Add(new SqlParameter($"@{pair.Key}", SqlDbType.VarChar) { Value = strValue });
                                    }
                                    else if (pair.Value is int intValue)
                                    {
                                        command.Parameters.Add(new SqlParameter($"@{pair.Key}", SqlDbType.Int) { Value = intValue });
                                    }
                                    else if (pair.Value is decimal decimalValue)
                                    {
                                        command.Parameters.Add(new SqlParameter($"@{pair.Key}", SqlDbType.Decimal) { Value = decimalValue });
                                    }
                                    // 可以继续添加更多类型的判断和处理，比如DateTime等类型
                                    else
                                    {
                                        // 如果遇到其他未处理的类型，这里简单地以Object类型添加，可能需要根据实际情况进一步优化处理方式
                                        command.Parameters.Add(new SqlParameter($"@{pair.Key}", SqlDbType.Variant) { Value = pair.Value });
                                    }
                                }

                                totalAffectedRows += command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }

            return totalAffectedRows;
        }

        // 执行查询返回单个值
        public static object ExecuteScalar(string sql, Dictionary<string, object> parameters = null, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            object result = null;
            ExecuteWithTransaction((conn, trans) =>
            {
                using (SqlCommand command = new SqlCommand(sql, conn, trans))
                {
                    if (parameters != null)
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }
                    result = command.ExecuteScalar();
                }
            }, transaction, connection);
            return result;
        }

        // 执行查询返回泛型实体对象
        public static T GetEntity<T>(string sql, Dictionary<string, object> parameters = null, SqlTransaction transaction = null, SqlConnection connection = null) where T : new()
        {
            T result = default;
            ExecuteWithTransaction((conn, trans) =>
            {
                using (SqlCommand command = new SqlCommand(sql, conn, trans))
                {
                    if (parameters != null)
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new T();
                            var properties = typeof(T).GetProperties();
                            foreach (var property in properties)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    property.SetValue(result, reader[property.Name]);
                                }
                            }
                        }
                    }
                }
            }, transaction, connection);
            return result;
        }

        // 执行查询返回泛型实体对象集合
        public static List<T> GetEntities<T>(string sql, Dictionary<string, object> parameters = null, SqlTransaction transaction = null, SqlConnection connection = null) where T : new()
        {
            List<T> result = new List<T>();
            ExecuteWithTransaction((conn, trans) =>
            {
                using (SqlCommand command = new SqlCommand(sql, conn, trans))
                {
                    if (parameters != null)
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = new T();
                            var properties = typeof(T).GetProperties();
                            foreach (var property in properties)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    property.SetValue(entity, reader[property.Name]);
                                }
                            }
                            result.Add(entity);
                        }
                    }
                }
            }, transaction, connection);
            return result;
        }

        // 批量执行 SQL 语句
        public static int ExecuteNonQueryBatch(List<string> sqlStatements, SqlTransaction transaction = null, SqlConnection connection = null)
        {
            int result = 0;
            ExecuteWithTransaction((conn, trans) =>
            {
                using (SqlCommand command = new SqlCommand("", conn, trans))
                {
                    foreach (string sql in sqlStatements)
                    {
                        command.CommandText += sql + "; ";
                    }
                    result = command.ExecuteNonQuery();
                }
            }, transaction, connection);
            return result;
        }
    }
}