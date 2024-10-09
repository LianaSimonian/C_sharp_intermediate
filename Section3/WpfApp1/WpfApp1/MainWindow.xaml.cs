using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            var button = (Button) sender;
            var button1 =sender as Button;
            if (button1 != null)
            {
               MessageBox.Show(button.ActualHeight.ToString());
            }
            MessageBox.Show("Hello World !");
        }
    }
}