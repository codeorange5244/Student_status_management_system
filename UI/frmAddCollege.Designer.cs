namespace StudentStatusManageSystem.UI
{
    partial class frmAddCollege
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtAddCollegeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(220, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 24);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtAddCollegeName
            // 
            this.txtAddCollegeName.Location = new System.Drawing.Point(12, 11);
            this.txtAddCollegeName.Name = "txtAddCollegeName";
            this.txtAddCollegeName.Size = new System.Drawing.Size(181, 21);
            this.txtAddCollegeName.TabIndex = 3;
            // 
            // frmAddCollege
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 50);
            this.Controls.Add(this.txtAddCollegeName);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新开设学院名";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddCollege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtAddCollegeName;
    }
}