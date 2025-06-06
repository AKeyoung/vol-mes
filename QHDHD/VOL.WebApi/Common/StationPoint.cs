using System.Collections.Generic;

namespace VOL.WebApi.Common
{
    public class StationPoint
    {
        /// <summary>
        /// 检测信号点
        /// </summary>
        public static Dictionary<string, bool> XHDJC = new Dictionary<string, bool>()
        {
           { "OP001", false} ,
           { "OP002", false} ,
           { "OP003", false} ,
           { "OP004", false} ,
           { "OP005", false} ,
           { "OP006", false} ,
           { "OP007", false} ,
           { "OP008", false} ,
           { "OP009", false},
           { "OP010", false} ,
           { "OP011", false} ,
           { "OP012", false} ,
           { "OP013", false} ,
           { "OP014", false} ,
           { "OP015", false} ,
           { "OP016", false} ,
           { "OP017", false} ,
           { "OP018", false} ,
           { "OP019", false} ,
           { "OP020", false} ,
           { "OP021", false} ,
           { "OP022", false} ,
           { "OP023", false} ,
           { "OP024", false} ,
           { "OP025", false} ,
           { "OP026", false} ,
           { "OP027", false} ,
           { "OP028", false} ,
           { "OP029", false },
           { "OP030", false }
        };

        /// <summary>
        /// 根据键获取检测信号点的状态
        /// </summary>
        /// <param name="key">要查询的检测信号点的键</param>
        /// <returns>如果字典中包含该键，则返回对应的值；否则返回 false</returns>
        public static bool GetValue(string key)
        {
            // 检查字典中是否包含指定的键
            return XHDJC.ContainsKey(key) ? XHDJC[key] : false;
        }

        /// <summary>
        /// 根据键设置检测信号点的状态
        /// </summary>
        /// <param name="key">要设置的检测信号点的键</param>
        /// <param name="value">要设置的检测信号点的布尔值</param>
        public static void SetValue(string key, bool value)
        {
            // 检查字典中是否已经包含该键
            if (XHDJC.ContainsKey(key))
            {
                // 如果包含该键，则更新对应的值
                XHDJC[key] = value;
            }
            else
            {
                // 如果不包含该键，则将该键值对添加到字典中
                XHDJC.Add(key, value);
            }
        }
    }
}
