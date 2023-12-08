using System.Windows;

namespace WpfAppValuesResultsToXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Result();
        }

        private void Result()
        {
            Value1.Text = "7";
            Value2.Text = "8";
            Value3.Text = "9";

            if (int.TryParse(Value1.Text, out int value1) && int.TryParse(Value2.Text, out int value2) && int.TryParse(Value3.Text, out int value3))
            {
                int result = value1 + value2 + value3;
                ResultValue.Text = result.ToString();
            }
        }
    }
}
