using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lxd.MTHControlLib;
using lxd.MTHModels;

namespace lxd.MTHProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CommonNaviButton_Click(object sender, EventArgs e)
        {
            if (sender is NaviButton navi)
            {
                if (Enum.IsDefined(typeof(FormNames), navi.TitleName))
                {
                    //拿到导航按钮对应的窗体枚举值(名称)
                    FormNames formNames = (FormNames)Enum.Parse(typeof(FormNames), navi.TitleName, true);
                    //MessageBox.Show(formNames.ToString());
                    //窗体切换
                    OpenForm(this.MainPanel, formNames);
                    //设置Title
                    SetTitle(this.lbl_Title, formNames);
                    //设置选中
                    SetNaviButtonSelected(this.ToPpanel, navi);
                }
            }
        }
        /// <summary>
        /// 通用窗体打开方法
        /// </summary>
        /// <param name="mainPanel">容器控件</param>
        /// <param name="formNames">窗体枚举名称</param>
        private void OpenForm(Panel mainPanel, FormNames formNames)
        {
            int total = mainPanel.Controls.Count;
            int closeCount = 0;
            bool isFind = false;
            for (int i = 0; i < total; i++)
            {
                Control ct = mainPanel.Controls[i - closeCount];

                if (ct is Form frm)
                {
                    if (frm.Text == formNames.ToString())
                    {//判断是否是当前窗体
                        frm.BringToFront();
                        isFind = true;
                        break;
                    }
                    else if ((FormNames)Enum.Parse(typeof(FormNames), frm.Text, true) >= FormNames.临界窗体)
                    {//如果当前不是我们需要操作的窗体，然后判断是否为固定窗体，如果不是则关闭；如果是则不做处理
                        frm.Close();
                        closeCount++;
                    }
                }
            }

            if (isFind == false)
            {
                Form frm = null;
                switch (formNames)
                {
                    case FormNames.集中监控:
                        frm = new FrmMonitor();
                        break;
                    case FormNames.参数设置:
                        frm = new FrmParamSet();
                        break;
                    case FormNames.配方管理:
                        frm = new FrmRecipe();
                        break;
                    case FormNames.报警追溯:
                        frm = new FrmAlarm();
                        break;
                    case FormNames.历史趋势:
                        frm = new FrmHistory();
                        break;
                    case FormNames.用户管理:
                        frm = new FrmUserManage();
                        break;
                }
                if (frm != null)
                {
                    //设置非顶层窗体
                    frm.TopLevel = false;
                    //去边框
                    frm.FormBorderStyle = FormBorderStyle.None;
                    //填充
                    frm.Dock = DockStyle.Fill;
                    //设置父容器
                    frm.Parent = mainPanel;
                    //置前
                    frm.BringToFront();
                    frm.Show();
                }
            }
        }

        /// <summary>
        /// 设置标题内容
        /// </summary>
        /// <param name="title">标题控件</param>
        /// <param name="formNames">窗体枚举</param>
        private void SetTitle(Label title, FormNames formNames)
        {
            title.Text = formNames.ToString();
        }

        /// <summary>
        /// 设置导航按钮选中
        /// </summary>
        /// <param name="topPanel">导航按钮容器</param>
        /// <param name="navi">窗体枚举名称</param>
        private void SetNaviButtonSelected(Panel topPanel, NaviButton naviButton)
        {
            foreach (var item in topPanel.Controls.OfType<NaviButton>())
            {
                item.IsSelected = false;
            }
            naviButton.IsSelected = true;
        }

        #region 减少闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
