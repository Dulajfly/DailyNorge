using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace DailyNorge
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DictionaryButton_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection polaczenie = new SqlConnection("Data Source=.\SQLEXPRESS; Integrated Security=True;");
            //polaczenie.Open();
            //SqlCommand komenda = new SqlCommand(string.Format("if not exists(select * from sys.databases where name = '{0}') create database {0}", DictionaryButton), polaczenie);
            //komenda.ExecuteNonQuery();
            //polaczenie.Close();
            //polaczenie.ConnectionString = string.Format("Data Source =.;Database='{0}';Integrated Security = True; ", DictionaryButton);
            //polaczenie.Open();
            //komenda.CommandText = "create table slowa(Id int not null identity(1,1), Polski varchar(50), Norweski varchar(50), Angielski varchar(50)";
            //komenda.ExecuteNonQuery();
            //polaczenie.Close();
            TranslateSearch Translate = new TranslateSearch();
            Translate.Show();
            this.Close();
        }

        private void GrammaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zakup pełną wersję programu do odblokowania tej opcji");
        }

        private void DziennaLekcjaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zakup pełną wersję programu do odblokowania tej opcji");
        }
    }
}
