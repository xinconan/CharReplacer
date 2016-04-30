namespace CharReplacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.cbSubPath = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isRegex = new System.Windows.Forms.CheckBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件类型：";
            // 
            // cbFileType
            // 
            this.cbFileType.FormattingEnabled = true;
            this.cbFileType.Items.AddRange(new object[] {
            "*.*",
            "*.html",
            "*.htm",
            "*.js",
            "*.css",
            "*.jsp",
            "*.java",
            "*.cs",
            "*.py"});
            this.cbFileType.Location = new System.Drawing.Point(98, 10);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(332, 20);
            this.cbFileType.TabIndex = 1;
            this.cbFileType.Text = "*.*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件目录：";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(98, 40);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(269, 21);
            this.tbPath.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(374, 40);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(56, 23);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "浏览";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // cbSubPath
            // 
            this.cbSubPath.AutoSize = true;
            this.cbSubPath.Checked = true;
            this.cbSubPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubPath.Location = new System.Drawing.Point(98, 73);
            this.cbSubPath.Name = "cbSubPath";
            this.cbSubPath.Size = new System.Drawing.Size(84, 16);
            this.cbSubPath.TabIndex = 4;
            this.cbSubPath.Text = "包含子目录";
            this.cbSubPath.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "要替换的字符：";
            // 
            // isRegex
            // 
            this.isRegex.AutoSize = true;
            this.isRegex.Location = new System.Drawing.Point(111, 96);
            this.isRegex.Name = "isRegex";
            this.isRegex.Size = new System.Drawing.Size(108, 16);
            this.isRegex.TabIndex = 5;
            this.isRegex.Text = "使用正则表达式";
            this.isRegex.UseVisualStyleBackColor = true;
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(98, 118);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSource.Size = new System.Drawing.Size(332, 115);
            this.tbSource.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "替换为：";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(98, 253);
            this.tbDestination.Multiline = true;
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDestination.Size = new System.Drawing.Size(332, 115);
            this.tbDestination.TabIndex = 6;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(265, 374);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "开始替换";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(355, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "退出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 435);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.isRegex);
            this.Controls.Add(this.cbSubPath);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.cbFileType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符替换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.CheckBox cbSubPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isRegex;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnLogout;
    }
}

