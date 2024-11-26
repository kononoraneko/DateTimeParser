using System.Windows;


namespace DateTimeParser
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

        private void convertBtn_Click(object sender, RoutedEventArgs e)
        {
            var date = new DateOnly();

            if (formatInputTextBox.Text == "") {
                if (isUsingTryCheckBox.IsChecked == true)
                {
                    if (!DateOnly.TryParse(inputTextBox.Text, out date))
                    {
                        outputTextBlock.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    date = DateOnly.Parse(inputTextBox.Text);
                    
                }
                
            }
            else
            {
                if (isUsingTryCheckBox.IsChecked == true) {
                    if (!DateOnly.TryParseExact(inputTextBox.Text, formatInputTextBox.Text, out date))
                    {
                        outputTextBlock.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    date = DateOnly.ParseExact(inputTextBox.Text, formatInputTextBox.Text);

                }
            }

            outputTextBlock.Text = $"Год:{date.Year}  Месяц:{date.Month}  День:{date.Day}";

        }
    }
}