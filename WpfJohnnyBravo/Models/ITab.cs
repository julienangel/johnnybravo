using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfJohnnyBravo.Models
{
    public interface ITab
    {
        string Header { get; set; }

        object Content { get; }

        void SetContent(object content);
    }
}
