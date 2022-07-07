namespace phone_book
{
    partial class reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.new_data_button = new System.Windows.Forms.ToolStripButton();
            this.save_changesButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tel_textBox2 = new System.Windows.Forms.TextBox();
            this.comment_textBox3 = new System.Windows.Forms.TextBox();
            this.lastname_textBox5 = new System.Windows.Forms.TextBox();
            this.firstName_textBox6 = new System.Windows.Forms.TextBox();
            this.email_textBox7 = new System.Windows.Forms.TextBox();
            this.address_textBox8 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_data_button,
            this.save_changesButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(422, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // new_data_button
            // 
            this.new_data_button.Image = ((System.Drawing.Image)(resources.GetObject("new_data_button.Image")));
            this.new_data_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_data_button.Name = "new_data_button";
            this.new_data_button.Size = new System.Drawing.Size(78, 22);
            this.new_data_button.Text = "new data ";
            this.new_data_button.Click += new System.EventHandler(this.new_data_button_Click);
            // 
            // save_changesButton2
            // 
            this.save_changesButton2.Enabled = false;
            this.save_changesButton2.Image = ((System.Drawing.Image)(resources.GetObject("save_changesButton2.Image")));
            this.save_changesButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_changesButton2.Name = "save_changesButton2";
            this.save_changesButton2.Size = new System.Drawing.Size(97, 22);
            this.save_changesButton2.Text = "save changes";
            this.save_changesButton2.Click += new System.EventHandler(this.save_changesButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "last name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "first name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "address";
            // 
            // ID_textBox1
            // 
            this.ID_textBox1.Location = new System.Drawing.Point(97, 21);
            this.ID_textBox1.Name = "ID_textBox1";
            this.ID_textBox1.Size = new System.Drawing.Size(167, 20);
            this.ID_textBox1.TabIndex = 0;
            this.ID_textBox1.TextChanged += new System.EventHandler(this.ID_textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.address_textBox8);
            this.groupBox1.Controls.Add(this.email_textBox7);
            this.groupBox1.Controls.Add(this.firstName_textBox6);
            this.groupBox1.Controls.Add(this.lastname_textBox5);
            this.groupBox1.Controls.Add(this.comment_textBox3);
            this.groupBox1.Controls.Add(this.tel_textBox2);
            this.groupBox1.Controls.Add(this.ID_textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(35, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information";
            // 
            // tel_textBox2
            // 
            this.tel_textBox2.Location = new System.Drawing.Point(97, 111);
            this.tel_textBox2.Name = "tel_textBox2";
            this.tel_textBox2.Size = new System.Drawing.Size(167, 20);
            this.tel_textBox2.TabIndex = 3;
            this.tel_textBox2.TextChanged += new System.EventHandler(this.tel_textBox2_TextChanged);
            // 
            // comment_textBox3
            // 
            this.comment_textBox3.Location = new System.Drawing.Point(97, 201);
            this.comment_textBox3.Name = "comment_textBox3";
            this.comment_textBox3.Size = new System.Drawing.Size(167, 20);
            this.comment_textBox3.TabIndex = 6;
            this.comment_textBox3.TextChanged += new System.EventHandler(this.comment_textBox3_TextChanged);
            // 
            // lastname_textBox5
            // 
            this.lastname_textBox5.Location = new System.Drawing.Point(97, 81);
            this.lastname_textBox5.Name = "lastname_textBox5";
            this.lastname_textBox5.Size = new System.Drawing.Size(167, 20);
            this.lastname_textBox5.TabIndex = 2;
            this.lastname_textBox5.TextChanged += new System.EventHandler(this.lastname_textBox5_TextChanged);
            // 
            // firstName_textBox6
            // 
            this.firstName_textBox6.Location = new System.Drawing.Point(97, 51);
            this.firstName_textBox6.Name = "firstName_textBox6";
            this.firstName_textBox6.Size = new System.Drawing.Size(167, 20);
            this.firstName_textBox6.TabIndex = 1;
            this.firstName_textBox6.TextChanged += new System.EventHandler(this.firstName_textBox6_TextChanged);
            // 
            // email_textBox7
            // 
            this.email_textBox7.Location = new System.Drawing.Point(97, 141);
            this.email_textBox7.Name = "email_textBox7";
            this.email_textBox7.Size = new System.Drawing.Size(167, 20);
            this.email_textBox7.TabIndex = 4;
            this.email_textBox7.TextChanged += new System.EventHandler(this.email_textBox7_TextChanged);
            // 
            // address_textBox8
            // 
            this.address_textBox8.Location = new System.Drawing.Point(97, 171);
            this.address_textBox8.Name = "address_textBox8";
            this.address_textBox8.Size = new System.Drawing.Size(167, 20);
            this.address_textBox8.TabIndex = 5;
            this.address_textBox8.TextChanged += new System.EventHandler(this.address_textBox8_TextChanged);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(422, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register new";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton new_data_button;
        private System.Windows.Forms.ToolStripButton save_changesButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox address_textBox8;
        private System.Windows.Forms.TextBox email_textBox7;
        private System.Windows.Forms.TextBox firstName_textBox6;
        private System.Windows.Forms.TextBox lastname_textBox5;
        private System.Windows.Forms.TextBox comment_textBox3;
        private System.Windows.Forms.TextBox tel_textBox2;
    }
}