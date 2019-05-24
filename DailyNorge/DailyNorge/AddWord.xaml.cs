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
    /// Logika interakcji dla klasy AddWord.xaml
    /// </summary>
    public partial class AddWord : Window
    {
        public AddWord()
        {
            InitializeComponent();
            
        }

        private void AddWord1_Click(object sender, RoutedEventArgs e)
        {
            if(AddPolishWord.Text==""|| AddNorgeWord.Text=="" || AddEnglishWord.Text == ""||AddPolishWord.Text == " " || AddNorgeWord.Text == "  " || AddEnglishWord.Text == "   "||AddPolishWord.Text == "    " || AddNorgeWord.Text == "     " || AddEnglishWord.Text == "      ")
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola");
            }

            //else
            //{

            //    XmlDocument DictionaryTranslate = new XmlDocument();
            //    DictionaryTranslate.Load("C:\\Users\\hp\\source\\repos\\DailyNorge\\DailyNorge\\bin\\Debug\\DictionaryTranslate.xml");
            //    XmlNode root = DictionaryTranslate.CreateElement("root");
            //    XmlNode pozycja = DictionaryTranslate.CreateElement("Pozycja");
            //    XmlNode Polski = DictionaryTranslate.CreateElement("Polski");
            //    XmlNode Norweski = DictionaryTranslate.CreateElement("Norweski");
            //    XmlNode Angielski = DictionaryTranslate.CreateElement("Angielski");

            //    pozycja.InnerText = AddPolishWord.Text;
            //    root.AppendChild(Polski);

            //    Polski.InnerText = AddPolishWord.Text;,
            //    pozycja.AppendChild(Polski);

            //    Norweski.InnerText = AddNorgeWord.Text;
            //    pozycja.AppendChild(Norweski);

            //    Angielski.InnerText = AddEnglishWord.Text;
            //    pozycja.AppendChild(Angielski);

            //    DictionaryTranslate.DocumentElement.AppendChild(pozycja);
            //    DictionaryTranslate.Save("C:\\Users\\hp\\source\\repos\\DailyNorge\\DailyNorge\\bin\\Debug\\DictionaryTranslate.xml");
                MessageBox.Show("Dodano słowo pomyślnie");
            }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            TranslateSearch Translate = new TranslateSearch();
            Translate.Show();
            this.Close();
        }
    }

    //private void ReturnButton_Click(object sender, RoutedEventArgs e)
    //    {
    //        TranslateSearch Translate = new TranslateSearch();
    //        Translate.Show();
    //        this.Close();
    //    }
    //}
}
