using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfJohnnyBravo.Models;

namespace WpfJohnnyBravo.Locators
{
    public static class TabLocator
    {
        public static Dictionary<ITab, UserControl> TabsDic = new Dictionary<ITab, UserControl>();

        public static void RegisterTab(ITab tab, Type userControl)
        {
            var uc = (UserControl)Activator.CreateInstance(userControl);
            tab.SetContent(uc);
            TabsDic.Add(tab, uc);
        }

        public static IEnumerable<ITab> GetTabs()
        {
            return TabsDic.Keys.ToList();
        }
    }
}
