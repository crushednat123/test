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

namespace Library.UserControls
{
    /// <summary>
    /// Логика взаимодействия для InfoBook.xaml
    /// </summary>
    public partial class InfoBook : UserControl
    {
        public InfoBook()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Принимает описание карточки
        /// </summary>
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InfoBook));


        /// <summary>
        /// Принимает номер карточки
        /// </summary>

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(string), typeof(InfoBook));


        /// <summary>
        /// Принимает иконку карточки
        /// </summary>
        public FontAwesome.Sharp.IconChar Icon
        {
            get { return (FontAwesome.Sharp.IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(FontAwesome.Sharp.IconChar), typeof(InfoBook));



        /// <summary>
        /// Принимает цвет карточки карточки
        /// </summary>

        public Color Background1
        {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }

        public static readonly DependencyProperty Background1Property =
            DependencyProperty.Register("Background1", typeof(Color), typeof(InfoBook));


        /// <summary>
        /// Принимает цвет карточки карточки2
        /// </summary>

        public Color Background2
        {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }

        public static readonly DependencyProperty Background2Property =
            DependencyProperty.Register("Background2", typeof(Color), typeof(InfoBook));


        /// <summary>
        /// Принимает цвет эллипса1 
        /// </summary>

        public Color EllipsBackground1
        {
            get { return (Color)GetValue(EllipsBackground1Property); }
            set { SetValue(EllipsBackground1Property, value); }
        }

        public static readonly DependencyProperty EllipsBackground1Property =
            DependencyProperty.Register("EllipsBackground1", typeof(Color), typeof(InfoBook));




        /// <summary>
        /// Принимает цвет эллипса2 
        /// </summary>

        public Color EllipsBackground2
        {
            get { return (Color)GetValue(EllipsBackground2Property); }
            set { SetValue(EllipsBackground2Property, value); }
        }

        public static readonly DependencyProperty EllipsBackground2Property =
            DependencyProperty.Register("EllipsBackground2", typeof(Color), typeof(InfoBook));



        /// <summary>
        /// Принимает отступы текста
        /// </summary>

        public string MarginText
        {
            get { return (string)GetValue(MarginTextProperty); }
            set { SetValue(MarginTextProperty, value); }
        }

        public static readonly DependencyProperty MarginTextProperty =
            DependencyProperty.Register("MarginText", typeof(string), typeof(InfoBook));


    }
}
