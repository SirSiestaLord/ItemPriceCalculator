using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCalculator
{
    public partial class Form3 : Form
    {
        public float totalresult;
        public string resultants="Included Items:\n";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = resultants;
            richTextBox1.Text = totalresult.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
