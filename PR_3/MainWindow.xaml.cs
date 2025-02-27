using System;
using System.Windows;

namespace PR_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double amount = double.Parse(AmountTextBox.Text);
                int months = int.Parse(MonthsTextBox.Text);
                double rate = double.Parse(RateTextBox.Text) / 100;

                double result;

                if (SimpleInterestRadioButton.IsChecked == true)
                {
                    result = amount + (amount * rate * months / 12);
                }
                else
                {
                    result = amount * Math.Pow(1 + rate / 12, months);
                }

                ResultLabel.Content = $"Доход по вкладу = {result:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }
    }
}
