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
    public partial class Form2 : Form
    {
        private List<Channel> kanali;
        public Form2()
        {
            InitializeComponent();
            toolStripComboBox1.Items.Add("Recently watched");
            toolStripComboBox1.Items.Add("Favorites");
            toolStripComboBox1.Items.Add("All");
            dataGridView1.Rows.Clear();
            bindingSource1.Clear();
            dataGridView1.DataSource = bindingSource1;
            kanali = new List<Channel>();
            kanali.Add(new Channel("BHT1"));
            kanali.Add(new Channel("FTV"));
            kanali.Add(new Channel("PTPC"));
            foreach (Channel k in kanali)
                bindingSource1.Add(k);
            List<Channel> favoriti = new List<Channel>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Favoritescs nova = new Favoritescs();
            nova.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TVGuide t = new TVGuide();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows) {
                    Channel kanal = row.DataBoundItem as Channel;
                    kanal.watched = true;
                }
            
            
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.ToString() == "Recently watched")
            {
               
                    dataGridView1.Rows.Clear();
                    bindingSource1.Clear();
                    foreach (Channel kanal in kanali)
                    {
                        if (kanal.watched == true)
                        {
                            bindingSource1.Add(kanal);
                       }
                    }
                
            }
            if (toolStripComboBox1.SelectedItem.ToString() == "Favorites")
            {
               
                    dataGridView1.Rows.Clear();
                    bindingSource1.Clear();
                    foreach (Channel kanal in kanali)
                    {
                        if (kanal.fav == true)
                        {
                            bindingSource1.Add(kanal);
                        }
                    }
                
            }
            if (toolStripComboBox1.SelectedItem.ToString() == "All")
            {

                dataGridView1.Rows.Clear();
                bindingSource1.Clear();
                foreach (Channel kanal in kanali)
                {
                    
                        bindingSource1.Add(kanal);
                    
                }

            }
        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    Channel kanal = row.DataBoundItem as Channel;
                    kanal.fav = true;
                }
            }
        }
    }
}
