using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;
        string mathOperation = "";
        bool dotEvent = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void calculation(double n1,double n2,int buttonValue,string mathOperator)
        {
            
            if (mathOperator == "sqrt")
            {
                number1 = 0;
                number2 = 0;
                mathOperation = "";
            }

            if(dotEvent == true)
            {
                if (mathOperator == "")
                {
                    txtDisplay.Text = number1.ToString() + ".";
                }
                else
                {
                    txtDisplay.Text = number2.ToString() + ".";
                }
            }
            else if(txtDisplay.Text.IndexOf(".") > 0 && dotEvent == false)
            {
                if (mathOperator == "")
                {
                    number1 = double.Parse(txtDisplay.Text + buttonValue.ToString());
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = double.Parse(txtDisplay.Text + buttonValue.ToString());
                    txtDisplay.Text = number2.ToString();
                }

            }
            else
            {
                if (mathOperator == "")
                {
                    number1 = (n1 * 10) + buttonValue;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (n2 * 10) + buttonValue;
                    txtDisplay.Text = number2.ToString();
                }
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,0, mathOperation);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,1, mathOperation);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,2, mathOperation);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,3, mathOperation);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,4, mathOperation);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,5, mathOperation);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,6, mathOperation);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,7, mathOperation);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,8, mathOperation);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            calculation(number1, number2,9, mathOperation);
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            number1 = 0;
            number2 = 0;
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length >= 1)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                if (txtDisplay.Text != "")
                {
                    number1 = double.Parse(txtDisplay.Text);
                }
                else
                {
                    number1 = 0;
                }
            }
            number2 = 0;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                number1 = double.Parse(txtDisplay.Text);
            }
            
            mathOperation = "+";
            number2 = 0;
            txtDisplay.Text = "0";
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                number1 = double.Parse(txtDisplay.Text);
            }

            mathOperation = "-";
            number2 = 0;
            txtDisplay.Text = "0";
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                number1 = double.Parse(txtDisplay.Text);
            }

            mathOperation = "*";
            number2 = 0;
            txtDisplay.Text = "0";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                number1 = double.Parse(txtDisplay.Text);
            }

            mathOperation = "/";
            number2 = 0;
            txtDisplay.Text = "0";
        }

        private void BtnFraction_Click(object sender, RoutedEventArgs e)
        {
            if (number1 != 0)
            {
                txtDisplay.Text = (1 / number1).ToString();
                number1 = Math.Sqrt(number1);
            }
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {
            mathOperation = "sqrt";
            txtDisplay.Text = Math.Sqrt(double.Parse(txtDisplay.Text)).ToString();
            number1 = double.Parse(txtDisplay.Text);
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (mathOperation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    mathOperation = "";
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    mathOperation = "";
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    mathOperation = "";
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    mathOperation = "";
                    break;
            }
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.IndexOf(".") > 0)
            {

            }
            else
            {
                dotEvent = true;
                calculation(number1, number2, 0, mathOperation);
                dotEvent = false;
            }
        }
    }
}
