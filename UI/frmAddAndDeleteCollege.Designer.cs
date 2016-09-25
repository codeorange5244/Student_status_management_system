namespace StudentStatusManageSystem.UI
{
    partial class frmAddAndDeleteCollege
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAddCollege = new CCWin.SkinControl.SkinButton();
            this.btnDeleteCollege = new CCWin.SkinControl.SkinButton();
            this.dgvCollege = new CCWin.SkinControl.SkinDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollege)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvCollege);
            this.splitContainer1.Size = new System.Drawing.Size(619, 450);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnAddCollege);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteCollege);
            this.splitContainer2.Size = new System.Drawing.Size(619, 80);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAddCollege
            // 
            this.btnAddCollege.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCollege.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddCollege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCollege.DownBack = null;
            this.btnAddCollege.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnAddCollege.ForeColor = System.Drawing.Color.White;
            this.btnAddCollege.Location = new System.Drawing.Point(0, 0);
            this.btnAddCollege.MouseBack = null;
            this.btnAddCollege.Name = "btnAddCollege";
            this.btnAddCollege.NormlBack = null;
            this.btnAddCollege.Size = new System.Drawing.Size(285, 80);
            this.btnAddCollege.TabIndex = 0;
            this.btnAddCollege.Text = "新开设学院";
            this.btnAddCollege.UseVisualStyleBackColor = false;
            this.btnAddCollege.Click += new System.EventHandler(this.btnAddCollege_Click);
            // 
            // btnDeleteCollege
            // 
            this.btnDeleteCollege.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCollege.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDeleteCollege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCollege.DownBack = null;
            this.btnDeleteCollege.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnDeleteCollege.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCollege.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteCollege.MouseBack = null;
            this.btnDeleteCollege.Name = "btnDeleteCollege";
            this.btnDeleteCollege.NormlBack = null;
            this.btnDeleteCollege.Size = new System.Drawing.Size(333, 80);
            this.btnDeleteCollege.TabIndex = 0;
            this.btnDeleteCollege.Text = "删除选中学院";
            this.btnDeleteCollege.UseVisualStyleBackColor = false;
            this.btnDeleteCollege.Click += new System.EventHandler(this.btnDeleteCollege_Click);
            // 
            // dgvCollege
            // 
            this.dgvCollege.AllowUserToAddRows = false;
            this.dgvCollege.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvCollege.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCollege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollege.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCollege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollege.ColumnFont = null;
            this.dgvCollege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCollege.ColumnHeadersHeight = 30;
            this.dgvCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCollege.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCollege.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCollege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollege.EnableHeadersVisualStyles = false;
            this.dgvCollege.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCollege.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCollege.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCollege.Location = new System.Drawing.Point(0, 0);
            this.dgvCollege.Name = "dgvCollege";
            this.dgvCollege.ReadOnly = true;
            this.dgvCollege.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCollege.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCollege.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCollege.RowTemplate.Height = 23;
            this.dgvCollege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollege.Size = new System.Drawing.Size(619, 369);
            this.dgvCollege.TabIndex = 0;
            this.dgvCollege.TitleBack = null;
            this.dgvCollege.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvCollege.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // frmAddAndDeleteCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(204)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddAndDeleteCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看学院";
            this.Load += new System.EventHandler(this.frmAddAndDeleteCollege_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CCWin.SkinControl.SkinButton btnAddCollege;
        private CCWin.SkinControl.SkinButton btnDeleteCollege;
        private CCWin.SkinControl.SkinDataGridView dgvCollege;
    }
}