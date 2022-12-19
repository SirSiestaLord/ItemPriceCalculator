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
    public partial class Form1 : Form
    {
        List<SetVars> setVarsList = new List<SetVars>();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a=0f;
            //setVarsList.Add(richTextBox1.Text.ToString(), float.Parse(richTextBox2.Text.ToString()), float.Parse(richTextBox3.Text.ToString()));
            if ((richTextBox2.Text.ToString().Length <= 0)){ richTextBox2.Text ="0"; }
            if ((richTextBox3.Text.ToString().Length <= 0)) { richTextBox3.Text = "0"; }
            if (float.TryParse(richTextBox2.Text.ToString(),out a)) {
                if (float.TryParse(richTextBox3.Text.ToString(), out a))
                {
                    setVarsList.Add(new SetVars(richTextBox1.Text.ToString(), float.Parse(richTextBox2.Text.ToString()), float.Parse(richTextBox3.Text.ToString())));
                    richTextBox5.Text += "Name:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;
                    i++;
                }
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a=0;
            Form2 form2 = new Form2();
            form2.ShowDialog();
             string results="Results:\n";
            if (form2.indexsearched != null)
            {
                if (form2.indexsearched.Length > 0)
                {
                    if (float.TryParse(form2.indexsearched.ToString(), out a))
                    {
                        for (int i = 0; i < setVarsList.Count; i++)
                        {
                            if (setVarsList[i].price == float.Parse(form2.indexsearched))
                            {
                                results += "\nName:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;
                            }
                            else if (setVarsList[i].much == float.Parse(form2.indexsearched))
                            {
                                results += "\nName:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;

                            }
                            else if (setVarsList[i].totalprice == float.Parse(form2.indexsearched))
                            {
                                results += "\nName:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;

                            }
                        }
                    }
                    for (int i = 0; i < setVarsList.Count; i++)
                    {
                        if (setVarsList[i].name == form2.indexsearched)
                        {
                            results += "\nName:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;

                        }


                    }






                }
                ResultForm res = new ResultForm();
                res.a = results;
                res.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float totalprices=0;
            Form3 form3 = new Form3();
            for (int i = 0; i < setVarsList.Count; i++)
            {
                form3.resultants += "Name:" + setVarsList[i].name + "\nPrice:" + setVarsList[i].price + "\nAmount:" + setVarsList[i].much + "\nTotal Price:" + (setVarsList[i].totalprice) + "\n*********************" + Environment.NewLine;
                totalprices += setVarsList[i].totalprice;
            }
            totalprices /= setVarsList.Count;
            form3.totalresult = totalprices;
            form3.ShowDialog();
        }
    }
}
