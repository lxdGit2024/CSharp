using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lxd.MTHModels;
using MiniExcelLibs;

namespace lxd.MTHProject
{
    public partial class FrmGroupConfig : Form
    {
        public FrmGroupConfig()
        {
            InitializeComponent();
            this.cmb_StoreArea.DataSource = new string[] { "输入线圈", "输出线圈", "输入寄存器", "输出寄存器" };
        }

        private string groupPath = Application.StartupPath + @"\Config\Group.xlsx";
        private List<Group> TotalGroups = new List<Group>();

        private void btn_Add_Click(object sender, EventArgs e)
        {
            TotalGroups.Add(new Group()
            {
                GroupName = this.txt_GroupName.Text.Trim(),
                Start = Convert.ToUInt16(this.num_Start.Value),
                Length = Convert.ToUInt16(this.num_Length.Value),
                StoreArea = this.cmb_StoreArea.Text.Trim(),
                Remark = this.txt_Remark.Text.Trim()
            });
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroups, overwriteFile: true);
                new FrmMsgBoxWithOutAck("添加通信组成功", "添加通信组").Show();
                // 可在此处补充刷新数据的具体逻辑，比如更新界面显示通信组列表等
            }
            catch (Exception ex)
            {
                new FrmMsgBoxWithOutAck("添加通信组失败: " + ex.Message, "添加通信组").Show();
            }
        }

        private void btn_GroupConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
