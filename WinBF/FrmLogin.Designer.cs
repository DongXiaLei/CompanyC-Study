namespace WinBF
{
    partial class FrmLogin
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
            this.bgLogin = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_PWD = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgLogin
            // 
            this.bgLogin.BackColor = System.Drawing.Color.Transparent;
            this.bgLogin.Controls.Add(this.button2);
            this.bgLogin.Controls.Add(this.button1);
            this.bgLogin.Controls.Add(this.tb_PWD);
            this.bgLogin.Controls.Add(this.tb_User);
            this.bgLogin.Controls.Add(this.label2);
            this.bgLogin.Controls.Add(this.label1);
            this.bgLogin.Location = new System.Drawing.Point(12, 12);
            this.bgLogin.Name = "bgLogin";
            this.bgLogin.Size = new System.Drawing.Size(776, 426);
            this.bgLogin.TabIndex = 1;
            this.bgLogin.TabStop = false;
            this.bgLogin.Text = "登录信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_PWD
            // 
            this.tb_PWD.Location = new System.Drawing.Point(358, 170);
            this.tb_PWD.Name = "tb_PWD";
            this.tb_PWD.Size = new System.Drawing.Size(152, 21);
            this.tb_PWD.TabIndex = 2;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(358, 102);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(152, 21);
            this.tb_User.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密  码 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名 :";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bgLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.bgLogin.ResumeLayout(false);
            this.bgLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_PWD;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

