using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240314
{
    public partial class Form1 : Form
    {
        double firstNo = 0.0;
        double secondNo = 0.0;
        string func = "";

        public Form1()
        {
            InitializeComponent();
        }

        void num_press(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            if (textBox1.Text == "0") {
                if (textBox1.Text == "")
                    return;
                textBox1.Text += currentButton.Text;
            }
            else
                textBox1.Text += currentButton.Text;
        }

        private void btn_point_Clink(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = ".";
            }
            else
            {
                if (textBox1.Text.IndexOf(".") != -1)
                {
                    return;
                }
                else
                {
                    textBox1.Text += ((Button)sender).Text;
                }
            }
        }

        private void func_press(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                firstNo = Double.Parse(textBox1.Text);
                func = ((Button)sender).Text;

                MessageBox.Show($"{firstNo} {func}");

                textBox1.Clear();
            }
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void process_press(object sender, EventArgs e)
        {
            if (firstNo.Equals("") || textBox1.Text.Equals(""))
                return;
            else
            {
                secondNo = Double.Parse(textBox1.Text);
                switch (func)
                {
                    case "+":
                        textBox1.Text = (firstNo + secondNo).ToString();
                        break;
                    case "-":
                        textBox1.Text = (firstNo - secondNo).ToString();
                        break;
                    case "*":
                        textBox1.Text = (firstNo * secondNo).ToString();
                        break;
                    case "/":
                        if (secondNo != 0)
                        {
                            textBox1.Text = (firstNo / secondNo).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
        }
    }
}
