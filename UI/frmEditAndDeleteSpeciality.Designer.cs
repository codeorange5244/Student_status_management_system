namespace StudentStatusManageSystem.UI
{
    partial class frmEditAndDeleteSpeciality
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchSpeciality = new System.Windows.Forms.TextBox();
            this.btnDeleteSpeciality = new CCWin.SkinControl.SkinButton();
            this.btnEditSpeciality = new CCWin.SkinControl.SkinButton();
            this.btnSearchSpeciality = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.cbCollege = new CCWin.SkinControl.SkinComboBox();
            this.dgvSepciality = new CCWin.SkinControl.SkinDataGridView();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.skinSplitContainer1.Panel1.Controls.Add(this.label1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.txtSearchSpeciality);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnDeleteSpeciality);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnEditSpeciality);
            this.skinSplitContainer1.Panel1.Controls.Add(this.btnSearchSpeciality);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinLabel1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.cbCollege);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.dgvSepciality);
            this.skinSplitContainer1.Size = new System.Drawing.Size(813, 523);
            this.skinSplitContainer1.SplitterDistance = 149;
            this.skinSplitContainer1.SplitterWidth = 1;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "根据专业名称查找";
            // 
            // txtSearchSpeciality
            // 
            this.txtSearchSpeciality.Location = new System.Drawing.Point(487, 35);
            this.txtSearchSpeciality.Name = "txtSearchSpeciality";
            this.txtSearchSpeciality.Size = new System.Drawing.Size(126, 21);
            this.txtSearchSpeciality.TabIndex = 3;
            // 
            // btnDeleteSpeciality
            // 
            this.btnDeleteSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSpeciality.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDeleteSpeciality.DownBack = null;
            this.btnDeleteSpeciality.Location = new System.Drawing.Point(383, 97);
            this.btnDeleteSpeciality.MouseBack = null;
            this.btnDeleteSpeciality.Name = "btnDeleteSpeciality";
            this.btnDeleteSpeciality.NormlBack = null;
            this.btnDeleteSpeciality.Size = new System.Drawing.Size(101, 35);
            this.btnDeleteSpeciality.TabIndex = 2;
            this.btnDeleteSpeciality.Text = "删除选中";
            this.btnDeleteSpeciality.UseVisualStyleBackColor = false;
            // 
            // btnEditSpeciality
            // 
            this.btnEditSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSpeciality.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnEditSpeciality.DownBack = null;
            this.btnEditSpeciality.Location = new System.Drawing.Point(249, 97);
            this.btnEditSpeciality.MouseBack = null;
            this.btnEditSpeciality.Name = "btnEditSpeciality";
            this.btnEditSpeciality.NormlBack = null;
            this.btnEditSpeciality.Size = new System.Drawing.Size(101, 35);
            this.btnEditSpeciality.TabIndex = 2;
            this.btnEditSpeciality.Text = "修改选中";
            this.btnEditSpeciality.UseVisualStyleBackColor = false;
            this.btnEditSpeciality.Click += new System.EventHandler(this.btnEditSpeciality_Click);
            // 
            // btnSearchSpeciality
            // 
            this.btnSearchSpeciality.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchSpeciality.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearchSpeciality.DownBack = null;
            this.btnSearchSpeciality.Location = new System.Drawing.Point(397, 35);
            this.btnSearchSpeciality.MouseBack = null;
            this.btnSearchSpeciality.Name = "btnSearchSpeciality";
            this.btnSearchSpeciality.NormlBack = null;
            this.btnSearchSpeciality.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpeciality.TabIndex = 2;
            this.btnSearchSpeciality.Text = "搜索";
            this.btnSearchSpeciality.UseVisualStyleBackColor = false;
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
            // cbCollege
            // 
            this.cbCollege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollege.Font = new System.Drawing.Font("宋体", 10F);
            this.cbCollege.FormattingEnabled = true;
            this.cbCollege.Location = new System.Drawing.Point(116, 31);
            this.cbCollege.Name = "cbCollege";
            this.cbCollege.Size = new System.Drawing.Size(159, 24);
            this.cbCollege.TabIndex = 0;
            this.cbCollege.WaterText = "";
            this.cbCollege.SelectedIndexChanged += new System.EventHandler(this.cbSpeciality_SelectedIndexChanged);
            // 
            // dgvSepciality
            // 
            this.dgvSepciality.AllowUserToAddRows = false;
            this.dgvSepciality.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvSepciality.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSepciality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSepciality.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSepciality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSepciality.ColumnFont = null;
            this.dgvSepciality.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSepciality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSepciality.ColumnHeadersHeight = 26;
            this.dgvSepciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSepciality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecialityName,
            this.SpecialityRemark,
            this.SubmitterId,
            this.SubmitDatetime});
            this.dgvSepciality.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSepciality.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSepciality.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            this.SpecialityName.DataPropertyName = "Name";
            this.SpecialityName.HeaderText = "专业名称";
            this.SpecialityName.Name = "SpecialityName";
            this.SpecialityName.ReadOnly = true;
            // 
            // SpecialityRemark
            // 
            this.SpecialityRemark.DataPropertyName = "Remark";
            this.SpecialityRemark.HeaderText = "备注";
            this.SpecialityRemark.Name = "SpecialityRemark";
            this.SpecialityRemark.ReadOnly = true;
            // 
            // SubmitterId
            // 
            this.SubmitterId.DataPropertyName = "Submitter_id";
            this.SubmitterId.HeaderText = "提交人编号";
            this.SubmitterId.Name = "SubmitterId";
            this.SubmitterId.ReadOnly = true;
            // 
            // SubmitDatetime
            // 
            this.SubmitDatetime.DataPropertyName = "Submit_datetime";
            this.SubmitDatetime.HeaderText = "提交时间";
            this.SubmitDatetime.Name = "SubmitDatetime";
            this.SubmitDatetime.ReadOnly = true;
            // 
            // frmEditAndDeleteSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(813, 523);
            this.Controls.Add(this.skinSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditAndDeleteSpeciality";
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
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox cbCollege;
        private System.Windows.Forms.TextBox txtSearchSpeciality;
        private CCWin.SkinControl.SkinButton btnDeleteSpeciality;
        private CCWin.SkinControl.SkinButton btnEditSpeciality;
        private CCWin.SkinControl.SkinButton btnSearchSpeciality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitDatetime;
    }
}