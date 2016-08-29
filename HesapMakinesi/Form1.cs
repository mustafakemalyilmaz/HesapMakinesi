using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Operation operation1 = new Operation();
        string sign1 = "";
        


        public Form1()
        {
            InitializeComponent();
            operation1.firstTerm = "";
            operation1.secondTerm = "";
            operation1.firstOrSecond = "first";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button9.Text;
                richTextBox1.Text += button9.Text;
            } else
            {
                operation1.secondTerm += button9.Text;
                richTextBox1.Text += button9.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button8.Text;
                richTextBox1.Text += button8.Text;
            }
            else
            {
                operation1.secondTerm += button8.Text;
                richTextBox1.Text += button8.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button7.Text;
                richTextBox1.Text += button7.Text;
            }
            else
            {
                operation1.secondTerm += button7.Text;
                richTextBox1.Text += button7.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button10.Text;
                richTextBox1.Text += button10.Text;
            }
            else
            {
                operation1.secondTerm += button10.Text;
                richTextBox1.Text += button10.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button6.Text;
                richTextBox1.Text += button6.Text;
            }
            else
            {
                operation1.secondTerm += button6.Text;
                richTextBox1.Text += button6.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button5.Text;
                richTextBox1.Text += button5.Text;
            }
            else
            {
                operation1.secondTerm += button5.Text;
                richTextBox1.Text += button5.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button4.Text;
                richTextBox1.Text += button4.Text;
            }
            else
            {
                operation1.secondTerm += button4.Text;
                richTextBox1.Text += button4.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button3.Text;
                richTextBox1.Text += button3.Text;
            }
            else
            {
                operation1.secondTerm += button3.Text;
                richTextBox1.Text += button3.Text;
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button2.Text;
                richTextBox1.Text += button2.Text;
            }
            else
            {
                operation1.secondTerm += button2.Text;
                richTextBox1.Text += button2.Text;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += button1.Text;
                richTextBox1.Text += button1.Text;
            }
            else
            {
                operation1.secondTerm += button1.Text;
                richTextBox1.Text += button1.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                sign1 = "+";
                operation1.firstOrSecond = "second";
                richTextBox1.Text += "+";
            } else
            {
                button20_Click(sender, e);
                sign1 = "+";
                operation1.firstOrSecond = "second";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {


            string result1 = operation1.operationResult(Convert.ToDouble(operation1.firstTerm), Convert.ToDouble(operation1.secondTerm), sign1).ToString();

            richTextBox1.Text = result1;
            // richTextBox1.AppendText(Environment.NewLine + op1);

            // The first operation is over. We are setting values for the next one.

            operation1.firstOrSecond = "first";
            operation1.firstTerm = result1;
            operation1.secondTerm = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                sign1 = "-";
                operation1.firstOrSecond = "second";
                richTextBox1.Text += "-";
            }
            else
            {
                button20_Click(sender, e);
                sign1 = "-";
                operation1.firstOrSecond = "second";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                sign1 = "x";
                operation1.firstOrSecond = "second";
                richTextBox1.Text += "x";
            }
            else
            {
                button20_Click(sender, e);
                sign1 = "x";
                operation1.firstOrSecond = "second";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                sign1 = "/";
                operation1.firstOrSecond = "second";
                richTextBox1.Text += "/";
            }
            else
            {
                button20_Click(sender, e);
                sign1 = "/";
                operation1.firstOrSecond = "second";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string result1 = Math.Sqrt(Convert.ToDouble(operation1.firstTerm)).ToString();
            richTextBox1.Text = result1;
            operation1.firstTerm = result1;
            operation1.secondTerm = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string result1 = operation1.operationResult(Convert.ToDouble(operation1.firstTerm), Convert.ToDouble(operation1.firstTerm), "x").ToString();

            richTextBox1.Text = result1;

            // The first operation is over (square). We are setting values for the next one.

            operation1.firstOrSecond = "first";
            operation1.firstTerm = result1;
            operation1.secondTerm = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                sign1 = "%";
                operation1.firstOrSecond = "second";
                richTextBox1.Text += "%";
            }
            else
            {
                button20_Click(sender, e);
                sign1 = "%";
                operation1.firstOrSecond = "second";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operation1.firstOrSecond == "first")
            {
                operation1.firstTerm += ",";
                richTextBox1.Text += ",";
            }
            else
            {
                operation1.secondTerm += ",";
                richTextBox1.Text += ",";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
            {

                if (operation1.firstOrSecond == "first")
                {
                    operation1.firstTerm = operation1.firstTerm.Remove(operation1.firstTerm.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                }
                else
                {
                    operation1.secondTerm = operation1.secondTerm.Remove(operation1.secondTerm.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
