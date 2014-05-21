using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

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
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(editSpace.Document.ContentStart, editSpace.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }

        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(editSpace.Document.ContentStart, editSpace.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }

        }


        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            editSpace.Document = new FlowDocument();
        }

        private void editSpace_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = editSpace.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = editSpace.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = editSpace.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = editSpace.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = editSpace.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();

        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                editSpace.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);

        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            editSpace.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void editSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void editSpace_GotFocus(object sender, RoutedEventArgs e)
        {
            int test;
            if (cmbFontFamily.SelectedItem != null && Int32.TryParse(cmbFontSize.Text, out test))
            {
                //
            }
        }

        private void aboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Nigga.AboutWindow f = new Nigga.AboutWindow();
            f.ShowDialog();
        }



        private void SelectAllTextMenuIte_Click(object sender, RoutedEventArgs e)
        {


            editSpace.SelectAll();

        }

        private void cutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (editSpace.Selection.Text != "")
                editSpace.Cut();
        }

        private void copyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (editSpace.Selection.Text.Length > 0)
                editSpace.Copy();
        }

        private void pasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                editSpace.Paste();
            }
        }

        private void undoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (editSpace.CanUndo == true)
            {
                editSpace.Undo();
            }
        }





    }
}