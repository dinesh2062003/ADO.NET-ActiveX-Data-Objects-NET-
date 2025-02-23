using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CREATE a = new CREATE();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdraw t = new withdraw();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deposit b = new deposit();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bal c = new bal();
            c.Show();
        }
    }
}
