﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lxd.MTHModels
{
    public class Variable
    {
        /// <summary>
        /// 变量名称
        /// </summary>
        public string VarName { get; set; }

        /// <summary>
        /// 起始索引
        /// </summary>
        public ushort Start { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 位偏移或长度
        /// </summary>
        public int OffsetOrLength { get; set; }

        /// <summary>
        /// 所属通信组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否上升沿报警
        /// </summary>
        public bool PosAlarm { get; set; }

        /// <summary>
        /// 是否下降沿报警
        /// </summary>
        public bool NegAlarm { get; set; }

        /// <summary>
        /// 转换系数
        /// </summary>
        public float Scale { get; set; } = 1.0f;

        /// <summary>
        /// 偏移值
        /// </summary>
        public float Offset { get; set; } = 0.0f;
    }
}
