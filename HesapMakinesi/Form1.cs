using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Operation operation1 = new Operation();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void readValue(string value)
        {
            button20.Focus();

        switch(value)
            {
                case ",":
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    {
                        switch (operation1.whatToRead)
                        {
                            case "I":
                                {
                                    operation1.firstTerm += value;
                                    richTextBox1.Text += value;
                                    break;
                                }
                            case "II":
                                {
                                    operation1.secondTerm += value;
                                    richTextBox1.Text += value;
                                    break;
                                }
                            case "new":
                                {
                                    richTextBox1.Text = "";
                                    operation1.secondTerm = "";
                                    operation1.oprSign = "";

                                    operation1.firstTerm = value;
                                    richTextBox1.Text = operation1.firstTerm;
                                    operation1.whatToRead = "I";
                                    break;
                                }
                        }

                        break;
                    }

                case "sqrt":
                    {
                        richTextBox2.Text = "√(" + operation1.firstTerm + ")";

                        switch (operation1.whatToRead)
                        {
                            case "I":
                                {
                                    break;
                                }
                            case "II":
                                {
                                    operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                                    richTextBox2.Text = "√(" + operation1.firstTerm + " " + operation1.oprSign + " " + operation1.secondTerm + ")";
                                    operation1.firstTerm = operation1.result.ToString();

                                    break;
                                }
                        }

                        operation1.secondTerm = operation1.firstTerm;
                        operation1.oprSign = "sqrt";
                        operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                        operation1.firstTerm = operation1.result.ToString();
                        richTextBox1.Text = operation1.firstTerm;

                        operation1.secondTerm = "";
                        operation1.oprSign = "";
                        operation1.whatToRead = "new";

                        break;
                    }

                case "sq":
                    {
                        richTextBox2.Text = "(" + operation1.firstTerm + ")²";

                        switch (operation1.whatToRead)
                        {
                            case "I":
                                {   
                                    break;
                                }
                            case "II":
                                {
                                    operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                                    richTextBox2.Text = "(" + operation1.firstTerm + " " + operation1.oprSign + " " + operation1.secondTerm + ")²";
                                    operation1.firstTerm = operation1.result.ToString();
                                    
                                    break;
                                }
                        }

                        operation1.secondTerm = operation1.firstTerm;
                        operation1.oprSign = "x";
                        operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                        operation1.firstTerm = operation1.result.ToString();
                        richTextBox1.Text = operation1.firstTerm;
                        
                        operation1.secondTerm = "";
                        operation1.oprSign = "";
                        operation1.whatToRead = "new";

                        break;
                    }
                case "+":
                case "-":
                case "x":
                case "/":
                case "%":
                    {
                        switch(operation1.whatToRead)
                        {
                            case "I":
                                {
                                    operation1.oprSign = value;
                                    richTextBox1.Text += " " + operation1.oprSign + " ";
                                    operation1.whatToRead = "II";
                                    break;
                                }
                            case "II": 
                                {
                                    operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                                    richTextBox2.Text = operation1.firstTerm + " " + operation1.oprSign + " " + operation1.secondTerm;

                                    operation1.secondTerm = "";
                                    operation1.firstTerm = operation1.result.ToString();
                                    operation1.oprSign = value;
                                    richTextBox1.Text = operation1.firstTerm + " " + operation1.oprSign + " ";

                                    break;
                                }
                            case "new":
                                {
                                    operation1.oprSign = value;
                                    operation1.firstTerm = richTextBox1.Text;
                                    richTextBox1.Text += " " + operation1.oprSign + " ";
                                    operation1.whatToRead = "II";
                                    break;
                                }
                        }

                        break;
                    }
                case "=":
                    {
                        operation1.result = operation1.oprResult(Convert.ToDouble(operation1.firstTerm), operation1.oprSign, Convert.ToDouble(operation1.secondTerm));
                        richTextBox1.Text = operation1.result.ToString();
                        richTextBox2.Text = operation1.firstTerm + " " + operation1.oprSign + " " + operation1.secondTerm;
                        
                        operation1.secondTerm = "";
                        operation1.oprSign = "";
                        operation1.whatToRead = "new";
                        
                        break;
                    }
                

            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            readValue("0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            readValue("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            readValue("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            readValue("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            readValue("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            readValue("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readValue("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readValue("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readValue("8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readValue("9");
        }
        
        private void button20_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != ""))
            {
                readValue("=");
            }
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("+");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("-");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("x");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("/");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("sqrt");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("sq");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && operation1.firstTerm != "") || (operation1.whatToRead == "II" && operation1.secondTerm != "") || (operation1.whatToRead == "new" && richTextBox2.Text != ""))
            {
                readValue("%");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((operation1.whatToRead == "I" && !operation1.firstTerm.Contains(",")) || (operation1.whatToRead == "II" && !operation1.secondTerm.Contains(",")))
            {
                readValue(",");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            operation1.firstTerm = "";
            operation1.oprSign = "";
            operation1.secondTerm = "";
            operation1.whatToRead = "new";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D0:
                    {
                        readValue("0");
                        break;
                    }
                case Keys.D1:
                    {
                        readValue("1");
                        break;
                    }
                case Keys.D2:
                    {
                        readValue("2");
                        break;
                    }
                case Keys.D3:
                    {
                        readValue("3");
                        break;
                    }
                case Keys.D4:
                    {
                        readValue("4");
                        break;
                    }
                case Keys.D5:
                    {
                        readValue("5");
                        break;
                    }
                case Keys.D6:
                    {
                        readValue("6");
                        break;
                    }
                case Keys.D7:
                    {
                        readValue("7");
                        break;
                    }
                case Keys.D8:
                    {
                        readValue("8");
                        break;
                    }
                case Keys.D9:
                    {
                        readValue("9");
                        break;
                    }
                case Keys.Add:
                    {
                        button12_Click(sender, e);
                        break;
                    }
                case Keys.Subtract:
                    {
                        button13_Click(sender, e);
                        break;
                    }
                case Keys.Multiply:
                    {
                        button14_Click(sender, e);
                        break;
                    }
                case Keys.Divide:
                    {
                        button15_Click(sender, e);
                        break;
                    }
                case Keys.Delete:
                    {
                        button16_Click(sender, e);
                        break;
                    }
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }              
            }
        }
    }
}