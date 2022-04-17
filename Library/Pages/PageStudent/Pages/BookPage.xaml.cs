using Library.Entities;
using Library.Logic;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {



        public BookPage()
        {
            InitializeComponent();

            DateBook();

            var holName = App.DataBase.TypeOfHalls.Where(p=> p.Id < 3).ToList();

            holName.Insert(0, new TypeOfHall
            {
                NameZal = "Все книги"
            });

            cmBook.ItemsSource = holName;
            cmBook.SelectedIndex = 0;


            AddHandler(KeyDownEvent, Page_KeyDown, true);


        }

       
        private void  Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                LoadData();
            }
        }


        // Так тоже не работает

        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                LoadData();
            }
        }



        /// <summary>
        /// Заставляет прокручивать содержимое, вне зависимости наведена ли мышка на прокрутку или нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollWiewers.ScrollWiewerContentScroll(sender,e);
        }
              
        /// <summary>
        /// Обновляет данные
        /// </summary>
        private void LoadData()
        {
            App.DataBase.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            listBook.ItemsSource = App.DataBase.Books.ToList().OrderBy(p => p.NameBook);

        }

        /// <summary>
        /// Меняет данные, в зависимости какой Item выбран 
        /// </summary>
        public void DateBook()
        {
            var date = App.DataBase.Books.ToList();

            if (cmBook.SelectedIndex == 1)
            {
                date = App.DataBase.Books.Where(p => p.IdBookLocation == 1).ToList();

            }

            if (cmBook.SelectedIndex == 0)
            {
                date = App.DataBase.Books.ToList();
            }

            if (cmBook.SelectedIndex == 2)
            {
                date = App.DataBase.Books.Where(p => p.IdBookLocation == 2).ToList();
            }

            listBook.ItemsSource = date.OrderBy(p => p.NameBook);
        }
   
        /// <summary>
        /// Поиск данных
        /// </summary>
        public void TextPoisck()
        {
            if (!string.IsNullOrEmpty(tbDafaultDate.Text))
            {
                try
                {
                    listBook.ItemsSource = App.DataBase.Books.ToList().Where(p => 

                    p.NameBook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.AuthorOfThebook.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower()) ||
                    p.YearOfPublication.ToString().ToLower().Contains(tbDafaultDate.Text.ToLower())).ToList();

                    var rows = listBook.ItemsSource.Cast<Book>().ToList();
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
        /// Если текстовое поле пустое, то возвращаются все данные в сходное положение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDafaultDate_TextChanged(object sender, TextChangedEventArgs e)
        {
          if(tbDafaultDate.Text == "")
          {
                DateBook();
                tbInfo.Visibility = Visibility.Collapsed;
          }
          else
          {

          }
        }

        /// <summary>
        /// Меняет данные у ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateBook();
        }

      
        /// <summary>
        /// Сортировка по предметам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmBookItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

     
        /// <summary>
        /// Кнопка обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApdate_Click(object sender, RoutedEventArgs e)
        {
            
            LoadData();
        }

       
    }
}
