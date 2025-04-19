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
    [DefaultEvent("Click")]
    public partial class NaviButton : UserControl
    {
        public NaviButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true); // 允许自定义绘制
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 允许在调整大小时重绘
            this.SetStyle(ControlStyles.DoubleBuffer, false);// 启用双缓冲
            this.SetStyle(ControlStyles.Selectable, true);  // 允许选择
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 支持透明背景色
        }

        private bool isSelected = false;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮是否选中")]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                UpdateImage();
            }
        }

        private bool isLeft = true;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮是否为左边")]
        public bool IsLeft
        {
            get { return isLeft; }
            set
            {
                isLeft = value;
                UpdateImage();
            }
        }

        private string titleName = "导航按钮";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮内容")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text = titleName;
            }
        }

        /// <summary>
        /// 统一更新背景
        /// </summary>
        private void UpdateImage()
        {
            if (this.isLeft)
            {
                this.BackgroundImage = isSelected ? Properties.Resources.LeftSelected : Properties.Resources.LeftUnSelected;
            }
            else
            {
                this.BackgroundImage = isSelected ? Properties.Resources.RightSelected : Properties.Resources.RightUnSelected;
            }
        }
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("点击事件传递，由文本框转给按钮")]
        public new EventHandler Click;

        private void lbl_Title_Click(object sender, EventArgs e)
        {
            if(Click != null)
            {
                this.Click?.Invoke(this,e);
            }
        }
    }
}
