using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;
using System;

namespace VOL.WebApi.Common
{
    public class CommunicationRequest
    {
        /// <summary>
        /// 向指定URL发送POST方法的请求，并可传入token添加到请求头用于鉴权
        /// </summary>
        /// <param name="url">发送请求的URL</param>
        /// <param name="jsonData">请求参数，请求参数应该是Json格式字符串的形式。</param>
        /// <param name="token">鉴权token，用于添加到请求头中，若不需要传null即可</param>
        /// <returns>所代表远程资源的响应结果，以JToken格式返回</returns>
        public static JToken SendPost(string url, string jsonData, string token = null)
        {
            try
            {
                CookieContainer cookie = new CookieContainer();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Headers.Add("x-requested-with", "XMLHttpRequest");
                request.ServicePoint.Expect100Continue = false;
                request.ContentType = "application/json";
                request.Accept = "*/*";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1)";
                request.ContentLength = Encoding.UTF8.GetByteCount(jsonData);
                request.CookieContainer = cookie;

                // 设置请求超时时间为 5 秒，可根据实际情况调整
                request.Timeout = 5000;

                if (!string.IsNullOrEmpty(token))
                {
                    request.Headers.Add("Authorization", token);
                }

                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(jsonData);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Cookies = cookie.GetCookies(response.ResponseUri);
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string result = reader.ReadToEnd();
                        return JToken.Parse(result);
                    }
                }
            }
            catch (WebException ex)
            {
                // 处理超时异常或其他网络异常
                Console.WriteLine("发送POST请求出现异常：" + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送POST请求出现异常：" + ex.Message);
                return null;
            }
        }
    }
}
