using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lxd.MTHControlLib
{
    [DefaultEvent("Click")]
    public partial class PanelEx : Panel
    {
        public PanelEx()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true); // 允许自定义绘制
            this.SetStyle(ControlStyles.ResizeRedraw, true); // 允许在调整大小时重绘
            this.SetStyle(ControlStyles.DoubleBuffer, false);// 启用双缓冲
            this.SetStyle(ControlStyles.Selectable, true);  // 允许选择
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // 支持透明背景色
        }

        private int topGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示顶部间距")]
        public int TopGap
        {
            get { return topGap; }
            // 设置顶部间距并使控件重绘
            set
            {
                topGap = value;
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        private int bottomGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示底部间距")]
        public int BottomGap
        {
            get { return bottomGap; }
            set
            {
                bottomGap = value; 
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        private int leftGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示左侧间距")]
        public int LeftGap
        {
            get { return leftGap; }
            set
            {
                leftGap = value; 
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        private int rightGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示右侧间距")]
        public int RightGap
        {
            get { return rightGap; }
            set
            {
                rightGap = value; 
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        private int borderWidth = 2;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示边框宽度")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value; 
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        private Color borderColor = Color.FromArgb(35, 255, 253);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置和显示边框颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value; 
                this.Invalidate(); // 触发重绘以反映更改
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //准备画布
            Graphics graphics = e.Graphics;
            //准备笔
            Pen pen = new Pen(borderColor,borderWidth);
            //准备矩形参数
            float x = leftGap + borderWidth / 2f;
            float y = topGap + borderWidth / 2f;
            float width = this.Width - leftGap - rightGap - borderWidth;
            float height = this.Height - topGap - bottomGap - borderWidth;
            //绘制矩形
            graphics.DrawRectangle(pen, x, y, width, height);
      
        }
    }
}
