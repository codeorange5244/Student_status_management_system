namespace StudentStatusManageSystem.UI
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.tbClassInfo = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tbClassInfo
            // 
            this.tbClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClassInfo.ItemSize = new System.Drawing.Size(80, 20);
            this.tbClassInfo.Location = new System.Drawing.Point(4, 28);
            this.tbClassInfo.Name = "tbClassInfo";
            this.tbClassInfo.SelectedIndex = 0;
            this.tbClassInfo.Size = new System.Drawing.Size(936, 618);
            this.tbClassInfo.TabIndex = 0;
            this.tbClassInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbClassInfo_Selecting);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 650);
            this.Controls.Add(this.tbClassInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudent";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbClassInfo;
    }
}