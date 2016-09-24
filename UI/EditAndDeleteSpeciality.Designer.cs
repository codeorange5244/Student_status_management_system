namespace StudentStatusManageSystem.UI
{
    partial class EditAndDeleteSpeciality
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dgvSepciality = new CCWin.SkinControl.SkinDataGridView();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSpeciality = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepciality)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.textBox1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton3);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton2);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinButton1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinLabel1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.cbSpeciality);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.dgvSepciality);
            this.skinSplitContainer1.Size = new System.Drawing.Size(813, 523);
            this.skinSplitContainer1.SplitterDistance = 149;
            this.skinSplitContainer1.SplitterWidth = 1;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // dgvSepciality
            // 
            this.dgvSepciality.AllowUserToAddRows = false;
            this.dgvSepciality.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvSepciality.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSepciality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSepciality.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSepciality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSepciality.ColumnFont = null;
            this.dgvSepciality.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSepciality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSepciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepciality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecialityName,
            this.SpecialityRemark,
            this.SubmitterId,
            this.SubmitDatetime});
            this.dgvSepciality.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSepciality.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSepciality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSepciality.EnableHeadersVisualStyles = false;
            this.dgvSepciality.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSepciality.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvSepciality.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSepciality.Location = new System.Drawing.Point(0, 0);
            this.dgvSepciality.Name = "dgvSepciality";
            this.dgvSepciality.ReadOnly = true;
            this.dgvSepciality.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSepciality.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSepciality.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSepciality.RowTemplate.Height = 23;
            this.dgvSepciality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSepciality.Size = new System.Drawing.Size(813, 373);
            this.dgvSepciality.TabIndex = 0;
            this.dgvSepciality.TitleBack = null;
            this.dgvSepciality.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvSepciality.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // SpecialityName
            // 
            this.SpecialityName.HeaderText = "专业名称";
            this.SpecialityName.Name = "SpecialityName";
            this.SpecialityName.ReadOnly = true;
            // 
            // SpecialityRemark
            // 
            this.SpecialityRemark.HeaderText = "备注";
            this.SpecialityRemark.Name = "SpecialityRemark";
            this.SpecialityRemark.ReadOnly = true;
            // 
            // SubmitterId
            // 
            this.SubmitterId.HeaderText = "提交人编号";
            this.SubmitterId.Name = "SubmitterId";
            this.SubmitterId.ReadOnly = true;
            // 
            // SubmitDatetime
            // 
            this.SubmitDatetime.HeaderText = "提交时间";
            this.SubmitDatetime.Name = "SubmitDatetime";
            this.SubmitDatetime.ReadOnly = true;
            // 
            // cbSpeciality
            // 
            this.cbSpeciality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpeciality.Font = new System.Drawing.Font("宋体", 10F);
            this.cbSpeciality.FormattingEnabled = true;
            this.cbSpeciality.Location = new System.Drawing.Point(116, 31);
            this.cbSpeciality.Name = "cbSpeciality";
            this.cbSpeciality.Size = new System.Drawing.Size(159, 24);
            this.cbSpeciality.TabIndex = 0;
            this.cbSpeciality.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(64, 35);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "学院";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(391, 33);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "搜索";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 21);
            this.textBox1.TabIndex = 3;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(249, 97);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(101, 35);
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "修改选中";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(383, 97);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(101, 35);
            this.skinButton3.TabIndex = 2;
            this.skinButton3.Text = "删除选中";
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // EditAndDeleteSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(813, 523);
            this.Controls.Add(this.skinSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditAndDeleteSpeciality";
            this.Text = "查看专业";
            this.Load += new System.EventHandler(this.EditAndDeleteSpeciality_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.PerformLayout();
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepciality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinDataGridView dgvSepciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitDatetime;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox cbSpeciality;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}