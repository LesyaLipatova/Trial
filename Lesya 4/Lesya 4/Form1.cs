using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesya_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leader leader = new Leader(richTextBox3.Text,
                Int32.Parse(richTextBox1.Text),
                Int32.Parse(richTextBox2.Text));
            richTextBox5.Text = leader.get_Q().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evaluation_by_descendants leader = new Evaluation_by_descendants(richTextBox3.Text,
               Int32.Parse(richTextBox1.Text),
               Int32.Parse(richTextBox2.Text), Int32.Parse(richTextBox6.Text));
            richTextBox5.Text = leader.get_Q().ToString();
        }
    }
}
