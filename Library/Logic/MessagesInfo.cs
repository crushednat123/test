using Library.Pages.PageStudent;
using Library.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Logic
{
    public class MessagesInfo
    {

        public static void Length(TextBox textBox, PasswordBox passwordBox)
        {
            if (textBox.Text.Length == 0 && passwordBox.Password.Length == 0)
            {
                MessageBox.Show("Вы не ввели логин и пароль.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if (textBox.Text.Length == 0 && passwordBox.Password.Length != 0)
            {
                MessageBox.Show("Вы не ввели логин.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if (textBox.Text.Length != 0 && passwordBox.Password.Length == 0)
            {
                MessageBox.Show("Вы не ввели пароль.", "Информация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        public static void MessagesExit()
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите выйти из программы?", "Информация",

            MessageBoxButton.YesNo,
            MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }      

        public static void ErrorServer()
        {
            MessageBox.Show("Ошибка подключение к серверу.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ErrorServerOrDocymentError()
        {
            MessageBox.Show("Ошибка подключение к серверу или документ повреждён.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void LoginNull()
        {
            MessageBox.Show("Поле с логином не заполнено.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void PasswordNull()
        {
            MessageBox.Show("Поле с паролем не заполнено.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }       

        public static void UserError()
        {
            MessageBox.Show("Не правильный логин или пароль.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void SchoolBoy()
        {
            MessageBox.Show("Вы вошли как - ученик.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Teacher()
        {
            MessageBox.Show("Вы вошли как - учитель.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Librarian()
        {
            MessageBox.Show("Вы вошли как - библиотекарь.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Admin()
        {
            MessageBox.Show("Вы вошли как - администратор.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void DocymentError()
        {
            MessageBox.Show("Данный документ повреждён.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
