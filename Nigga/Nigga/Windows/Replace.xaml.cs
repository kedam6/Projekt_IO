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
    /// Interaction logic for Replace.xaml
    /// </summary>
    public partial class Replace : Window
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void FindItem_Click(object sender, RoutedEventArgs e)
        {
            if (!HereIsText.Text.Equals("Text"))
            {
                HereIsText.Text = "OK";
                //Potrzebuje sie odwolac do editSpace w MainWindow. 
                
            }
        }
    }
}
