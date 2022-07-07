namespace phone_book
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.search_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Cal_Button3 = new System.Windows.Forms.ToolStripButton();
            this.about_US_toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.exit_toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.process1 = new System.Diagnostics.Process();
            this.process2 = new System.Diagnostics.Process();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.search_toolStripButton2,
            this.Cal_Button3,
            this.about_US_toolStripButton4,
            this.exit_toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 112);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(196, 109);
            this.toolStripButton1.Text = "data entry";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // search_toolStripButton2
            // 
            this.search_toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("search_toolStripButton2.Image")));
            this.search_toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.search_toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_toolStripButton2.Name = "search_toolStripButton2";
            this.search_toolStripButton2.Size = new System.Drawing.Size(155, 109);
            this.search_toolStripButton2.Text = "search ";
            this.search_toolStripButton2.Click += new System.EventHandler(this.search_toolStripButton2_Click);
            // 
            // Cal_Button3
            // 
            this.Cal_Button3.Image = ((System.Drawing.Image)(resources.GetObject("Cal_Button3.Image")));
            this.Cal_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cal_Button3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cal_Button3.Name = "Cal_Button3";
            this.Cal_Button3.Size = new System.Drawing.Size(190, 109);
            this.Cal_Button3.Text = "calculator";
            this.Cal_Button3.Click += new System.EventHandler(this.Cal_Button3_Click);
            // 
            // about_US_toolStripButton4
            // 
            this.about_US_toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("about_US_toolStripButton4.Image")));
            this.about_US_toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_US_toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_US_toolStripButton4.Name = "about_US_toolStripButton4";
            this.about_US_toolStripButton4.Size = new System.Drawing.Size(177, 109);
            this.about_US_toolStripButton4.Text = "about us";
            this.about_US_toolStripButton4.Click += new System.EventHandler(this.about_US_toolStripButton4_Click);
            // 
            // exit_toolStripButton5
            // 
            this.exit_toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("exit_toolStripButton5.Image")));
            this.exit_toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exit_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_toolStripButton5.Name = "exit_toolStripButton5";
            this.exit_toolStripButton5.Size = new System.Drawing.Size(112, 109);
            this.exit_toolStripButton5.Text = "exit";
            this.exit_toolStripButton5.Click += new System.EventHandler(this.exit_toolStripButton5_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // process2
            // 
            this.process2.StartInfo.Domain = "";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton search_toolStripButton2;
        private System.Windows.Forms.ToolStripButton Cal_Button3;
        private System.Windows.Forms.ToolStripButton about_US_toolStripButton4;
        private System.Windows.Forms.ToolStripButton exit_toolStripButton5;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
    }
}

