using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            listView1.BeginUpdate();
            ListViewItem item;
            while (i < 5)
            {
                item = new ListViewItem("서울");
                item.SubItems.Add("부산");
                item.SubItems.Add("대전");
                item.SubItems.Add("대구");
                item.SubItems.Add("터닝");

                listView1.Items.Add(item);

                if (i == 3)
                {
                    listView1.Items[i].BackColor = Color.Yellow;
                }
                i++;
            }
            listView1.Columns.Add("칼럼 1");
            listView1.Columns.Add("칼럼 2");
            listView1.Columns.Add("칼럼 3");
            listView1.Columns.Add("칼럼 4");
            listView1.Columns.Add("칼럼 5");
            listView1.View = View.Details;
            listView1.Columns[4].Width = 30;
            listView1.EndUpdate();
        }

    }
}
