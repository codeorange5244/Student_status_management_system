namespace StudentStatusManageSystem.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.btnAboutMe = new CCWin.SkinControl.SkinButton();
            this.btnScoreManage = new CCWin.SkinControl.SkinButton();
            this.btnCourseManage = new CCWin.SkinControl.SkinButton();
            this.btnStudentManage = new CCWin.SkinControl.SkinButton();
            this.btnClassInfoManage = new CCWin.SkinControl.SkinButton();
            this.btnSpecialitySetting = new CCWin.SkinControl.SkinButton();
            this.btnSystemSetting = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.btnAdvanced_operations = new CCWin.SkinControl.SkinButton();
            this.btnAddRole = new CCWin.SkinControl.SkinButton();
            this.btnAeroWallpaperChanger = new CCWin.SkinControl.SkinButton();
            this.btnAddUser = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 28);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnAboutMe);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnScoreManage);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnCourseManage);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnStudentManage);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnClassInfoManage);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnSpecialitySetting);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnSystemSetting);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinGroupBox1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1129, 671);
            this.skinSplitContainer1.SplitterDistance = 117;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutMe.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.question11;
            this.btnAboutMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboutMe.BaseColor = System.Drawing.Color.Transparent;
            this.btnAboutMe.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAboutMe.DownBack = null;
            this.btnAboutMe.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnAboutMe.ForeColor = System.Drawing.Color.White;
            this.btnAboutMe.Location = new System.Drawing.Point(941, -1);
            this.btnAboutMe.MouseBack = null;
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.NormlBack = null;
            this.btnAboutMe.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAboutMe.Size = new System.Drawing.Size(147, 116);
            this.btnAboutMe.TabIndex = 0;
            this.btnAboutMe.Text = "关于";
            this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAboutMe.UseVisualStyleBackColor = false;
            this.btnAboutMe.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnAboutMe.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnScoreManage
            // 
            this.btnScoreManage.BackColor = System.Drawing.Color.Transparent;
            this.btnScoreManage.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.score;
            this.btnScoreManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScoreManage.BaseColor = System.Drawing.Color.Transparent;
            this.btnScoreManage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnScoreManage.DownBack = null;
            this.btnScoreManage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnScoreManage.ForeColor = System.Drawing.Color.White;
            this.btnScoreManage.Location = new System.Drawing.Point(789, -1);
            this.btnScoreManage.MouseBack = null;
            this.btnScoreManage.Name = "btnScoreManage";
            this.btnScoreManage.NormlBack = null;
            this.btnScoreManage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnScoreManage.Size = new System.Drawing.Size(147, 116);
            this.btnScoreManage.TabIndex = 0;
            this.btnScoreManage.Text = "成绩信息管理";
            this.btnScoreManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScoreManage.UseVisualStyleBackColor = false;
            this.btnScoreManage.Click += new System.EventHandler(this.btnScoreManage_Click);
            this.btnScoreManage.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnScoreManage.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnCourseManage
            // 
            this.btnCourseManage.BackColor = System.Drawing.Color.Transparent;
            this.btnCourseManage.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.book114;
            this.btnCourseManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCourseManage.BaseColor = System.Drawing.Color.Transparent;
            this.btnCourseManage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCourseManage.DownBack = null;
            this.btnCourseManage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnCourseManage.ForeColor = System.Drawing.Color.White;
            this.btnCourseManage.Location = new System.Drawing.Point(637, 2);
            this.btnCourseManage.MouseBack = null;
            this.btnCourseManage.Name = "btnCourseManage";
            this.btnCourseManage.NormlBack = null;
            this.btnCourseManage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnCourseManage.Size = new System.Drawing.Size(147, 116);
            this.btnCourseManage.TabIndex = 0;
            this.btnCourseManage.Text = "课程信息管理";
            this.btnCourseManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourseManage.UseVisualStyleBackColor = false;
            this.btnCourseManage.Click += new System.EventHandler(this.btnCourseManage_Click);
            this.btnCourseManage.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnCourseManage.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentManage.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.student2;
            this.btnStudentManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudentManage.BaseColor = System.Drawing.Color.Transparent;
            this.btnStudentManage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStudentManage.DownBack = null;
            this.btnStudentManage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnStudentManage.ForeColor = System.Drawing.Color.White;
            this.btnStudentManage.Location = new System.Drawing.Point(485, 2);
            this.btnStudentManage.MouseBack = null;
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.NormlBack = null;
            this.btnStudentManage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnStudentManage.Size = new System.Drawing.Size(147, 116);
            this.btnStudentManage.TabIndex = 0;
            this.btnStudentManage.Text = "学生信息管理";
            this.btnStudentManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentManage.UseVisualStyleBackColor = false;
            this.btnStudentManage.Click += new System.EventHandler(this.btnStudentManage_Click);
            this.btnStudentManage.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnStudentManage.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnClassInfoManage
            // 
            this.btnClassInfoManage.BackColor = System.Drawing.Color.Transparent;
            this.btnClassInfoManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClassInfoManage.BackgroundImage")));
            this.btnClassInfoManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClassInfoManage.BaseColor = System.Drawing.Color.Transparent;
            this.btnClassInfoManage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClassInfoManage.DownBack = null;
            this.btnClassInfoManage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnClassInfoManage.ForeColor = System.Drawing.Color.White;
            this.btnClassInfoManage.Location = new System.Drawing.Point(333, 2);
            this.btnClassInfoManage.MouseBack = null;
            this.btnClassInfoManage.Name = "btnClassInfoManage";
            this.btnClassInfoManage.NormlBack = null;
            this.btnClassInfoManage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnClassInfoManage.Size = new System.Drawing.Size(147, 116);
            this.btnClassInfoManage.TabIndex = 0;
            this.btnClassInfoManage.Text = "班级信息管理";
            this.btnClassInfoManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClassInfoManage.UseVisualStyleBackColor = false;
            this.btnClassInfoManage.Click += new System.EventHandler(this.btnClassInfoManage_Click);
            this.btnClassInfoManage.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnClassInfoManage.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnSpecialitySetting
            // 
            this.btnSpecialitySetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSpecialitySetting.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.speciality;
            this.btnSpecialitySetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpecialitySetting.BaseColor = System.Drawing.Color.Transparent;
            this.btnSpecialitySetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSpecialitySetting.DownBack = null;
            this.btnSpecialitySetting.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSpecialitySetting.ForeColor = System.Drawing.Color.White;
            this.btnSpecialitySetting.Location = new System.Drawing.Point(181, 2);
            this.btnSpecialitySetting.MouseBack = null;
            this.btnSpecialitySetting.Name = "btnSpecialitySetting";
            this.btnSpecialitySetting.NormlBack = null;
            this.btnSpecialitySetting.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnSpecialitySetting.Size = new System.Drawing.Size(147, 116);
            this.btnSpecialitySetting.TabIndex = 0;
            this.btnSpecialitySetting.Text = "专业设置";
            this.btnSpecialitySetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpecialitySetting.UseVisualStyleBackColor = false;
            this.btnSpecialitySetting.Click += new System.EventHandler(this.btnSpecialitySetting_Click);
            this.btnSpecialitySetting.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnSpecialitySetting.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // btnSystemSetting
            // 
            this.btnSystemSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemSetting.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.settings20;
            this.btnSystemSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSystemSetting.BaseColor = System.Drawing.Color.Transparent;
            this.btnSystemSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSystemSetting.DownBack = null;
            this.btnSystemSetting.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSystemSetting.ForeColor = System.Drawing.Color.White;
            this.btnSystemSetting.Location = new System.Drawing.Point(29, 3);
            this.btnSystemSetting.MouseBack = null;
            this.btnSystemSetting.Name = "btnSystemSetting";
            this.btnSystemSetting.NormlBack = null;
            this.btnSystemSetting.Size = new System.Drawing.Size(147, 113);
            this.btnSystemSetting.TabIndex = 0;
            this.btnSystemSetting.Text = "系统设置";
            this.btnSystemSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSystemSetting.UseVisualStyleBackColor = false;
            this.btnSystemSetting.Click += new System.EventHandler(this.btnSystemSetting_Click);
            this.btnSystemSetting.MouseEnter += new System.EventHandler(this.btnAboutMe_MouseEnter);
            this.btnSystemSetting.MouseLeave += new System.EventHandler(this.btnAboutMe_MouseLeave);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.上海海洋大学;
            this.skinGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.btnAdvanced_operations);
            this.skinGroupBox1.Controls.Add(this.btnAddRole);
            this.skinGroupBox1.Controls.Add(this.btnAeroWallpaperChanger);
            this.skinGroupBox1.Controls.Add(this.btnAddUser);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(1129, 550);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnAdvanced_operations
            // 
            this.btnAdvanced_operations.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced_operations.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdvanced_operations.DownBack = null;
            this.btnAdvanced_operations.Location = new System.Drawing.Point(443, 173);
            this.btnAdvanced_operations.MouseBack = null;
            this.btnAdvanced_operations.Name = "btnAdvanced_operations";
            this.btnAdvanced_operations.NormlBack = null;
            this.btnAdvanced_operations.Radius = 117;
            this.btnAdvanced_operations.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAdvanced_operations.Size = new System.Drawing.Size(117, 117);
            this.btnAdvanced_operations.TabIndex = 0;
            this.btnAdvanced_operations.Text = "高级操作";
            this.btnAdvanced_operations.UseVisualStyleBackColor = false;
            this.btnAdvanced_operations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdvanced_operations_MouseDown);
            this.btnAdvanced_operations.MouseEnter += new System.EventHandler(this.btnAdvanced_operations_MouseEnter);
            this.btnAdvanced_operations.MouseLeave += new System.EventHandler(this.btnAdvanced_operations_MouseLeave);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRole.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddRole.DownBack = null;
            this.btnAddRole.Location = new System.Drawing.Point(152, 114);
            this.btnAddRole.MouseBack = null;
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.NormlBack = null;
            this.btnAddRole.Radius = 117;
            this.btnAddRole.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAddRole.Size = new System.Drawing.Size(117, 117);
            this.btnAddRole.TabIndex = 0;
            this.btnAddRole.Text = "添加角色";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdvanced_operations_MouseDown);
            this.btnAddRole.MouseEnter += new System.EventHandler(this.btnAdvanced_operations_MouseEnter);
            this.btnAddRole.MouseLeave += new System.EventHandler(this.btnAdvanced_operations_MouseLeave);
            // 
            // btnAeroWallpaperChanger
            // 
            this.btnAeroWallpaperChanger.BackColor = System.Drawing.Color.Transparent;
            this.btnAeroWallpaperChanger.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAeroWallpaperChanger.DownBack = null;
            this.btnAeroWallpaperChanger.Location = new System.Drawing.Point(313, 114);
            this.btnAeroWallpaperChanger.MouseBack = null;
            this.btnAeroWallpaperChanger.Name = "btnAeroWallpaperChanger";
            this.btnAeroWallpaperChanger.NormlBack = null;
            this.btnAeroWallpaperChanger.Radius = 117;
            this.btnAeroWallpaperChanger.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAeroWallpaperChanger.Size = new System.Drawing.Size(117, 117);
            this.btnAeroWallpaperChanger.TabIndex = 0;
            this.btnAeroWallpaperChanger.Text = "更换壁纸";
            this.btnAeroWallpaperChanger.UseVisualStyleBackColor = false;
            this.btnAeroWallpaperChanger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdvanced_operations_MouseDown);
            this.btnAeroWallpaperChanger.MouseEnter += new System.EventHandler(this.btnAdvanced_operations_MouseEnter);
            this.btnAeroWallpaperChanger.MouseLeave += new System.EventHandler(this.btnAdvanced_operations_MouseLeave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddUser.DownBack = null;
            this.btnAddUser.Location = new System.Drawing.Point(29, 20);
            this.btnAddUser.MouseBack = null;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NormlBack = null;
            this.btnAddUser.Radius = 117;
            this.btnAddUser.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnAddUser.Size = new System.Drawing.Size(117, 117);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "添加登录用户";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdvanced_operations_MouseDown);
            this.btnAddUser.MouseEnter += new System.EventHandler(this.btnAdvanced_operations_MouseEnter);
            this.btnAddUser.MouseLeave += new System.EventHandler(this.btnAdvanced_operations_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentStatusManageSystem.UI.Properties.Resources.home;
            this.ClientSize = new System.Drawing.Size(1137, 703);
            this.Controls.Add(this.skinSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Radius = 20;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "currentUser";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinButton btnSystemSetting;
        private CCWin.SkinControl.SkinButton btnScoreManage;
        private CCWin.SkinControl.SkinButton btnCourseManage;
        private CCWin.SkinControl.SkinButton btnStudentManage;
        private CCWin.SkinControl.SkinButton btnClassInfoManage;
        private CCWin.SkinControl.SkinButton btnSpecialitySetting;
        private CCWin.SkinControl.SkinButton btnAboutMe;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinButton btnAddUser;
        private CCWin.SkinControl.SkinButton btnAdvanced_operations;
        private CCWin.SkinControl.SkinButton btnAddRole;
        private CCWin.SkinControl.SkinButton btnAeroWallpaperChanger;
    }
}