using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using taskmanager.windows;
using LN;

namespace taskmanager
{
    public partial class main_form : Form
    {
        
        
        public main_form()
        {
            InitializeComponent();
        }
        
        //显示信息
        public void ListProcess()
        {
            process_list.Items.Clear();//清空列表

            Process[] proList = Process.GetProcesses(".");//获得本机的进程
            LNode bili = new LNode();//建立链表
            bili.next = null;
            foreach (Process p in proList)
            {
                LNode dili = new LNode();//建立节点
                dili.emmm = p;//获取节点数据域
                dili.next = bili.next;//指针域赋值
                bili.next = dili;//连接链表
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dili.emmm.ProcessName;//获取进程名称
                lvi.SubItems.AddRange(new string[] { dili.emmm.Id.ToString(), (dili.emmm.PrivateMemorySize64 / 1024).ToString() + 'K' }); //进程ID  使用内存
                lvi.Tag = p;
                process_list.Items.Add(lvi);//添加到列表
            }
        }
        //关闭进程
        private void button1_Click(object sender, EventArgs e)
        {
            if (process_list.SelectedItems.Count > 0)
            {
                if (process_list.SelectedItems[0].Tag != null)
                {
                    try
                    {
                        Process p = (Process)process_list.SelectedItems[0].Tag;//获取
                        p.Kill();//关闭程序
                        process_list.Items.Remove(process_list.SelectedItems[0]);//从list中删去
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("无法结束进程 ：" + ee.Message);//错误提示
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProcess();//加载
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void process_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        //以上三个是不小心多点出来的
        //创建程序
        private void btn_run_Click(object sender, EventArgs e)
        {
            var frm = new run();//建立窗口
            frm.ShowDialog();
        }
    }

}
