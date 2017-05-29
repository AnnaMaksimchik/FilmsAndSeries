using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FilmsAndSeries
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private StringBuilder filmInformation = new StringBuilder();
        private int index = 0;
        public Edit(string s, int i)
        {
            InitializeComponent();
            index = i;
            List<string> listOfGenres = new List<string>() {"horror","comedy","detective","thriller","romantic","fantasy","drama","crime",
                "epics","historical","adventure","westerns","war","science","musicals"};
            foreach (string a in listOfGenres)
            {
                genres.Items.Add(a);
            }
            //запись данных в блоки
            
            List<string> listOfInformation = new List<string>(s.Split('\t'));
            for(int j= 0;j<listOfInformation.Count;j++)
            {
                if (listOfInformation[j]=="")
                {
                    listOfInformation.RemoveAt(j);
                }
            }
            if (listOfInformation[0] == "film")
            {
                film.IsChecked = true;
            }
            else
            {
                series.IsChecked = true;
            }
            genres.Text = listOfInformation[1];
            year.Text = listOfInformation[2];
            name.Text = listOfInformation[3];
        }
        
        public void deleteItem()
        {            
            string filePath = "D:/АИП/C#курсовая/FilmsAndSeries/FilmsAndSeries/list.txt";

            string[] fileLines = File.ReadAllLines(filePath);
            var query = fileLines.Where(n => fileLines.ElementAt(index) != n);
            File.WriteAllLines(filePath, query);
        }
        public StringBuilder getString()
        {
            return filmInformation;
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ListViewed wind = new ListViewed();
            Hide();
            wind.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            deleteItem();//удалить выбранный элемент
            StreamWriter writer = new StreamWriter(new FileStream("D:/АИП/C#курсовая/FilmsAndSeries/FilmsAndSeries/list.txt", FileMode.Append, FileAccess.Write), Encoding.Default);

            if (film.IsChecked ?? true)
            {
                filmInformation.Append("film" + '\t'+ '\t');                
            }
            else
            {
                if (series.IsChecked ?? true)
                {
                    filmInformation.Append("series" + '\t'+ '\t');                    
                }
            }
            if (genres.Text== "detective" || genres.Text== "adventure" || genres.Text== "historical")
            {
                filmInformation.Append(genres.Text + '\t');
            }
            else
            {
                filmInformation.Append(genres.Text + '\t' + '\t');
            }
            if(series.IsChecked ?? true)
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
            writer.WriteLine(filmInformation);
            writer.Close();
            ListViewed win = new ListViewed();
            win.Show();
            Hide();
        }
    }
}
