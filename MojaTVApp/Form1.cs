using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaTVApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 forma3 = new Form3();
            /////proba2
            forma3.Show();
            
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="admin")
            {
                MessageBox.Show("Greska");
            }
            else if (textBox2.Text != "admin")
            {
                MessageBox.Show("Greska");
            }
            else
            {
                
                Form2 forma2 = new Form2();
                //// komentargfdgdfgfdg
                forma2.Show();
              
                
                
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 forma4 = new Form4();
            forma4.Show();
        }
    }
}
