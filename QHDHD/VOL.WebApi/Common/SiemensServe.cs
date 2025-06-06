using Microsoft.Extensions.Logging;
using System.Text;
using System;
using VOL.Core.Configuration;
using IoTClient.Clients.PLC;
using IoTClient.Common.Enums;

namespace VOL.WebApi.Common
{
    public class SiemensServe
    {
        private SiemensClient client;

        private ILogger<SiemensServe> m_logger;

        /// <summary>
        /// 构造
        /// </summary>
        public SiemensServe(ILogger<SiemensServe> logger)
        {
            m_logger = logger;

            client?.Close();
            client = new SiemensClient(SiemensVersion.S7_1200, AppSetting.GetSettingString("PLCAddress"), 102, 0, 0);
            m_logger.LogTrace($"PLC：Ip {AppSetting.GetSettingString("PLCAddress")} Port 102");
            client.WarningLog = (msg, ex) =>
            {
                //MessageBox.Show(ex.Message);
                m_logger.LogWarning($"PLC 警告：{ex.Message}");
            };

            var result = client.Open();

            if (!result.IsSucceed)
            {
                m_logger.LogError($"PLC：链接失败 {result.Err}");
            }
            else
            {
                m_logger.LogTrace($"PLC：链接成功 耗时：{result.TimeConsuming}ms");
            }
        }

        public bool writeInt(string address, ulong value)
        {
            var result = client.Write(address, value);
            if (!result.IsSucceed)
            {
                m_logger.LogError($"PLC：写入失败 {result.Err}");
                return false;
            }
            else
            {
                m_logger.LogTrace($"PLC：写入成功 耗时：{result.TimeConsuming}ms");
                return true;
            }
        }

        public bool? writeBool(string address, bool value)
        {
            try
            {
                var result = client.Write(address, value);
                if (!result.IsSucceed)
                {
                    m_logger.LogError($"PLC：写入失败 {result.Err}");
                    return false;
                }
                else
                {
                    m_logger.LogTrace($"PLC：写入成功 耗时：{result.TimeConsuming}ms");
                    return true;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return null;
            }
        }

        public bool readBool(string code)
        {
            try
            {
                var result = client.ReadBoolean(code);
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取失败：{result.Err}");
                    return false;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return false;
            }
        }

        public int readInt(string code)
        {
            try
            {
                var result = client.ReadInt32(code);
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取失败：{result.Err}");
                    return 0;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return -1;
            }
        }

        public double readDouble(string code)
        {
            try
            {
                var result = client.ReadDouble(code);
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取失败：{result.Err}");
                    return 0;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return -1;
            }
        }

        public bool writeString(string address, string value)
        {
            try
            {
                var result = client.Write(address, value);
                if (!result.IsSucceed)
                {
                    m_logger.LogError($"PLC：写入失败 {result.Err}");
                    return false;
                }
                else
                {
                    m_logger.LogTrace($"PLC：写入成功 耗时：{result.TimeConsuming}ms");
                    return true;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return false;
            }
        }

        public string readString(string address)
        {
            try
            {
                var result = client.ReadString(address);
                var ccc = client.ReadString(address, 20);
                //var sss = client.ReadByte(address);
                var fdsfsd = Encoding.UTF8.GetString(ccc.Value).TrimEnd('\0');
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取失败：{result.Err}");
                    return "";
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC处理错误：{e.Message}");
                return "";
            }
        }

        /// <summary>
        /// 写入float
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool writeFloat(string address, float value)
        {
            try
            {
                var result = client.Write(address, value);
                if (!result.IsSucceed)
                {
                    m_logger.LogError($"PLC：写入 float 失败 {result.Err}");
                    return false;
                }
                else
                {
                    m_logger.LogTrace($"PLC：写入 float 成功 耗时：{result.TimeConsuming}ms");
                    return true;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC 处理写入 float 错误：{e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 读取 float 值方法
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public float readFloat(string address)
        {
            try
            {
                var result = client.ReadFloat(address);
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取 float 成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取 float 失败：{result.Err}");
                    return 0;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC 处理读取 float 错误：{e.Message}");
                return 0;
            }
        }
        /// <summary>
        /// 写入float
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool writeWord(string address, ushort value)
        {
            try
            {
                var result = client.Write(address, value);
                if (!result.IsSucceed)
                {
                    m_logger.LogError($"PLC：写入 word 失败 {result.Err}");
                    return false;
                }
                else
                {
                    m_logger.LogTrace($"PLC：写入 word 成功 耗时：{result.TimeConsuming}ms");
                    return true;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC 处理写入 word 错误：{e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 读取 float 值方法
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public float readWord(string address)
        {
            try
            {
                var result = client.ReadUInt16(address);
                if (result.IsSucceed)
                {
                    m_logger.LogError($"PLC：读取 word 成功 耗时 {result.TimeConsuming}ms");
                    return result.Value;
                }
                else
                {
                    m_logger.LogTrace($"PLC：读取 word 失败：{result.Err}");
                    return 0;
                }
            }
            catch (Exception e)
            {
                m_logger.LogTrace($"PLC 处理读取 word 错误：{e.Message}");
                return 0;
            }
        }
    }
}
