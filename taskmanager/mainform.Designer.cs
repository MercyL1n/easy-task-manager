namespace taskmanager
{
    partial class main_form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.process_list = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // process_list
            // 
            this.process_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.pid,
            this.ram});
            this.process_list.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.process_list.Location = new System.Drawing.Point(0, -2);
            this.process_list.Name = "process_list";
            this.process_list.Size = new System.Drawing.Size(559, 385);
            this.process_list.TabIndex = 0;
            this.process_list.UseCompatibleStateImageBehavior = false;
            this.process_list.View = System.Windows.Forms.View.Details;
            this.process_list.SelectedIndexChanged += new System.EventHandler(this.process_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 221;
            // 
            // pid
            // 
            this.pid.Text = "PID";
            this.pid.Width = 93;
            // 
            // ram
            // 
            this.ram.Text = "内存";
            this.ram.Width = 241;
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_end.Location = new System.Drawing.Point(451, 407);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(86, 31);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "结束进程";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_run.Location = new System.Drawing.Point(26, 407);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(86, 31);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "打开进程";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.process_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务管理器";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView process_list;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_run;
    }
}

