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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("please enter ID please");
                return;
            }
            //----------------\
            string fn;
            fn = "C:\\Users\\Public\\testing\\";
            string p;
            string r;
            p = fn + this.textBox1.Text + "_fn.txt";
            //------------  first name____-----------------
            //System.IO.File.WriteAllText(p, this.textBox1.Text, Encoding.UTF8);
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.firstName_textBox6.Text = r;
            }
            else
            {
                MessageBox.Show("doesnt exist at present");
            }
            //_________________________________________________
            //------------ last name -----------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.lastname_textBox5.Text = r;
            }
            
            //_________________________________________________
            //------------  tel -----------------
            //System.IO.File.WriteAllText(p, this.textBox1.Text, Encoding.UTF8);
            p = fn + this.textBox1.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_textBox2.Text = r;
            }
            
            //_________________________________________________ 
            //------------  add -----------------
            p = fn + this.textBox1.Text + "_add.txt";
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.address_textBox8.Text = r;
            }
            
            p = fn + this.textBox1.Text + "_com.txt";
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comment_textBox3.Text = r;
            }
            
            //_________________________________________________
            //------------ email ----------------
            p = fn + this.textBox1.Text + "_eml.txt";
            if (System.IO.File.Exists(p) == true)
            {

                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_textBox7.Text = r;
            }
            this.ID_textBox1.Text = textBox1.Text;
            this.textBox1.Focus();
            //_________________________________________________
        }
    }
}
