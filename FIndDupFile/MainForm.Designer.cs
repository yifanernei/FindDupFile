namespace FIndDupFile
{
    partial class MainForm
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            this.lv_dirs = new System.Windows.Forms.ListView();
            this.bt_adddir = new System.Windows.Forms.Button();
            this.fbd_dirs = new System.Windows.Forms.FolderBrowserDialog();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_dirs
            // 
            this.lv_dirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader2,
            columnHeader3});
            this.lv_dirs.FullRowSelect = true;
            this.lv_dirs.GridLines = true;
            this.lv_dirs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dirs.Location = new System.Drawing.Point(12, 162);
            this.lv_dirs.Name = "lv_dirs";
            this.lv_dirs.Size = new System.Drawing.Size(580, 189);
            this.lv_dirs.TabIndex = 0;
            this.lv_dirs.UseCompatibleStateImageBehavior = false;
            this.lv_dirs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "目录名";
            columnHeader2.Width = 440;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "上次扫描时间";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // bt_adddir
            // 
            this.bt_adddir.Location = new System.Drawing.Point(13, 357);
            this.bt_adddir.Name = "bt_adddir";
            this.bt_adddir.Size = new System.Drawing.Size(75, 23);
            this.bt_adddir.TabIndex = 1;
            this.bt_adddir.Text = "添加目录";
            this.bt_adddir.UseVisualStyleBackColor = true;
            this.bt_adddir.Click += new System.EventHandler(this.bt_adddir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 574);
            this.Controls.Add(this.bt_adddir);
            this.Controls.Add(this.lv_dirs);
            this.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重复文件查找窗口";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_dirs;
        private System.Windows.Forms.Button bt_adddir;
        private System.Windows.Forms.FolderBrowserDialog fbd_dirs;
    }
}

