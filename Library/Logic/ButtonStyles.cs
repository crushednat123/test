using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Library.Logic
{
    public class ButtonStyles
    {
        public static void StyleButton(Button button1, Button button2, Button button3, Button button4)
        {

            button1.Style = (Style)button1.FindResource("btnMenuActive");

            button2.Style = (Style)button1.FindResource("btnMenu");
                                                         
            button3.Style = (Style)button1.FindResource("btnMenu");
                                                         
            button4.Style = (Style)button1.FindResource("btnMenu");
                                                                   
        }
    }
}
