using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using VOL.Core.Configuration;

namespace YourNamespace
{
    public class OracleDataAccess
    {
        private string connectionString = AppSetting.GetSettingString("connectionString");
        /// <summary>
        /// 执行查询语句，返回 DataTable
        /// </summary>
        /// <param name="query">查询语句</param>
        /// <returns>查询结果的 DataTable</returns>
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"执行查询时出错: {ex.Message}");
            }
            return dataTable;
        }

        /// <summary>
        /// 执行非查询语句（如插入、更新、删除）
        /// </summary>
        /// <param name="query">非查询语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"执行非查询语句时出错: {ex.Message}");
            }
            return rowsAffected;
        }

        /// <summary>
        /// 执行查询语句，返回单个值
        /// </summary>
        /// <param name="query">查询语句</param>
        /// <returns>查询结果的单个值</returns>
        public object ExecuteScalar(string query)
        {
            object result = null;
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"执行标量查询时出错: {ex.Message}");
            }
            return result;
        }

        /// <summary>
        /// 执行带参数的查询语句，返回 DataTable
        /// </summary>
        /// <param name="query">查询语句</param>
        /// <param name="parameters">查询参数</param>
        /// <returns>查询结果的 DataTable</returns>
        public DataTable ExecuteQueryWithParameters(string query, Dictionary<string, object> parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.Add(parameter.Key, parameter.Value);
                        }
                        connection.Open();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"执行带参数的查询时出错: {ex.Message}");
            }
            return dataTable;
        }

        /// <summary>
        /// 执行带参数的非查询语句（如插入、更新、删除）
        /// </summary>
        /// <param name="query">非查询语句</param>
        /// <param name="parameters">查询参数</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQueryWithParameters(string query, Dictionary<string, object> parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.Add(parameter.Key, parameter.Value);
                        }
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"执行带参数的非查询语句时出错: {ex.Message}");
            }
            return rowsAffected;
        }
    }
}