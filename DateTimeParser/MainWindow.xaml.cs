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
            
        }

        private void convertBtnDate_Click(object sender, RoutedEventArgs e)
        {
            var date = new DateOnly();

            if (formatInputTextBoxDate.Text == "")
            {
                if (isUsingTryCheckBoxDate.IsChecked == true)
                {
                    if (!DateOnly.TryParse(inputTextBoxDate.Text, out date))
                    {
                        outputTextBlockDate.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    date = DateOnly.Parse(inputTextBoxDate.Text);
                }

            }
            else
            {
                if (isUsingTryCheckBoxDate.IsChecked == true)
                {
                    if (!DateOnly.TryParseExact(inputTextBoxDate.Text, formatInputTextBoxDate.Text, out date))
                    {
                        outputTextBlockDate.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    date = DateOnly.ParseExact(inputTextBoxDate.Text, formatInputTextBoxDate.Text);

                }
            }
            outputTextBlockDate.Text = $"Год:{date.Year}  Месяц:{date.Month}  День:{date.Day}";
        }



        private void convertBtnTime_Click(object sender, RoutedEventArgs e)
        {
            var time = new TimeOnly();

            if (formatInputTextBoxTime.Text == "")
            {
                if (isUsingTryCheckBoxTime.IsChecked == true)
                {
                    if (!TimeOnly.TryParse(inputTextBoxTime.Text, out time))
                    {
                        outputTextBlockTime.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    time = TimeOnly.Parse(inputTextBoxTime.Text);
                }

            }
            else
            {
                if (isUsingTryCheckBoxTime.IsChecked == true)
                {
                    if (!TimeOnly.TryParseExact(inputTextBoxTime.Text, formatInputTextBoxTime.Text, out time))
                    {
                        outputTextBlockTime.Text = "Некорректный ввод! попробуйте еще раз!";
                        return;
                    }
                }
                else
                {
                    time = TimeOnly.ParseExact(inputTextBoxTime.Text, formatInputTextBoxTime.Text);

                }
            }
            outputTextBlockTime.Text = $"Час:{time.Hour}  Минута:{time.Minute}  Секунда:{time.Second}  Миллисекунда:{time.Millisecond} ";
        }
    }
}