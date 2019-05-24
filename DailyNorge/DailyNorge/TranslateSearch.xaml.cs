using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace DailyNorge
{
    /// <summary>
    /// Logika interakcji dla klasy TranslateSearch.xaml
    /// </summary>
    public partial class TranslateSearch : Window
    {
        public string slowo = "";
        public int wybierzNumer = 1;
        public string slowoPrzetlumaczone = "";
        int Kolor;
        public TranslateSearch()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //if (SearchWord.Text == "Wpisz słowo")
            //{
            //    MessageBox.Show("Wprowadź słowo, które chcesz wyszukać");
            //}
            if (SearchWord.Text != null & SearchWord.Text.Length >= 3)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("DictionaryTranslate.xml");
                
                
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string word = node.Attributes[0].InnerText;
                    if (word == SearchWord.Text)
                    {
                        slowoPrzetlumaczone = node.ChildNodes[wybierzNumer].InnerText;
                        slowo = SearchWord.Text;

                        Translate Translate = new Translate(slowo, slowoPrzetlumaczone);
                        Translate.Show();
                        this.Close();
                        break;
                    }
                    //else if (word != SearchWord.Text)
                    //{
                    //    MessageBox.Show("Nie znaleziono takiego słowa");
                    //    break;
                    //}
                }
                //slowo = SearchWord.Text;
                //Translate Translate = new Translate(slowo, slowoPrzetlumaczone);
                //Translate.Show();
                //this.Close();
            }

            else
            {
                MessageBox.Show("Wprowadź prawidłowe słowo!");
                SearchWord.Text = string.Empty;
                SearchWord.Focus();
            }

            //XmlTextReader reader = new XmlTextReader("DictionaryTranslate.xml");
            //XmlNodeType type;

            //while (reader.Read())
            //{
            //    type = reader.NodeType;

            //    if (type == XmlNodeType.Element)
            //    {
            //        if (reader.Name == "Word")
            //        {
            //            reader.Read();
            //            SearchWord.Text = reader.Value;
            //        }
            //        else if(reader.Name == "Norweski")
            //        {
            //            reader.Read();
            //            Tlumaczenie.Items.Add(reader.Value);
            //        }
            //    }
            //}

        }

        private void TextBlock_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // norweski - polski
        {
            wybierzNumer = 0;
            Kolor = 1;
            Kolory();
        }

        private void PolskiNorweski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // polski - norweski
        {
            wybierzNumer = 1;
            Kolor = 2;
            Kolory();
        }

        private void SearchWord_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) 
        {
            SearchWord.Text = string.Empty;
        }

        private void Angielski_polski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // angielski - polski
        {
            wybierzNumer = 0;
            Kolor = 3;
            Kolory();
        }

        private void Polski_norweski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // polski - angielski
        {
            wybierzNumer = 2;
            Kolor = 4;
            Kolory();
        }

        private void Norweski_angielski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // norweski - angielski
        {
            wybierzNumer = 2;
            Kolor = 5;
            Kolory();
        }

        private void Angielski_norweski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) // angielski - norweski
        {
            wybierzNumer = 1;
            Kolor = 6;
            Kolory();
        }
        public void Kolory()
        {
            norweski_polski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            polskiNorweski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            angielski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            if (Kolor == 1)
            {
                norweski_polski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF5602"));
            }
            else if (Kolor == 2)
            {
                polskiNorweski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF5602"));
            }
            else if (Kolor == 3)
            {
                angielski.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF5602"));
            }
        }
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // GoToAddWord
        {
            
            AddWord AddNewWord = new AddWord();
            AddNewWord.Show();
            this.Close();
        }

        private void Angielski_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            wybierzNumer = 2;
            Kolor = 3;
            Kolory();
        }
    } 
}
