using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lxd.MTHModels
{
    /// <summary>
    /// 通信设备实体类
    /// </summary>
    public class Device
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }
        
        /// <summary>
        /// 通信组集合
        /// </summary>
        public List<Group> GroupList { get; set; }
    }
}
