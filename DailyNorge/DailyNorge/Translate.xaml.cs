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
    /// Logika interakcji dla klasy Translate.xaml
    /// </summary>
    public partial class Translate : Window
    {
        //TranslateSearch f1, f2;
        string f1, f2;
        public Translate()
        {
            InitializeComponent();
        }
        public Translate(string UserWord, string TranslatedWord)
        {
            InitializeComponent();
            f1 = UserWord;
            f2 = TranslatedWord;
            TranslateSearchWord.Content = UserWord;
            TranslateWord.Content = TranslatedWord;
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            TranslateSearch Translate = new TranslateSearch();
            Translate.Show();
            this.Close();
        }
    }
}
