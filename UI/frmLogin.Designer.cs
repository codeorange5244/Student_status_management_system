namespace StudentStatusManageSystem.UI
{
    partial class frmLogin
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
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.btnExit = new CCWin.SkinControl.SkinButton();
            this.rtfRichTextBox2 = new CCWin.SkinControl.RtfRichTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.labForgetPwd = new CCWin.SkinControl.SkinLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = null;
            this.btnLogin.Location = new System.Drawing.Point(102, 318);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Size = new System.Drawing.Size(87, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExit.DownBack = null;
            this.btnExit.Location = new System.Drawing.Point(227, 318);
            this.btnExit.MouseBack = null;
            this.btnExit.Name = "btnExit";
            this.btnExit.NormlBack = null;
            this.btnExit.Size = new System.Drawing.Size(84, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtfRichTextBox2
            // 
            this.rtfRichTextBox2.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox2.Location = new System.Drawing.Point(159, 174);
            this.rtfRichTextBox2.Multiline = false;
            this.rtfRichTextBox2.Name = "rtfRichTextBox2";
            this.rtfRichTextBox2.Size = new System.Drawing.Size(190, 28);
            this.rtfRichTextBox2.TabIndex = 2;
            this.rtfRichTextBox2.Text = "";
            this.rtfRichTextBox2.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(79, 181);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "用户名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(79, 243);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "密码";
            // 
            // labForgetPwd
            // 
            this.labForgetPwd.AutoSize = true;
            this.labForgetPwd.BackColor = System.Drawing.Color.Transparent;
            this.labForgetPwd.BorderColor = System.Drawing.Color.White;
            this.labForgetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labForgetPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labForgetPwd.Location = new System.Drawing.Point(243, 374);
            this.labForgetPwd.Name = "labForgetPwd";
            this.labForgetPwd.Size = new System.Drawing.Size(68, 17);
            this.labForgetPwd.TabIndex = 4;
            this.labForgetPwd.Text = "忘记密码？";
            this.labForgetPwd.Click += new System.EventHandler(this.labForgetPwd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(190, 21);
            this.textBox1.TabIndex = 5;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.skinLabel3.ForeColor = System.Drawing.Color.Lime;
            this.skinLabel3.Location = new System.Drawing.Point(84, 79);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(274, 41);
            this.skinLabel3.TabIndex = 6;
            this.skinLabel3.Text = "学生学籍管理系统";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 428);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labForgetPwd);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.rtfRichTextBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Radius = 430;
            this.SkinOpacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton btnExit;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel labForgetPwd;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}

