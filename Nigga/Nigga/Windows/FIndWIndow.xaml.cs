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

namespace Nigga
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FindWindow : Window
    {
        bool check;
        public FindWindow()
        {
            InitializeComponent();
            check = false;

        }

        private void FindInTextCheck(object sender, RoutedEventArgs e)
        {
            check = true;
        }

        private void FindNextInText_Click(object sender, RoutedEventArgs e)
        {
            if (!check)
            {
                //nie patrząc na rozmiar liter
            }
            else
            {
                //patrzac na rozmiar liter
            }
        }

        private void FindText_EnterClick(object sender, TouchEventArgs e)
        {
            //jesli wcisniety ENTER
        }
    }
}
