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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static double num1 = 0;
        static double num2 = 0;
        string operation = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                var content = (sender as Button).Content.ToString();
                num1 = (num1 * 10) + double.Parse(content);
                Display.Content = num1;
            }
            else
            {
                var content = (sender as Button).Content.ToString();
                num2 = (num2 * 10) + double.Parse(content);
                Display.Content = num2;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            var content = (sender as Button).Content.ToString();
            operation = content;
        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            Display.Content = "";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Content = Calculator.CalculatorMethod.Add(num1, num2);
                    break;
                case "-":
                    Display.Content = Calculator.CalculatorMethod.Subtract(num1, num2);
                    break;
                case "*":
                    Display.Content = Calculator.CalculatorMethod.Multiply(num1, num2);
                    break;
                case "%":
                    Display.Content = Calculator.CalculatorMethod.Modulus(num1, num2);
                    break;
                case "/":
                    if (num2==0)
                    {
                        Display.Content = "Math Error";
                    }
                    else
                        Display.Content = Calculator.CalculatorMethod.Divide(num1, num2);
                    break;

            }
        }

    }
}
