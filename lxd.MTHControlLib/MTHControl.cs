using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lxd.MTHControlLib
{
    public partial class MTHControl : UserControl
    {
        public MTHControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true); // 允许自定义绘制
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 允许在调整大小时重绘
            this.SetStyle(ControlStyles.DoubleBuffer, false);// 启用双缓冲
            this.SetStyle(ControlStyles.Selectable, true);  // 允许选择
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 支持透明背景色
        }

        private string title = "1# 站点";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示标题名称")]

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.lbl_Title.Text = title;
            }
        }
        private string temp = "0.0";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示温度值")]

        public string Temp
        {
            get { return temp; }
            set
            {
                if (temp != value)
                {
                    temp = value;
                    this.lbl_Temp.Text = temp;
                    if (float.TryParse(temp, out float val))
                    {
                        this.dailPlate.Temp = val;
                    }
                    else
                    {
                        this.dailPlate.Temp = 0.0f;
                    }
                }                
            }
        }
        private string humidity = "0.0";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示湿度值")]

        public string Humidity
        {
            get { return humidity; }
            set
            {
                if (humidity != value)
                {
                    humidity = value;
                    this.lbl_Humidity.Text = humidity;
                    if (float.TryParse(humidity, out float val))
                    {
                        this.dailPlate.Humidity = val;
                    }
                    else
                    {
                        this.dailPlate.Humidity = 0.0f;
                    }
                }
            }
        }

        private bool moduleError = false;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示湿度值")]
        public bool ModuleError
        {
            get { return moduleError; }
            set
            {
                moduleError = value;
                this.lbl_Title.BackColor = moduleError ? Color.Red : Color.FromArgb(36, 184, 196);
            }
        }

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示温度绑定变量名称")]
        public string TempVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示湿度绑定变量名称")]
        public string HumidityVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示状态绑定变量名称")]
        public string StateVarName { get; set; } = string.Empty;
    }
}
