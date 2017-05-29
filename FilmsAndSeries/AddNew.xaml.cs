using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FilmsAndSeries
{
    
    /// <summary>
    /// Логика взаимодействия для AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        public AddNew()
        {            
            //создание коллекции жанров и добавление в ComboBox
            InitializeComponent();
            List<string> listOfGenres = new List<string>() {"horror","comedy","thriller","detective","romantic","fantasy","drama","crime",
                "epics","historical","adventure","westerns","war","science","musicals"
            };
            foreach(string s in listOfGenres)
            {
                genres.Items.Add(s);
            }        
        }

        //удаляет текст из TextBox при нажатии
        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow wind = new MainWindow();
            wind.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if ((series.IsChecked == false && film.IsChecked == false) || genres.Text == null || (year.Text=="" || year.Text=="write year...") || (name.Text == "" || name.Text == "write name..."))
            {
                Warning wind = new Warning();
                wind.Show();
            }
            else
            {

                StringBuilder filmInformation = new StringBuilder();
                StreamWriter writer = new StreamWriter(new FileStream("D:/АИП/C# курсовая/Application1/FilmsAndSeries/list.txt", FileMode.Append, FileAccess.Write), Encoding.Default);
                if (film.IsChecked ?? true)
                {
                    filmInformation.Append("film" + '\t' + '\t');
                }
                else
                {
                    if (series.IsChecked ?? true)
                    {
                        filmInformation.Append("series" + '\t' + '\t');
                    }
                }
                if (genres.Text == "detective" || genres.Text == "adventure" || genres.Text == "historical")
                {
                    filmInformation.Append(genres.Text + '\t');
                }
                else
                {
                    filmInformation.Append(genres.Text + '\t' + '\t');
                }
                if (series.IsChecked ?? true)
                {
                    filmInformation.Append(year.Text + '\t');
                }
                else
                {
                    filmInformation.Append(year.Text + '\t' + '\t');
                }
                series.IsChecked = false;
                film.IsChecked = false;
                filmInformation.Append(name.Text);
                genres.Text = null;
                writer.WriteLine(filmInformation);
                writer.Close();
                name.Text = "write name...";
                year.Text = "write year...";
            }           
        }
    }
}
