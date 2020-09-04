namespace txt_test
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("文件");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.select_dir = new System.Windows.Forms.Button();
            this.StartRead = new System.Windows.Forms.Button();
            this.directory_ = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FileList = new System.Windows.Forms.TreeView();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.select_dir);
            this.groupBox1.Controls.Add(this.StartRead);
            this.groupBox1.Controls.Add(this.directory_);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件夹";
            // 
            // select_dir
            // 
            this.select_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_dir.Location = new System.Drawing.Point(648, 22);
            this.select_dir.Name = "select_dir";
            this.select_dir.Size = new System.Drawing.Size(121, 29);
            this.select_dir.TabIndex = 3;
            this.select_dir.Text = "选择文件夹";
            this.select_dir.UseVisualStyleBackColor = true;
            this.select_dir.Click += new System.EventHandler(this.select_dir_Click);
            // 
            // StartRead
            // 
            this.StartRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartRead.Location = new System.Drawing.Point(775, 22);
            this.StartRead.Name = "StartRead";
            this.StartRead.Size = new System.Drawing.Size(103, 29);
            this.StartRead.TabIndex = 1;
            this.StartRead.Text = "读取";
            this.StartRead.UseVisualStyleBackColor = true;
            this.StartRead.Click += new System.EventHandler(this.StartRead_Click);
            // 
            // directory_
            // 
            this.directory_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directory_.Location = new System.Drawing.Point(6, 26);
            this.directory_.Name = "directory_";
            this.directory_.ReadOnly = true;
            this.directory_.Size = new System.Drawing.Size(636, 21);
            this.directory_.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FileList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtData);
            this.splitContainer1.Size = new System.Drawing.Size(884, 430);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 1;
            // 
            // FileList
            // 
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.Location = new System.Drawing.Point(0, 0);
            this.FileList.Name = "FileList";
            treeNode1.Name = "File_data";
            treeNode1.Text = "文件";
            this.FileList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.FileList.Size = new System.Drawing.Size(287, 430);
            this.FileList.TabIndex = 0;
            // 
            // TxtData
            // 
            this.TxtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtData.Location = new System.Drawing.Point(0, 0);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.ReadOnly = true;
            this.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtData.Size = new System.Drawing.Size(593, 430);
            this.TxtData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartRead;
        private System.Windows.Forms.TextBox directory_;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView FileList;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Button select_dir;
    }
}

