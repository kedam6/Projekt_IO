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
using Nigga.Tools;

namespace Nigga
{
    /// <summary>
    /// Interaction logic for Replace.xaml
    /// </summary>
    public partial class Replace : Window
    {
        private RichTextBox _textBox;
        private TextSelector _selector;

        public Replace(RichTextBox text)
        {
            InitializeComponent();
            _textBox = text;
            _selector = new TextSelector(text); 
        }

        private void FindItem_Click(object sender, RoutedEventArgs e)
        {
            int count = 0, n = 0;

            while ((n = _selector.GetFullText().Text.IndexOf(HereIsText.Text, n, StringComparison.InvariantCulture)) != -1)
            {
                n += HereIsText.Text.Length;
                ++count;
            }

            Finds.Text = count.ToString();

            switch(MessageBox.Show("Do you want to replace this item?", "Question", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation, MessageBoxResult.Cancel))
            {
                case MessageBoxResult.Yes:
                    _selector.GetFullText().Text = _selector.GetFullText().Text.Replace(HereIsText.Text, TextToReplace.Text);
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    this.Close();
                    break;

            }
        }
    }
}
