using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Nigga.Tools
{
    public class TextSelector
    {
        private RichTextBox _textArea;

        public TextSelector(RichTextBox param1)
        {
            _textArea = param1;
        }

        public TextSelection GetFullText()
        {
            _textArea.SelectAll();
            return _textArea.Selection;
        }
    }
}
