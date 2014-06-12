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
using Nigga.Tools;




namespace Nigga
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public static RoutedCommand MyCommand = new RoutedCommand();
        private bool _canExecute = true;
        private TabSelector selector;

        public MainWindow()
        {
            InitializeComponent();

            selector = new TabSelector(tabs);

            editSpace.Visibility = System.Windows.Visibility.Hidden;

            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            CommandBinding cb = new CommandBinding(MyCommand, SelectAllExecute, SelectAllCanExecute);
            KeyGesture gest = new KeyGesture(Key.A, ModifierKeys.Control);
            InputBinding ib = new InputBinding(MyCommand, gest);
            this.InputBindings.Add(ib);

            editSpace.Document = new FlowDocument();
            
            editSpace.SelectAll();
            editSpace.Selection.Text = "";
            
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

                selector.GetCurrentSelection().Header = dlg.SafeFileName.Split('.')[0];
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
                selector.CreateAndSelectNewTab(dlg.SafeFileName.Split('.')[0]);
            }

        }


        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (editSpace.Visibility == System.Windows.Visibility.Hidden)
                editSpace.Visibility = System.Windows.Visibility.Visible;

            EnhancedTabItem newOne;
            
            if(App.NewCounter == 0)
            {
                newOne = selector.CreateAndSelectNewTab("New");
            }
            else
                newOne = selector.CreateAndSelectNewTab(String.Format("New ({0})", App.NewCounter));


            App.NewCounter++;

            editSpace.Document = newOne.CurrentDocument;
            
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

        private void aboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow f = new Nigga.AboutWindow();
            f.ShowDialog();
        }

        private void SelectAllCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SelectAllExecute(object sender, ExecutedRoutedEventArgs e)
        {
            TextRange tx = new TextRange(editSpace.Document.ContentStart, editSpace.Document.ContentEnd);
            TextPointer ending = tx.End.GetPositionAtOffset(-1, LogicalDirection.Forward);
            editSpace.Selection.Select(editSpace.Document.ContentStart, ending);
            _canExecute = !_canExecute;
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
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
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

        private void replaceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Replace  d = new Nigga.Replace();
            d.ShowDialog();
        }

        private void ScrollEvent(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            //tutaj trzeba napisac scrollowanie
        }

        private void editSpace_Initialized(object sender, EventArgs e)
        {
            editSpace.SelectAll();
            editSpace.Selection.Text = "";
            
        }

        private void tabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl source = (TabControl)e.Source;
            EnhancedTabItem selected = (EnhancedTabItem)source.SelectedItem;
            editSpace.Document = selected.CurrentDocument;
        }

        private void CloseTab_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void FindMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //tutaj postaram sie napisac FIND

            FindWindow a = new Nigga.FindWindow();
            a.ShowDialog();
        }







    }
}