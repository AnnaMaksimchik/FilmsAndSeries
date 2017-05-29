using System.Windows;
using System.Windows.Controls;

namespace FilmsAndSeries
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            ListViewed wind = new ListViewed();
            Hide();
            wind.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddNew wind = new AddNew();
            this.Hide();
            wind.Show();
        }
    }
}
