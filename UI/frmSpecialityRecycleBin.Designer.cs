namespace StudentStatusManageSystem.UI
{
    partial class frmSpecialityRecycleBin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSepciality = new CCWin.SkinControl.SkinDataGridView();
            this.specialityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepciality)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSepciality
            // 
            this.dgvSepciality.AllowUserToAddRows = false;
            this.dgvSepciality.AllowUserToDeleteRows = false;
            this.dgvSepciality.AllowUserToOrderColumns = true;
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
            this.specialityId,
            this.SpecialityName,
            this.collegeName,
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
            this.dgvSepciality.Size = new System.Drawing.Size(841, 572);
            this.dgvSepciality.TabIndex = 1;
            this.dgvSepciality.TitleBack = null;
            this.dgvSepciality.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvSepciality.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvSepciality.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepciality_CellDoubleClick);
            // 
            // specialityId
            // 
            this.specialityId.DataPropertyName = "Id";
            this.specialityId.HeaderText = "专业Id";
            this.specialityId.Name = "specialityId";
            this.specialityId.ReadOnly = true;
            this.specialityId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.specialityId.Visible = false;
            // 
            // SpecialityName
            // 
            this.SpecialityName.DataPropertyName = "Name";
            this.SpecialityName.HeaderText = "专业名称";
            this.SpecialityName.Name = "SpecialityName";
            this.SpecialityName.ReadOnly = true;
            // 
            // collegeName
            // 
            this.collegeName.DataPropertyName = "Model_college_Name";
            this.collegeName.HeaderText = "所属学院";
            this.collegeName.Name = "collegeName";
            this.collegeName.ReadOnly = true;
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
            this.SubmitterId.HeaderText = "删除人编号";
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
            // frmSpecialityRecycleBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(841, 572);
            this.Controls.Add(this.dgvSepciality);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSpecialityRecycleBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业回收站（双击恢复）";
            this.Load += new System.EventHandler(this.frmSpecialityRecycleBin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepciality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvSepciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitDatetime;
    }
}