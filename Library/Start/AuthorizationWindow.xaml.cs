using Library.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using Library.Pages.PageStudent;
using Library.Pages.PageTeacher;
using Library.Pages.PageAdmin;
using Library.Entities;
using Library.Pages.PageLibrarian;

namespace Library.Start
{


    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Перемещает окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            FocusFalse();
        }


        /// <summary>
        ///  Меняет цвет иконок при переключении фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBPassword_GotMouseCapture(object sender, MouseEventArgs e)
        {
            iconPassword.Foreground = Brushes.Blue;
            iconLogin.Foreground = Brushes.Gray;
        }

        /// <summary>
        /// Меняет цвет иконок при переключении фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBPassword_GotMouseCapture(object sender, MouseEventArgs e)
        {
            iconPassword.Foreground = Brushes.Blue;
            iconLogin.Foreground = Brushes.Gray;
        }

        /// <summary>
        ///  Меняет цвет иконок при переключении фокуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBLogin_GotMouseCapture(object sender, MouseEventArgs e)
        {
            iconLogin.Foreground = Brushes.Blue;
            iconPassword.Foreground = Brushes.Gray;
        }


        /// <summary>
        /// Сбрасывает фокус и цвет иконок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FocusFalse();
        }


        /// <summary>
        /// Задаёт стандартный цвет иконок
        /// </summary>
        public void ForegroundIcon()
        {
            iconLogin.Foreground = Brushes.Gray;
            iconPassword.Foreground = Brushes.Gray;
        }

        /// <summary>
        /// Меняет цвет иконок, также убирает фокус с текстовых полей
        /// </summary>
        public void FocusFalse()
        {
            border.Focus();
            ForegroundIcon();
        }


        /// <summary>
        /// Скрывает или отображает PasswordBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(pBPassword.Password.Length == 0)
            {
                checkPassword.IsEnabled = false;
               
            }
            else
            {
                checkPassword.IsEnabled = true;                              

                if (pBPassword.Password.Length == 0)
                {
                     textBlockPassword.Visibility = Visibility.Visible;
                }

               else if (pBPassword.Password.Length != 0)
               {
                    textBlockPassword.Visibility = Visibility.Collapsed;
               }              

                pasText.Text = pBPassword.Password.Length.ToString(CultureInfo.InvariantCulture);

            }

            TextColors.ElementColor(pasText, text);
        }


        /// <summary>
        /// Кнопка закрыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Logic.MessagesInfo.MessagesExit();
            FocusFalse();
        }



        /// <summary>
        /// Скрывает и отображает пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkPassword_Click(object sender, RoutedEventArgs e)
        {
           
            FocusFalse();

            if (checkPassword.IsChecked == false)
            {
                pBPassword.Visibility = Visibility.Visible;
                tBPassword.Visibility = Visibility.Collapsed;
                checkPassword.Content = "Показать пароль";
                pBPassword.Password = tBPassword.Text;
               
            }

            else
            {
                pBPassword.Visibility = Visibility.Collapsed;                
                tBPassword.Visibility = Visibility.Visible;
                checkPassword.Content = "Скрыть пароль";
                tBPassword.Text = pBPassword.Password;
                
            }
        }


        /// <summary>
        /// Скрывает или отображает текстовое поле с паролем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            if (tBPassword.Text.Length == 0)
                textBlockPassword.Visibility = Visibility.Visible;

            else if (tBPassword.Text.Length != 0)
                textBlockPassword.Visibility = Visibility.Collapsed;

            pasText.Text = tBPassword.Text.Length.ToString(CultureInfo.InvariantCulture);

            TextColors.ElementColor(pasText, text);
        }
        

        
        /// <summary>
        /// Кнопка войти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
            FocusFalse();


           
            StartSchoolboy startSchoolboy = new StartSchoolboy();
            TeacherStart teacherStart =  new TeacherStart();
            AdminStart admin = new AdminStart();
            LibrarianStart librarian = new LibrarianStart();



            if (tBLogin.Text.Length == 0 || pBPassword.Password.Length == 0)
            {
                MessagesInfo.Length(tBLogin, pBPassword);
            }
            else
            {               
                try
                {

                    if (checkPassword.IsChecked == true)
                    {
                        pBPassword.Password = tBPassword.Text;
                    }


                    ///Авторизация
                    var user = App.DataBase.Users.Where(p =>
                    p.Login == tBLogin.Text && p.Password == pBPassword.Password).FirstOrDefault();

                    if (user != null)
                    {                        

                        if (user.IdRole == 3)
                        {
                            //заполнение полей
                            if(user.Teacher.IdCenders == 1)
                            {
                                DateUser.IdCinderCode = "Учитель";
                            }
                            else if (user.Teacher.IdCenders == 2)
                            {
                                DateUser.IdCinderCode = "Учительница";
                            }

                            DateUser.Name = user.Teacher.Name;
                            DateUser.SurName = user.Teacher.SurName;
                           

                            DateUser.Id = Convert.ToString(user.IdTeachers);


                            //Информация кто вошёл
                            MessagesInfo.Teacher();


                            window.Visibility = Visibility.Collapsed;
                           

                            teacherStart.Show();
                            
                        }

                        if (user.IdRole == 4)
                        {
                            //заполнение полей

                            if (user.SchoolBoy.IdCenders == 1)
                            {
                                DateUser.IdCinderCode = "Ученик";
                            }
                            else if (user.SchoolBoy.IdCenders == 2)
                            {
                                DateUser.IdCinderCode = "Ученица";
                            }

                            DateUser.Name = user.SchoolBoy.Name;
                            DateUser.SurName = user.SchoolBoy.SurName;

                            DateUser.Id = Convert.ToString(user.IdSchool);

                           

                            //Информация кто вошёл
                            MessagesInfo.SchoolBoy();


                            window.Visibility = Visibility.Collapsed;
                            startSchoolboy.Show();
                            
                        }

                        if (user.IdRole == 1)
                        {
                            window.Visibility = Visibility.Collapsed;
                            admin.Show();
                            MessagesInfo.Admin();
                        }

                        if(user.IdRole == 2)
                        {
                            window.Visibility = Visibility.Collapsed;
                            librarian.Show();
                            MessagesInfo.Librarian();
                        }

                    }

                    else
                    {
                        MessagesInfo.UserError();
                    }
                }
                catch
                {

                    MessagesInfo.ErrorServer();
                }
            
            }
        }
    }
    
}
