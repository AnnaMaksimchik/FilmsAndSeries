using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FilmsAndSeries
{
    
    /// <summary>
    /// Логика взаимодействия для ListViewed.xaml
    /// </summary>
    public partial class ListViewed : Window
    {  
        public ListViewed()
        {
            InitializeComponent();
            updateList();
            List<string> sortList = new List<string>() {"none","year","name"};
            foreach (string s in sortList)
            {
                sortBox.Items.Add(s);
            }
        }
        private void SortList()
        {
            
        }

        private void updateList()
        {
            listBox.Items.Clear();
            FileStream file = new FileStream("D:/АИП/C# курсовая/Application1/FilmsAndSeries/list.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file, Encoding.Default);            
            while (!reader.EndOfStream)
            {
                listBox.Items.Add(reader.ReadLine());                      
            }
            reader.Close();
            file.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow win = new MainWindow();
            win.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int s = listBox.SelectedIndex;
            string filePath = "D:/АИП/C# курсовая/Application1/FilmsAndSeries/list.txt";

            string[] fileLines = File.ReadAllLines(filePath);
            var query = fileLines.Where(n => fileLines.ElementAt(s) != n);
            File.WriteAllLines(filePath, query);
            updateList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            string s = listBox.SelectedItem.ToString();
            int i = listBox.SelectedIndex;
            Edit win = new Edit(s, i);
            win.Show();
            Hide();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> mass = new List<string>();
            for(int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items.GetItemAt(i).ToString().Contains(textBox.Text))
                {
                    mass.Add(listBox.Items.GetItemAt(i).ToString());
                }
            }
            listBox.Items.Clear();
            foreach(string str in mass)
            {
                listBox.Items.Add(str);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            updateList();
        }
    }
}
