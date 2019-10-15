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
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator calculator = new Calculator();

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
           calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);


            

            double Result = calculator.Add();

            resultTextBox.Text = Result.ToString();

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);




            double Result = calculator.Sub();

            resultTextBox.Text = Result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);




            double Result = calculator.Mul();

            resultTextBox.Text = Result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator.FirstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.SecondNumber = Convert.ToDouble(secondNumberTextBox.Text);




            double Result = calculator.Div();

            resultTextBox.Text = Result.ToString();
        }
    }
}
