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
            this.bgLogin.Location = new System.Drawing.Point(18, 18);
            this.bgLogin.Margin = new System.Windows.Forms.Padding(4);
            this.bgLogin.Name = "bgLogin";
            this.bgLogin.Padding = new System.Windows.Forms.Padding(4);
            this.bgLogin.Size = new System.Drawing.Size(1164, 639);
            this.bgLogin.TabIndex = 1;
            this.bgLogin.TabStop = false;
            this.bgLogin.Text = "登录信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_PWD
            // 
            this.tb_PWD.Location = new System.Drawing.Point(537, 245);
            this.tb_PWD.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PWD.Name = "tb_PWD";
            this.tb_PWD.PasswordChar = '*';
            this.tb_PWD.Size = new System.Drawing.Size(226, 28);
            this.tb_PWD.TabIndex = 2;
            this.tb_PWD.TextChanged += new System.EventHandler(this.tb_PWD_TextChanged);
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(537, 155);
            this.tb_User.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(226, 28);
            this.tb_User.TabIndex = 1;
            this.tb_User.TextChanged += new System.EventHandler(this.tb_User_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "密  码 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名 :";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.bgLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
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

