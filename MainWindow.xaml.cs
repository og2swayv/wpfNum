using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool TryGetNumbers(out double a, out double b)
        {
            bool firstOk = double.TryParse(FirstNumberTextBox.Text, out a);
            bool secondOk = double.TryParse(SecondNumberTextBox.Text, out b);

            if (!firstOk || !secondOk)
            {
                ResultTextBlock.Text = "Введите корректные числа";
                return false;
            }

            return true;
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
            {
                if (b == 0)
                {
                    ResultTextBlock.Text = "На ноль делить нельзя";
                    return;
                }

                ResultTextBlock.Text = (a / b).ToString();
            }
        }
    }
}