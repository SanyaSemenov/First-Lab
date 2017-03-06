using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string myDirectory = string.Empty;    //    инициализируем директорию
        //private XmlDocument MyDoc = null;    //    БД
        //DataTable Citytable = null;    //    таблицу с данными
        //DataSet Cities = null;    //    данные

        public MainWindow()
        {
            //myDirectory = Directory.GetCurrentDirectory();        //присваиваем значение текущей директории
            // ЗДЕСЬ МОЖЕТ БЫТЬ ОШИБКА
            //using (StreamReader streamreader = new StreamReader(/*myDirectory + */@"C:\Users\HOOLIGAN\Documents\Visual Studio 2015\Projects\Lab1\Lab1\rocid.xml", System.Text.Encoding.UTF8))
            //{
                //Cities = new DataSet();
                //Cities.ReadXml(streamreader, XmlReadMode.Auto);
                //Citytable = Cities.Tables[0];    // присваиваем данные БД таблицы
            //}
            InitializeComponent();
        }

        private void Submit_Form(object sender, RoutedEventArgs e)
        {

        }

        private void Reset_Form(object sender, RoutedEventArgs e)
        {
            /*foreach (Control control in MainWindow.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                first.IsChecked = true;
                second.IsChecked = false;
                third.IsChecked = false;
            }*/
        }
    }
}
