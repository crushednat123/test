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
using Library.Logic;
using Library.Pages.PageStudent.Pages;
using Library.Start;

namespace Library.Pages.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для StartSchoolboy.xaml
    /// </summary>
    public partial class StartSchoolboy : Window
    {

        public StartSchoolboy()
        {
            InitializeComponent();
            NavigationManager.StartFrame = startFrame;
            startFrame.Navigate(new MainPage());
        }
        private void startFrame_ContentRendered(object sender, EventArgs e)
        {
            if (startFrame.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }

            else
            {
                btnBack.Visibility = Visibility.Collapsed;
            }

            if (startFrame.Content.GetType().Name == "MainPage")
            {
                ButtonStyles.StyleButton(btnMain, btnMyBooks, btnBooks, btnExitZapic);
            }

            if (startFrame.Content.GetType().Name == "MyBookPage")
            {
                ButtonStyles.StyleButton(btnMyBooks, btnMain, btnBooks, btnExitZapic);
            }

            if (startFrame.Content.GetType().Name == "BookPage")
            {
                ButtonStyles.StyleButton(btnBooks, btnMyBooks, btnMain, btnExitZapic);
            }
        }

        /// <summary>
        /// Позволяет двигать окно по экрану
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
               DragMove();
        }

        /// <summary>
        /// Кнопка выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessagesInfo.MessagesExit();
        }

        /// <summary>
        /// Кнопка расширить или уменьшить окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpand_Click(object sender, RoutedEventArgs e)
        {
            if (startWindow.WindowState == WindowState.Normal)
            {
                startWindow.WindowState = WindowState.Maximized;
                iconExpand.Icon = FontAwesome.Sharp.IconChar.WindowRestore;
                btnExpand.ToolTip = "Свернуть в окно";                
            }

            else if (startWindow.WindowState == WindowState.Maximized)
            {
                startWindow.WindowState = WindowState.Normal;
                iconExpand.Icon = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
                btnExpand.ToolTip = "Развернуть";
            }
        }

        /// <summary>
        /// Кнопка свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRollUp_Click(object sender, RoutedEventArgs e)
        {
            startWindow.WindowState = WindowState.Minimized;
        }

        public void btnExitZapic_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из учётной записи?", "Информация",

            MessageBoxButton.YesNo,
            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {              
                startWindow.Visibility = Visibility.Collapsed;

                AuthorizationWindow authorization = new AuthorizationWindow();
                authorization.Show();
            }
            else
            {

            }
        }

        private void startWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            NameAndSyrName.Text = DateUser.Name + " " + DateUser.SurName;
            tbRole.Text = DateUser.IdCinderCode;
            Char1NameAndSurName.Text = DateUser.Name.Substring(0, 1) + DateUser.SurName.Substring(0, 1);
            
        }
         
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.StartFrame.GoBack();
        }


        /// <summary>
        /// Кнопка открывает мои книги выданные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyBooks_Click(object sender, RoutedEventArgs e)
        {
            startFrame.Navigate(new MyBookPage());          
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {          
            startFrame.Navigate(new MainPage());
        }

        private void btnBooks_Click(object sender, RoutedEventArgs e)
        {           
            startFrame.Navigate(new BookPage());
        }

    }
}
