namespace StudentStatusManageSystem.UI
{
    partial class frmAdvancedOperations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvancedOperations));
            this.dgvUser = new CCWin.SkinControl.SkinDataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btnUserRecycleBin = new CCWin.SkinControl.SkinButton();
            this.txtSearchUser2 = new System.Windows.Forms.TextBox();
            this.txtSearchUser1 = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnSearchUser2 = new System.Windows.Forms.Button();
            this.btnSearchUser1 = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.btnRoleRecycleBin = new CCWin.SkinControl.SkinButton();
            this.txtSearchRole2 = new System.Windows.Forms.TextBox();
            this.txtSearchRole1 = new System.Windows.Forms.TextBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnSearchRole1 = new System.Windows.Forms.Button();
            this.btnSearchRole2 = new System.Windows.Forms.Button();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.btnRestoreUser = new CCWin.SkinControl.SkinButton();
            this.btnRestoreRole = new CCWin.SkinControl.SkinButton();
            this.Role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.System_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_manage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_submitter_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_delFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUser.ColumnFont = null;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvUser.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvUser.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(811, 340);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.TitleBack = null;
            this.dgvUser.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvUser.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 683);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvUser);
            this.splitContainer2.Size = new System.Drawing.Size(1150, 340);
            this.splitContainer2.SplitterDistance = 335;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestoreUser);
            this.groupBox1.Controls.Add(this.skinButton3);
            this.groupBox1.Controls.Add(this.skinButton1);
            this.groupBox1.Controls.Add(this.btnUserRecycleBin);
            this.groupBox1.Controls.Add(this.txtSearchUser2);
            this.groupBox1.Controls.Add(this.txtSearchUser1);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.Controls.Add(this.btnSearchUser2);
            this.groupBox1.Controls.Add(this.btnSearchUser1);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录用户操作";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(165, 301);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 5;
            this.skinButton3.Text = "清空回收站";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Visible = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(6, 301);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(68, 23);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "退出回收站";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Visible = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // btnUserRecycleBin
            // 
            this.btnUserRecycleBin.BackColor = System.Drawing.Color.Transparent;
            this.btnUserRecycleBin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnUserRecycleBin.DownBack = null;
            this.btnUserRecycleBin.Location = new System.Drawing.Point(248, 301);
            this.btnUserRecycleBin.MouseBack = null;
            this.btnUserRecycleBin.Name = "btnUserRecycleBin";
            this.btnUserRecycleBin.NormlBack = null;
            this.btnUserRecycleBin.Size = new System.Drawing.Size(75, 23);
            this.btnUserRecycleBin.TabIndex = 3;
            this.btnUserRecycleBin.Text = "回收站";
            this.btnUserRecycleBin.UseVisualStyleBackColor = false;
            this.btnUserRecycleBin.Click += new System.EventHandler(this.btnUserRecycleBin_Click);
            // 
            // txtSearchUser2
            // 
            this.txtSearchUser2.Font = new System.Drawing.Font("华文中宋", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchUser2.ForeColor = System.Drawing.Color.Red;
            this.txtSearchUser2.Location = new System.Drawing.Point(140, 200);
            this.txtSearchUser2.Multiline = true;
            this.txtSearchUser2.Name = "txtSearchUser2";
            this.txtSearchUser2.Size = new System.Drawing.Size(169, 33);
            this.txtSearchUser2.TabIndex = 2;
            this.txtSearchUser2.Text = "根据用户名字查找";
            this.txtSearchUser2.Click += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchUser2.TextChanged += new System.EventHandler(this.txtSearchUser2_TextChanged);
            this.txtSearchUser2.Enter += new System.EventHandler(this.txtSearchUser2_Enter);
            // 
            // txtSearchUser1
            // 
            this.txtSearchUser1.Font = new System.Drawing.Font("华文中宋", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchUser1.ForeColor = System.Drawing.Color.Red;
            this.txtSearchUser1.Location = new System.Drawing.Point(140, 146);
            this.txtSearchUser1.MaxLength = 6;
            this.txtSearchUser1.Multiline = true;
            this.txtSearchUser1.Name = "txtSearchUser1";
            this.txtSearchUser1.Size = new System.Drawing.Size(169, 33);
            this.txtSearchUser1.TabIndex = 2;
            this.txtSearchUser1.Text = "根据用户编号查找";
            this.txtSearchUser1.Click += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchUser1.TextChanged += new System.EventHandler(this.txtSearchUser1_TextChanged);
            this.txtSearchUser1.Enter += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchUser1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUser1_KeyPress);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(25, 86);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(87, 28);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "修改选中";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnSearchUser2
            // 
            this.btnSearchUser2.Location = new System.Drawing.Point(25, 201);
            this.btnSearchUser2.Name = "btnSearchUser2";
            this.btnSearchUser2.Size = new System.Drawing.Size(87, 28);
            this.btnSearchUser2.TabIndex = 1;
            this.btnSearchUser2.Text = "查找";
            this.btnSearchUser2.UseVisualStyleBackColor = true;
            this.btnSearchUser2.Click += new System.EventHandler(this.btnSearchUser2_Click);
            // 
            // btnSearchUser1
            // 
            this.btnSearchUser1.Location = new System.Drawing.Point(25, 147);
            this.btnSearchUser1.Name = "btnSearchUser1";
            this.btnSearchUser1.Size = new System.Drawing.Size(87, 28);
            this.btnSearchUser1.TabIndex = 1;
            this.btnSearchUser1.Text = "查找";
            this.btnSearchUser1.UseVisualStyleBackColor = true;
            this.btnSearchUser1.Click += new System.EventHandler(this.btnSearchUser1_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(169, 86);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(87, 28);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "删除选中";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvRole);
            this.splitContainer3.Size = new System.Drawing.Size(1150, 339);
            this.splitContainer3.SplitterDistance = 338;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestoreRole);
            this.groupBox2.Controls.Add(this.skinButton4);
            this.groupBox2.Controls.Add(this.skinButton2);
            this.groupBox2.Controls.Add(this.btnRoleRecycleBin);
            this.groupBox2.Controls.Add(this.txtSearchRole2);
            this.groupBox2.Controls.Add(this.txtSearchRole1);
            this.groupBox2.Controls.Add(this.btnDeleteRole);
            this.groupBox2.Controls.Add(this.btnUpdateRole);
            this.groupBox2.Controls.Add(this.btnSearchRole1);
            this.groupBox2.Controls.Add(this.btnSearchRole2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 339);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色操作";
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(165, 267);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(75, 23);
            this.skinButton4.TabIndex = 5;
            this.skinButton4.Text = "清空回收站";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Visible = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(6, 267);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(68, 23);
            this.skinButton2.TabIndex = 4;
            this.skinButton2.Text = "退出回收站";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Visible = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // btnRoleRecycleBin
            // 
            this.btnRoleRecycleBin.BackColor = System.Drawing.Color.Transparent;
            this.btnRoleRecycleBin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRoleRecycleBin.DownBack = null;
            this.btnRoleRecycleBin.Location = new System.Drawing.Point(248, 267);
            this.btnRoleRecycleBin.MouseBack = null;
            this.btnRoleRecycleBin.Name = "btnRoleRecycleBin";
            this.btnRoleRecycleBin.NormlBack = null;
            this.btnRoleRecycleBin.Size = new System.Drawing.Size(75, 23);
            this.btnRoleRecycleBin.TabIndex = 3;
            this.btnRoleRecycleBin.Text = "回收站";
            this.btnRoleRecycleBin.UseVisualStyleBackColor = false;
            this.btnRoleRecycleBin.Click += new System.EventHandler(this.btnRoleRecycleBin_Click);
            // 
            // txtSearchRole2
            // 
            this.txtSearchRole2.Font = new System.Drawing.Font("华文中宋", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchRole2.ForeColor = System.Drawing.Color.Red;
            this.txtSearchRole2.Location = new System.Drawing.Point(140, 199);
            this.txtSearchRole2.Multiline = true;
            this.txtSearchRole2.Name = "txtSearchRole2";
            this.txtSearchRole2.Size = new System.Drawing.Size(169, 33);
            this.txtSearchRole2.TabIndex = 2;
            this.txtSearchRole2.Text = "根据角色名字查找";
            this.txtSearchRole2.Click += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchRole2.TextChanged += new System.EventHandler(this.txtSearchRole2_TextChanged);
            this.txtSearchRole2.Enter += new System.EventHandler(this.txtSearchUser2_Enter);
            // 
            // txtSearchRole1
            // 
            this.txtSearchRole1.Font = new System.Drawing.Font("华文中宋", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchRole1.ForeColor = System.Drawing.Color.Red;
            this.txtSearchRole1.Location = new System.Drawing.Point(140, 145);
            this.txtSearchRole1.MaxLength = 6;
            this.txtSearchRole1.Multiline = true;
            this.txtSearchRole1.Name = "txtSearchRole1";
            this.txtSearchRole1.Size = new System.Drawing.Size(169, 33);
            this.txtSearchRole1.TabIndex = 2;
            this.txtSearchRole1.Text = "根据角色编号查找";
            this.txtSearchRole1.Click += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchRole1.TextChanged += new System.EventHandler(this.txtSearchRole1_TextChanged);
            this.txtSearchRole1.Enter += new System.EventHandler(this.txtSearchUser2_Enter);
            this.txtSearchRole1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUser1_KeyPress);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(169, 85);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(87, 28);
            this.btnDeleteRole.TabIndex = 1;
            this.btnDeleteRole.Text = "删除选中";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(25, 85);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(87, 28);
            this.btnUpdateRole.TabIndex = 1;
            this.btnUpdateRole.Text = "修改选中";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnSearchRole1
            // 
            this.btnSearchRole1.Location = new System.Drawing.Point(25, 146);
            this.btnSearchRole1.Name = "btnSearchRole1";
            this.btnSearchRole1.Size = new System.Drawing.Size(87, 28);
            this.btnSearchRole1.TabIndex = 1;
            this.btnSearchRole1.Text = "查找";
            this.btnSearchRole1.UseVisualStyleBackColor = true;
            this.btnSearchRole1.Click += new System.EventHandler(this.btnSearchRole1_Click);
            // 
            // btnSearchRole2
            // 
            this.btnSearchRole2.Location = new System.Drawing.Point(25, 200);
            this.btnSearchRole2.Name = "btnSearchRole2";
            this.btnSearchRole2.Size = new System.Drawing.Size(87, 28);
            this.btnSearchRole2.TabIndex = 1;
            this.btnSearchRole2.Text = "查找";
            this.btnSearchRole2.UseVisualStyleBackColor = true;
            this.btnSearchRole2.Click += new System.EventHandler(this.btnSearchRole2_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRole.BackgroundColor = System.Drawing.Color.White;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Role_id,
            this.Role_name,
            this.Speciality_manage,
            this.Class_manage,
            this.Course_manage,
            this.System_manage,
            this.Score_manage,
            this.Student_manage,
            this.Role_remark,
            this.Role_submitter_id,
            this.Role_delFlag});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.MultiSelect = false;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.RowTemplate.Height = 23;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(808, 339);
            this.dgvRole.TabIndex = 0;
            // 
            // btnRestoreUser
            // 
            this.btnRestoreUser.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreUser.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestoreUser.DownBack = null;
            this.btnRestoreUser.Location = new System.Drawing.Point(82, 301);
            this.btnRestoreUser.MouseBack = null;
            this.btnRestoreUser.Name = "btnRestoreUser";
            this.btnRestoreUser.NormlBack = null;
            this.btnRestoreUser.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreUser.TabIndex = 6;
            this.btnRestoreUser.Text = "还原选中项";
            this.btnRestoreUser.UseVisualStyleBackColor = false;
            this.btnRestoreUser.Visible = false;
            this.btnRestoreUser.Click += new System.EventHandler(this.btnRestoreUser_Click);
            // 
            // btnRestoreRole
            // 
            this.btnRestoreRole.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreRole.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestoreRole.DownBack = null;
            this.btnRestoreRole.Location = new System.Drawing.Point(82, 267);
            this.btnRestoreRole.MouseBack = null;
            this.btnRestoreRole.Name = "btnRestoreRole";
            this.btnRestoreRole.NormlBack = null;
            this.btnRestoreRole.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreRole.TabIndex = 6;
            this.btnRestoreRole.Text = "还原选中项";
            this.btnRestoreRole.UseVisualStyleBackColor = false;
            this.btnRestoreRole.Visible = false;
            this.btnRestoreRole.Click += new System.EventHandler(this.btnRestoreRole_Click);
            // 
            // Role_id
            // 
            this.Role_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Role_id.DataPropertyName = "Id";
            this.Role_id.Frozen = true;
            this.Role_id.HeaderText = "编号";
            this.Role_id.Name = "Role_id";
            this.Role_id.ReadOnly = true;
            this.Role_id.Width = 77;
            // 
            // Role_name
            // 
            this.Role_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Role_name.DataPropertyName = "Name";
            this.Role_name.Frozen = true;
            this.Role_name.HeaderText = "角色名称";
            this.Role_name.Name = "Role_name";
            this.Role_name.ReadOnly = true;
            this.Role_name.Width = 76;
            // 
            // Speciality_manage
            // 
            this.Speciality_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Speciality_manage.DataPropertyName = "Speciality_manage";
            this.Speciality_manage.Frozen = true;
            this.Speciality_manage.HeaderText = "专业管理";
            this.Speciality_manage.Name = "Speciality_manage";
            this.Speciality_manage.ReadOnly = true;
            this.Speciality_manage.Width = 77;
            // 
            // Class_manage
            // 
            this.Class_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Class_manage.DataPropertyName = "Class_manage";
            this.Class_manage.Frozen = true;
            this.Class_manage.HeaderText = "班级管理";
            this.Class_manage.Name = "Class_manage";
            this.Class_manage.ReadOnly = true;
            this.Class_manage.Width = 76;
            // 
            // Course_manage
            // 
            this.Course_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Course_manage.DataPropertyName = "Course_manage";
            this.Course_manage.Frozen = true;
            this.Course_manage.HeaderText = "课程管理";
            this.Course_manage.Name = "Course_manage";
            this.Course_manage.ReadOnly = true;
            this.Course_manage.Width = 77;
            // 
            // System_manage
            // 
            this.System_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.System_manage.DataPropertyName = "System_manage";
            this.System_manage.Frozen = true;
            this.System_manage.HeaderText = "系统管理";
            this.System_manage.Name = "System_manage";
            this.System_manage.ReadOnly = true;
            this.System_manage.Width = 76;
            // 
            // Score_manage
            // 
            this.Score_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Score_manage.DataPropertyName = "Score_manage";
            this.Score_manage.Frozen = true;
            this.Score_manage.HeaderText = "分数管理";
            this.Score_manage.Name = "Score_manage";
            this.Score_manage.ReadOnly = true;
            this.Score_manage.Width = 77;
            // 
            // Student_manage
            // 
            this.Student_manage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Student_manage.DataPropertyName = "Student_manage";
            this.Student_manage.Frozen = true;
            this.Student_manage.HeaderText = "学生管理";
            this.Student_manage.Name = "Student_manage";
            this.Student_manage.ReadOnly = true;
            this.Student_manage.Width = 76;
            // 
            // Role_remark
            // 
            this.Role_remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Role_remark.DataPropertyName = "Remark";
            this.Role_remark.Frozen = true;
            this.Role_remark.HeaderText = "备注";
            this.Role_remark.Name = "Role_remark";
            this.Role_remark.ReadOnly = true;
            this.Role_remark.Width = 77;
            // 
            // Role_submitter_id
            // 
            this.Role_submitter_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Role_submitter_id.DataPropertyName = "Submitter_id";
            this.Role_submitter_id.Frozen = true;
            this.Role_submitter_id.HeaderText = "提交人编号";
            this.Role_submitter_id.Name = "Role_submitter_id";
            this.Role_submitter_id.ReadOnly = true;
            this.Role_submitter_id.Width = 76;
            // 
            // Role_delFlag
            // 
            this.Role_delFlag.HeaderText = "删除标识";
            this.Role_delFlag.Name = "Role_delFlag";
            this.Role_delFlag.ReadOnly = true;
            this.Role_delFlag.Visible = false;
            // 
            // frmAdvancedOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1150, 683);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdvancedOperations";
            this.Text = "高级操作";
            this.Load += new System.EventHandler(this.frmAdvancedOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TextBox txtSearchUser1;
        private System.Windows.Forms.Button btnSearchUser1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtSearchUser2;
        private System.Windows.Forms.Button btnSearchUser2;
        private System.Windows.Forms.TextBox txtSearchRole2;
        private System.Windows.Forms.TextBox txtSearchRole1;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnSearchRole1;
        private System.Windows.Forms.Button btnSearchRole2;
        private CCWin.SkinControl.SkinButton btnUserRecycleBin;
        private CCWin.SkinControl.SkinButton btnRoleRecycleBin;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton btnRestoreUser;
        private CCWin.SkinControl.SkinButton btnRestoreRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn System_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_submitter_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_delFlag;
    }
}