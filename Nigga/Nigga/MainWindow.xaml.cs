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

namespace IO_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".text"; // Default file extension
            dlg.Filter = "Text document (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                System.IO.File.WriteAllText(dlg.FileName, editSpace.Text);
            }
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Example";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text document (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == true)
            {
                editSpace.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void aboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Nigga.AboutWindow aboutWin = new Nigga.AboutWindow();
            aboutWin.ShowDialog();
        }

        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            editSpace.Text = "";
        }
    }
}