using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfJohnnyBravo.Models
{
    public class DataGridTab : ITab
    {
        public string Header { get; set; }
        public object Content { get; private set; }
        

        public DataGridTab()
        {
            
        }

        public void SetContent(object content)
        {
            Content = content;
        }
    }
}
