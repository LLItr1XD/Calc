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

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentInput = "";
        public string currentOperator = "";
        public double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        public string GetDisplayText()
        {
            return displayTextBox.Text;
        }
        public void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Content.ToString();
            displayTextBox.Text = currentInput;
        }

        public void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string newOperator = button.Content.ToString();

            if (!string.IsNullOrEmpty(currentInput))
            {
                if (!string.IsNullOrEmpty(currentOperator))
                {
                    Calculate();
                }

                result = double.Parse(currentInput);
                currentInput = "";
                currentOperator = newOperator;
            }
        }

        public void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(currentOperator))
            {
                Calculate();
                currentOperator = "";
            }
        }

        public void Calculate()
        {
            double input = double.Parse(currentInput);
            switch (currentOperator)
            {
                case "+":
                    result += input;
                    break;
                case "-":
                    result -= input;
                    break;
                case "*":
                    result *= input;
                    break;
                case "/":
                    if (input != 0)
                    {
                        result /= input;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                    }
                    break;
            }
            displayTextBox.Text = result.ToString();
            currentInput = result.ToString();
        }

        public void Clear_Click(object sender, RoutedEventArgs e)
        {
            currentInput = "";
            currentOperator = "";
            result = 0;
            displayTextBox.Text = "";
        }

        public void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                displayTextBox.Text = currentInput;
            }
        }
    }
}
