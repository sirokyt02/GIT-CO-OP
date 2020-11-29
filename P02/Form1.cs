using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

            Random nh = new Random();
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int x = nh.Next(0, 11);
                listBox1.Items.Add(x);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int souc = 0;
            foreach (int a in listBox1.SelectedItems)
            {
                souc += a;
            }
            label1.Text = "Mnozstvi vybranych polozek je: " + listBox1.SelectedItems.Count.ToString();
            label2.Text = "Soucet polozek je: " + souc.ToString();
            //pri vyberu vice polozek zmacknout CTRL (poznamka pro me)
        }
    }
}
