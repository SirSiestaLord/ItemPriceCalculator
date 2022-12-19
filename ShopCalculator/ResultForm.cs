using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCalculator
{
    public partial class ResultForm : Form
    {
        public string a=" ";
        public ResultForm()
        {
            InitializeComponent();


        }
       

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(a);
            richTextBox2.Text = a;
        }
    }
}
