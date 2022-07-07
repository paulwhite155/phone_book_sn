using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            reg reg1 = new reg();
            reg1.MdiParent = this;
            reg1.Show();

        }

        private void search_toolStripButton2_Click(object sender, EventArgs e)
        {
            search search1 = new search();
            search1.MdiParent = this;
            search1.Show();
        }

        private void about_US_toolStripButton4_Click(object sender, EventArgs e)
        {
            aboutus aboutus = new aboutus();
            aboutus.MdiParent = this;
            aboutus.Show();
        }

        private void exit_toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cal_Button3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Users\\DELL E5470\\source\\repos\\Calc_pro_sn\\Calc_pro\\bin\\Debug\\net6.0-windows\\Calc_pro.exe";
            this.process1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                search_toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                about_US_toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                exit_toolStripButton5_Click(sender, e);
            }
        }
    }
}
