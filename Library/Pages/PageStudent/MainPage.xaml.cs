using Library.Logic;
using Library.Pages.PageStudent.Pages;
using Library.Start;
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
using Library.Pages.PageStudent;

namespace Library.Pages.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из учётной записи?", "Информация",

            MessageBoxButton.YesNo,
            MessageBoxImage.Question);

            foreach (Window window in App.Current.Windows)
            {
                if (result == MessageBoxResult.Yes)
                {
                    if (window is StartSchoolboy)
                    {
                        window.Visibility = Visibility.Collapsed;
                        AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                        authorizationWindow.Show();
                        break;
                    }
                }
                else
                {

                }                         
            }
        }

        private void btnBookMe_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new MyBookPage());                   
        }

        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.Navigate(new BookPage());
        }
    }
}

