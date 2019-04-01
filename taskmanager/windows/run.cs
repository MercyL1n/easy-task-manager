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
using taskmanager;

namespace taskmanager.windows
{
    public partial class run : Form
    {
        public run()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }
        //以上都是不小心点出来的
        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = textBox1.Text;
            p.Start();//启动
        }
    }
}
