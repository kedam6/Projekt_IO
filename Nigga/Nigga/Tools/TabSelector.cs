using System.Windows.Controls;
using System.Windows.Documents;

namespace Nigga.Tools
{
    public class TabSelector
    {
        public TabControl Container {get; set;}

        public TabSelector(TabControl content = null)
        {
            Container = content;
        }

        public Nigga.Tools.EnhancedTabItem GetCurrentSelection()
        {
            if (Container == null)
                return null;

            Nigga.Tools.EnhancedTabItem selected = (Nigga.Tools.EnhancedTabItem)Container.SelectedItem;

            return selected;
        }

        public EnhancedTabItem CreateAndSelectNewTab(string name)
        {
            EnhancedTabItem newOne = new EnhancedTabItem();
            newOne.CurrentDocument = new FlowDocument();
            newOne.Header = name;
            Container.Items.Add(newOne);
            newOne.Focus();
            return newOne;
        }
    }
}
