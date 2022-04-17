using Library.Entities;
using Library.Logic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages.PageStudent.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyBookPage.xaml
    /// </summary>
    public partial class MyBookPage : Page
    {
        public MyBookPage()
        {
            InitializeComponent();
            DateBook();

             
        }

        /// <summary>
        /// Заполняет данными ListView 
        /// </summary>
        public void DateBook()
        {            
           var extraditionSchool = App.DataBase.Extraditions.Where(p =>

           p.IdSchoolBoy.ToString() == DateUser.Id && p.IdTypeOfHalls == 3).
           OrderBy(p => p.Book.NameBook).ToList();
           listBook.ItemsSource = extraditionSchool;
        }



        /// <summary>
        /// Прокручивает ползунок, даже если мышка не наведена на него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollWiewers.ScrollWiewerContentScroll(sender, e);
        }



        /// <summary>
        /// Поиск данных
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbPoisk.Text))
            {
                try
                {
                    listBook.ItemsSource = App.DataBase.Extraditions.ToList().Where(p =>

                    p.Book.NameBook.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.Book.AuthorOfThebook.ToString().ToLower().Contains(tbPoisk.Text.ToLower()) ||
                    p.Book.YearOfPublication.ToString().ToLower().Contains(tbPoisk.Text.ToLower())).ToList();

                    var rows = listBook.ItemsSource.Cast<Extradition>().ToList();
                    if (rows.Count == 0)
                    {
                        tbInfo.Visibility = Visibility.Visible;
                    }
                    if (rows.Count != 0)
                    {
                        tbInfo.Visibility = Visibility.Collapsed;
                    }
                }
                catch
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                try
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    DateBook();
                }
                catch
                {
                    tbInfo.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Ошибка в получении данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoisk_Click(object sender, RoutedEventArgs e)
        {
            TextPoisck();
        }



        /// <summary>
        /// Если текстовое поле пустое, возвращает данные в исходное положение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPoisk.Text == "")
            {
                DateBook();
                tbInfo.Visibility = Visibility.Collapsed;
            }
            else
            {

            }
        }
    }
}
