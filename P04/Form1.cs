using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string overeni = Convert.ToString(comboBox1.SelectedItem);
            if(overeni!="")
            {
                int umocneni = Convert.ToInt32(overeni);
                label1.Text = "Čísla se umocní na: " + overeni;
                foreach(Control textbox in panel1.Controls)
                {
                    if(textbox is TextBox)
                    {
                        if(textbox.Text!="")
                        {
                            double vypocet = Convert.ToInt32(textbox.Text);
                            vypocet = Math.Pow(vypocet, umocneni);
                            textbox.Text = vypocet.ToString();
                        }
                    }
                }
            }
            else
            {
                label1.Text = "Nebylo vybráno žádné číslo!";
            }
        }
    }
}
