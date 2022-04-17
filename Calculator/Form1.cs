using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operation = "";
        bool isOperation= false;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || isOperation)
            {
                textBox_result.Clear();
            }

            isOperation = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text = textBox_result.Text + button.Text;
                }
                    
            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }

        }

  

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (resultValue != 0)
            {
                button_answer.PerformClick();
                operation = button.Text;
                label_operation.Text = resultValue + " " + operation;
                isOperation = true;
            }
            else
            {
                operation = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                label_operation.Text = resultValue + " " + operation;
                isOperation = true;
            }
         

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void Delete_All_Click(object sender, EventArgs e)
        {
            //textBox_result.Clear();
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void Answer_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_result.Text);
            label_operation.Text = "";
            //switch (operation)
            //{
            //    case "+":
            //        textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
            //        break;

            //    case "-":
            //        textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
            //        break;

            //    case "*":
            //        textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
            //        break;

            //    case "/":
            //        textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
            //        break;

            //    default:
            //        break;
            //}
            //resultValue = Double.Parse(textBox_result.Text);
            //label_operation.Text = "";
        }
       
    }
}
