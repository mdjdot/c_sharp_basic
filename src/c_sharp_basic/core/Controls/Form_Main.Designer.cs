namespace Controls
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.GB_Product = new System.Windows.Forms.GroupBox();
            this.BTN_Submmit = new System.Windows.Forms.Button();
            this.TXT_Count = new System.Windows.Forms.TextBox();
            this.LB_Count = new System.Windows.Forms.Label();
            this.Tip_Count = new System.Windows.Forms.ToolTip(this.components);
            this.GB_Books = new System.Windows.Forms.GroupBox();
            this.TXT_Books = new System.Windows.Forms.TextBox();
            this.BTN_Books = new System.Windows.Forms.Button();
            this.LV_Books = new System.Windows.Forms.ListView();
            this.GB_Process = new System.Windows.Forms.GroupBox();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.PB_Process = new System.Windows.Forms.ProgressBar();
            this.BTN_Pause = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.Timer_Process = new System.Windows.Forms.Timer(this.components);
            this.HELP_Con = new System.Windows.Forms.HelpProvider();
            this.GB_Product.SuspendLayout();
            this.GB_Books.SuspendLayout();
            this.GB_Process.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Product
            // 
            this.GB_Product.Controls.Add(this.BTN_Submmit);
            this.GB_Product.Controls.Add(this.TXT_Count);
            this.GB_Product.Controls.Add(this.LB_Count);
            this.GB_Product.Location = new System.Drawing.Point(0, 0);
            this.GB_Product.Name = "GB_Product";
            this.GB_Product.Size = new System.Drawing.Size(243, 370);
            this.GB_Product.TabIndex = 0;
            this.GB_Product.TabStop = false;
            this.GB_Product.Text = "商品信息";
            // 
            // BTN_Submmit
            // 
            this.BTN_Submmit.Enabled = false;
            this.BTN_Submmit.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Submmit.Image")));
            this.BTN_Submmit.Location = new System.Drawing.Point(12, 101);
            this.BTN_Submmit.Name = "BTN_Submmit";
            this.BTN_Submmit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submmit.TabIndex = 1;
            this.BTN_Submmit.Text = "提交";
            this.BTN_Submmit.UseVisualStyleBackColor = true;
            this.BTN_Submmit.Click += new System.EventHandler(this.BTN_Submmit_Click);
            // 
            // TXT_Count
            // 
            this.TXT_Count.Location = new System.Drawing.Point(64, 14);
            this.TXT_Count.Name = "TXT_Count";
            this.TXT_Count.Size = new System.Drawing.Size(100, 21);
            this.TXT_Count.TabIndex = 1;
            this.TXT_Count.TextChanged += new System.EventHandler(this.TXT_Count_TextChanged);
            // 
            // LB_Count
            // 
            this.LB_Count.AutoSize = true;
            this.LB_Count.Location = new System.Drawing.Point(3, 17);
            this.LB_Count.Name = "LB_Count";
            this.LB_Count.Size = new System.Drawing.Size(41, 12);
            this.LB_Count.TabIndex = 0;
            this.LB_Count.Text = "数量：";
            this.LB_Count.Click += new System.EventHandler(this.LB_Count_Click);
            // 
            // GB_Books
            // 
            this.GB_Books.Controls.Add(this.TXT_Books);
            this.GB_Books.Controls.Add(this.BTN_Books);
            this.GB_Books.Controls.Add(this.LV_Books);
            this.GB_Books.Location = new System.Drawing.Point(258, 0);
            this.GB_Books.Name = "GB_Books";
            this.GB_Books.Size = new System.Drawing.Size(266, 370);
            this.GB_Books.TabIndex = 1;
            this.GB_Books.TabStop = false;
            this.GB_Books.Text = "书目";
            // 
            // TXT_Books
            // 
            this.TXT_Books.Location = new System.Drawing.Point(7, 327);
            this.TXT_Books.Name = "TXT_Books";
            this.TXT_Books.Size = new System.Drawing.Size(145, 21);
            this.TXT_Books.TabIndex = 3;
            // 
            // BTN_Books
            // 
            this.BTN_Books.Location = new System.Drawing.Point(171, 325);
            this.BTN_Books.Name = "BTN_Books";
            this.BTN_Books.Size = new System.Drawing.Size(75, 23);
            this.BTN_Books.TabIndex = 2;
            this.BTN_Books.Text = "提交";
            this.BTN_Books.UseVisualStyleBackColor = true;
            this.BTN_Books.Click += new System.EventHandler(this.BTN_Books_Click);
            // 
            // LV_Books
            // 
            this.LV_Books.BackColor = System.Drawing.Color.LightYellow;
            this.LV_Books.HideSelection = false;
            this.LV_Books.Location = new System.Drawing.Point(6, 14);
            this.LV_Books.Name = "LV_Books";
            this.LV_Books.Size = new System.Drawing.Size(254, 294);
            this.LV_Books.TabIndex = 0;
            this.LV_Books.UseCompatibleStateImageBehavior = false;
            this.LV_Books.View = System.Windows.Forms.View.List;
            // 
            // GB_Process
            // 
            this.GB_Process.Controls.Add(this.BTN_Stop);
            this.GB_Process.Controls.Add(this.PB_Process);
            this.GB_Process.Controls.Add(this.BTN_Pause);
            this.GB_Process.Controls.Add(this.BTN_Start);
            this.GB_Process.Location = new System.Drawing.Point(546, 0);
            this.GB_Process.Name = "GB_Process";
            this.GB_Process.Size = new System.Drawing.Size(254, 370);
            this.GB_Process.TabIndex = 2;
            this.GB_Process.TabStop = false;
            this.GB_Process.Text = "操作进度";
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Enabled = false;
            this.BTN_Stop.Location = new System.Drawing.Point(169, 37);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Stop.TabIndex = 3;
            this.BTN_Stop.Text = "结束";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // PB_Process
            // 
            this.PB_Process.Location = new System.Drawing.Point(7, 181);
            this.PB_Process.Name = "PB_Process";
            this.PB_Process.Size = new System.Drawing.Size(208, 23);
            this.PB_Process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_Process.TabIndex = 2;
            // 
            // BTN_Pause
            // 
            this.BTN_Pause.Enabled = false;
            this.BTN_Pause.Location = new System.Drawing.Point(88, 37);
            this.BTN_Pause.Name = "BTN_Pause";
            this.BTN_Pause.Size = new System.Drawing.Size(75, 23);
            this.BTN_Pause.TabIndex = 1;
            this.BTN_Pause.Text = "暂停";
            this.BTN_Pause.UseVisualStyleBackColor = true;
            this.BTN_Pause.Click += new System.EventHandler(this.BTN_Pause_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(7, 37);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "开始";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // Timer_Process
            // 
            this.Timer_Process.Tick += new System.EventHandler(this.Timer_Process_Tick);
            // 
            // HELP_Con
            // 
            this.HELP_Con.HelpNamespace = "C:\\Users\\medea\\Documents\\libraryd_servlet_search_test.go";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_Process);
            this.Controls.Add(this.GB_Books);
            this.Controls.Add(this.GB_Product);
            this.Name = "Form_Main";
            this.HELP_Con.SetShowHelp(this, true);
            this.Text = "Controls";
            this.GB_Product.ResumeLayout(false);
            this.GB_Product.PerformLayout();
            this.GB_Books.ResumeLayout(false);
            this.GB_Books.PerformLayout();
            this.GB_Process.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Product;
        private System.Windows.Forms.TextBox TXT_Count;
        private System.Windows.Forms.Label LB_Count;
        private System.Windows.Forms.Button BTN_Submmit;
        private System.Windows.Forms.ToolTip Tip_Count;
        private System.Windows.Forms.GroupBox GB_Books;
        private System.Windows.Forms.TextBox TXT_Books;
        private System.Windows.Forms.Button BTN_Books;
        private System.Windows.Forms.ListView LV_Books;
        private System.Windows.Forms.GroupBox GB_Process;
        private System.Windows.Forms.ProgressBar PB_Process;
        private System.Windows.Forms.Button BTN_Pause;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Timer Timer_Process;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.HelpProvider HELP_Con;
    }
}

