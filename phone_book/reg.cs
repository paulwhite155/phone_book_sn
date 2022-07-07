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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void new_data_button_Click(object sender, EventArgs e)
        {
            this.new_data_button.Enabled = false;
            this.save_changesButton2.Enabled = true;
            this.groupBox1.Enabled = true;
            //________clear text boxs-------------
            this.ID_textBox1.ResetText();
            this.firstName_textBox6.ResetText();
            this.lastname_textBox5.ResetText();
            this.tel_textBox2.ResetText();
            this.address_textBox8.ResetText();
            this.comment_textBox3.Text = "";
            this.email_textBox7.Text = "";
            //----------------------   see the 2 differnet ways of reseting..   --------
        }

        private void save_changesButton2_Click(object sender, EventArgs e)
        {
            if (this.ID_textBox1.Text == "")
            {
                MessageBox.Show("you must enter ID to continue ");
                return;
            }

            else
            {
                this.save_changesButton2.Enabled = false;
                this.new_data_button.Enabled = true;
                this.groupBox1.Enabled = false;
                //----------  declaring strings
                string fn;
                fn = "C:\\Users\\Public\\testing\\";
                string p;
                p = fn + this.ID_textBox1.Text + "_fn.txt";
                //------------  first name____-----------------
                System.IO.File.WriteAllText(p, this.firstName_textBox6.Text, Encoding.UTF8);
                //------------ last name _______________________
                p = fn + this.ID_textBox1.Text + "_ln.txt";
                System.IO.File.WriteAllText(p, this.lastname_textBox5.Text, Encoding.UTF8);
                //------------ tel _______________________
                p = fn + this.ID_textBox1.Text + "_tel.txt";
                System.IO.File.WriteAllText(p, this.tel_textBox2.Text, Encoding.UTF8);
                //------------ emial _______________________
                p = fn + this.ID_textBox1.Text + "_eml.txt";
                System.IO.File.WriteAllText(p, this.email_textBox7.Text, Encoding.UTF8);
                //------------ address_______________________
                p = fn + this.ID_textBox1.Text + "_add.txt";
                System.IO.File.WriteAllText(p, this.address_textBox8.Text, Encoding.UTF8);
                //------------ comment  _______________________
                p = fn + this.ID_textBox1.Text + "_com.txt";
                System.IO.File.WriteAllText(p, this.comment_textBox3.Text, Encoding.UTF8);


                MessageBox.Show("saving info now");
            }
        }

        private void ID_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comment_textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
