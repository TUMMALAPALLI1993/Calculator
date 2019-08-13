using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        long number1 = 0;
        long number2 = 0;
        string mathOperation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (mathOperation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
