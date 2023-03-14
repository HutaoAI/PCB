namespace YBR_Program
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DebugBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Location = new System.Drawing.Point(0, 71);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1664, 902);
            this.FormPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 973);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1664, 27);
            this.panel2.TabIndex = 4;
            // 
            // DebugBtn
            // 
            this.DebugBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DebugBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DebugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugBtn.Image = global::YBR_Program.Properties.Resources.调试;
            this.DebugBtn.Location = new System.Drawing.Point(81, 2);
            this.DebugBtn.Name = "DebugBtn";
            this.DebugBtn.Size = new System.Drawing.Size(70, 65);
            this.DebugBtn.TabIndex = 5;
            this.DebugBtn.UseVisualStyleBackColor = true;
            this.DebugBtn.Click += new System.EventHandler(this.DebutBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = global::YBR_Program.Properties.Resources.Home;
            this.HomeBtn.Location = new System.Drawing.Point(5, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(70, 65);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Image = global::YBR_Program.Properties.Resources.minimization;
            this.MinBtn.Location = new System.Drawing.Point(1516, 2);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(70, 65);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = global::YBR_Program.Properties.Resources.关闭;
            this.CloseBtn.Location = new System.Drawing.Point(1591, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(70, 65);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 1000);
            this.Controls.Add(this.DebugBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BaseView";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DebugBtn;
    }
}

