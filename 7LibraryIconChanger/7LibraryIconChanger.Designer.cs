namespace _7LibraryIconChanger
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TbxIconPath = new System.Windows.Forms.TextBox();
            this.BtnChoose = new System.Windows.Forms.Button();
            this.getIconPathDlg = new System.Windows.Forms.OpenFileDialog();
            this.CbxLibrary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnRebuildIconCache = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxIconPath
            // 
            this.TbxIconPath.Location = new System.Drawing.Point(10, 37);
            this.TbxIconPath.Name = "TbxIconPath";
            this.TbxIconPath.ReadOnly = true;
            this.TbxIconPath.Size = new System.Drawing.Size(225, 23);
            this.TbxIconPath.TabIndex = 0;
            // 
            // BtnChoose
            // 
            this.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnChoose.Location = new System.Drawing.Point(241, 6);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(66, 54);
            this.BtnChoose.TabIndex = 1;
            this.BtnChoose.Tag = "";
            this.BtnChoose.Text = "选择图标";
            this.BtnChoose.UseVisualStyleBackColor = true;
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // getIconPathDlg
            // 
            this.getIconPathDlg.Filter = "图标文件(*.ico)|*.ico";
            this.getIconPathDlg.Title = "选择图标";
            // 
            // CbxLibrary
            // 
            this.CbxLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxLibrary.FormattingEnabled = true;
            this.CbxLibrary.Location = new System.Drawing.Point(81, 6);
            this.CbxLibrary.Name = "CbxLibrary";
            this.CbxLibrary.Size = new System.Drawing.Size(154, 25);
            this.CbxLibrary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择库：";
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(10, 66);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(58, 30);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "替换";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(74, 66);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(58, 30);
            this.BtnRestore.TabIndex = 5;
            this.BtnRestore.Text = "还原";
            this.BtnRestore.UseVisualStyleBackColor = true;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "系统版本——";
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(241, 66);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(66, 30);
            this.BtnAbout.TabIndex = 7;
            this.BtnAbout.Text = "关于";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnRebuildIconCache
            // 
            this.BtnRebuildIconCache.Location = new System.Drawing.Point(138, 66);
            this.BtnRebuildIconCache.Name = "BtnRebuildIconCache";
            this.BtnRebuildIconCache.Size = new System.Drawing.Size(97, 30);
            this.BtnRebuildIconCache.TabIndex = 8;
            this.BtnRebuildIconCache.Text = "刷新图标缓存";
            this.BtnRebuildIconCache.UseVisualStyleBackColor = true;
            this.BtnRebuildIconCache.Click += new System.EventHandler(this.BtnRebuildIconCache_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_7LibraryIconChanger.Properties.Resources._7LibraryIconChanger;
            this.ClientSize = new System.Drawing.Size(316, 145);
            this.Controls.Add(this.BtnRebuildIconCache);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxLibrary);
            this.Controls.Add(this.BtnChoose);
            this.Controls.Add(this.TbxIconPath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Library Icon Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIconPath;
        private System.Windows.Forms.Button BtnChoose;
        private System.Windows.Forms.OpenFileDialog getIconPathDlg;
        public System.Windows.Forms.ComboBox CbxLibrary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnRebuildIconCache;
    }
}

