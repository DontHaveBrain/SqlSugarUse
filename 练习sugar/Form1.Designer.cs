
namespace 练习sugar
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
            this.tbChar = new System.Windows.Forms.TextBox();
            this.bt连接 = new System.Windows.Forms.Button();
            this.bt生成 = new System.Windows.Forms.Button();
            this.bt插入 = new System.Windows.Forms.Button();
            this.bt修改 = new System.Windows.Forms.Button();
            this.bt删除 = new System.Windows.Forms.Button();
            this.bt查询 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(8, 8);
            this.tbChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbChar.Multiline = true;
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(471, 266);
            this.tbChar.TabIndex = 0;
            // 
            // bt连接
            // 
            this.bt连接.Location = new System.Drawing.Point(8, 277);
            this.bt连接.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt连接.Name = "bt连接";
            this.bt连接.Size = new System.Drawing.Size(50, 15);
            this.bt连接.TabIndex = 1;
            this.bt连接.Text = "连接";
            this.bt连接.UseVisualStyleBackColor = true;
            this.bt连接.Click += new System.EventHandler(this.bt连接_Click);
            // 
            // bt生成
            // 
            this.bt生成.Location = new System.Drawing.Point(91, 277);
            this.bt生成.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt生成.Name = "bt生成";
            this.bt生成.Size = new System.Drawing.Size(50, 15);
            this.bt生成.TabIndex = 2;
            this.bt生成.Text = "生成";
            this.bt生成.UseVisualStyleBackColor = true;
            this.bt生成.Click += new System.EventHandler(this.bt生成_Click);
            // 
            // bt插入
            // 
            this.bt插入.Location = new System.Drawing.Point(177, 277);
            this.bt插入.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt插入.Name = "bt插入";
            this.bt插入.Size = new System.Drawing.Size(50, 15);
            this.bt插入.TabIndex = 3;
            this.bt插入.Text = "插入";
            this.bt插入.UseVisualStyleBackColor = true;
            this.bt插入.Click += new System.EventHandler(this.bt插入_Click);
            // 
            // bt修改
            // 
            this.bt修改.Location = new System.Drawing.Point(262, 277);
            this.bt修改.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt修改.Name = "bt修改";
            this.bt修改.Size = new System.Drawing.Size(50, 15);
            this.bt修改.TabIndex = 4;
            this.bt修改.Text = "修改";
            this.bt修改.UseVisualStyleBackColor = true;
            this.bt修改.Click += new System.EventHandler(this.bt修改_Click);
            // 
            // bt删除
            // 
            this.bt删除.Location = new System.Drawing.Point(342, 277);
            this.bt删除.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt删除.Name = "bt删除";
            this.bt删除.Size = new System.Drawing.Size(50, 15);
            this.bt删除.TabIndex = 5;
            this.bt删除.Text = "删除";
            this.bt删除.UseVisualStyleBackColor = true;
            this.bt删除.Click += new System.EventHandler(this.bt删除_Click);
            // 
            // bt查询
            // 
            this.bt查询.Location = new System.Drawing.Point(428, 277);
            this.bt查询.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt查询.Name = "bt查询";
            this.bt查询.Size = new System.Drawing.Size(50, 15);
            this.bt查询.TabIndex = 6;
            this.bt查询.Text = "查询";
            this.bt查询.UseVisualStyleBackColor = true;
            this.bt查询.Click += new System.EventHandler(this.bt查询_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 300);
            this.Controls.Add(this.bt查询);
            this.Controls.Add(this.bt删除);
            this.Controls.Add(this.bt修改);
            this.Controls.Add(this.bt插入);
            this.Controls.Add(this.bt生成);
            this.Controls.Add(this.bt连接);
            this.Controls.Add(this.tbChar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.Button bt连接;
        private System.Windows.Forms.Button bt生成;
        private System.Windows.Forms.Button bt插入;
        private System.Windows.Forms.Button bt修改;
        private System.Windows.Forms.Button bt删除;
        private System.Windows.Forms.Button bt查询;
    }
}

