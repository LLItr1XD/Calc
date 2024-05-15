using System;
using Xunit;

namespace CalcTest
{
    public class UnitTest1
    {
        public void AdditionTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("1");
            mainWindow.Operator_Click("+");
            mainWindow.Number_Click("2");
            mainWindow.Equals_Click();
            Assert.Equal("3", mainWindow.displayTextBox.Text);
        }

        [Fact]
        public void SubtractionTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("5");
            mainWindow.Operator_Click("-");
            mainWindow.Number_Click("3");
            mainWindow.Equals_Click();
            Assert.Equal("2", mainWindow.displayTextBox.Text);
        }

        [Fact]
        public void MultiplicationTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("4");
            mainWindow.Operator_Click("*");
            mainWindow.Number_Click("3");
            mainWindow.Equals_Click();
            Assert.Equal("12", mainWindow.displayTextBox.Text);
        }

        [Fact]
        public void DivisionTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("8");
            mainWindow.Operator_Click("/");
            mainWindow.Number_Click("2");
            mainWindow.Equals_Click();
            Assert.Equal("4", mainWindow.displayTextBox.Text);
        }

        [Fact]
        public void DivisionByZeroTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("5");
            mainWindow.Operator_Click("/");
            mainWindow.Number_Click("0");
            mainWindow.Equals_Click();
            Assert.Equal("Cannot divide by zero.", mainWindow.displayTextBox.Text);
        }

        [Fact]
        public void ClearTest()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Number_Click("5");
            mainWindow.Operator_Click("+");
            mainWindow.Number_Click("3");
            mainWindow.Clear_Click();
            Assert.Equal("", mainWindow.displayTextBox.Text);
        }
    }
}
