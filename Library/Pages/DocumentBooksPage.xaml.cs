using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.IO.Packaging;
using System.Windows.Documents;

using Microsoft.Win32;
using System.Windows.Xps.Packaging;
using System.Data.SqlClient;
using System.Data;
using Library.Logic;

namespace Library.Pages
{
    /// <summary>
    /// Логика взаимодействия для DocumentBooksPage.xaml
    /// </summary>
    public partial class DocumentBooksPage : Page
    {
        public DocumentBooksPage()
        {
            InitializeComponent();
            gridDate.DataContext = App.DataBase.Books.ToArray();
        }


        byte[] xpsArray;
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "XPS Documents | *.xps";

                if (dialog.ShowDialog() == true)
                {
                    xpsArray = File.ReadAllBytes(dialog.FileName);
                }

                //преобразовывает массив в документ 
                DocymentConvertToXPS.DocymentReader(xpsArray, doc);

            }
            catch
            {
                MessagesInfo.DocymentError();
            }
        }

        private void btnShowArray_Click(object sender, RoutedEventArgs e)
        {
            var arrya = App.DataBase.Books
            .Where(i => i.ElectronicVersion != null)
            .Select(i => i.ElectronicVersion).SingleOrDefault();

            //преобразовывает массив в документ 
            DocymentConvertToXPS.DocymentReader(arrya, doc);
        }



    }
}
