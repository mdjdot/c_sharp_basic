namespace DataConnect
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
            this.DGV_Users = new System.Windows.Forms.DataGridView();
            this.appDBDataSet = new DataConnect.appDBDataSet();
            this.appDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Users
            // 
            this.DGV_Users.AllowUserToAddRows = false;
            this.DGV_Users.AllowUserToDeleteRows = false;
            this.DGV_Users.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.User_Name,
            this.User_Age,
            this.User_Gender});
            this.DGV_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Users.Location = new System.Drawing.Point(0, 0);
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.ReadOnly = true;
            this.DGV_Users.RowTemplate.Height = 23;
            this.DGV_Users.Size = new System.Drawing.Size(800, 574);
            this.DGV_Users.TabIndex = 0;
            // 
            // appDBDataSet
            // 
            this.appDBDataSet.DataSetName = "appDBDataSet";
            this.appDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDBDataSetBindingSource
            // 
            this.appDBDataSetBindingSource.DataSource = this.appDBDataSet;
            this.appDBDataSetBindingSource.Position = 0;
            // 
            // appDBDataSetBindingSource1
            // 
            this.appDBDataSetBindingSource1.DataSource = this.appDBDataSet;
            this.appDBDataSetBindingSource1.Position = 0;
            // 
            // User_ID
            // 
            this.User_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_ID.DataPropertyName = "ID";
            this.User_ID.HeaderText = "编号";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Name.DataPropertyName = "Name";
            this.User_Name.HeaderText = "姓名";
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // User_Age
            // 
            this.User_Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Age.DataPropertyName = "Age";
            this.User_Age.HeaderText = "年龄";
            this.User_Age.Name = "User_Age";
            this.User_Age.ReadOnly = true;
            // 
            // User_Gender
            // 
            this.User_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Gender.DataPropertyName = "Gender";
            this.User_Gender.HeaderText = "性别";
            this.User_Gender.Name = "User_Gender";
            this.User_Gender.ReadOnly = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.DGV_Users);
            this.Name = "Form_Main";
            this.Text = "Ado dot net";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Users;
        private System.Windows.Forms.BindingSource appDBDataSetBindingSource;
        private appDBDataSet appDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Gender;
        private System.Windows.Forms.BindingSource appDBDataSetBindingSource1;
    }
}

