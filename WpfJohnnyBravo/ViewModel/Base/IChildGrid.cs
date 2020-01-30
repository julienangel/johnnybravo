using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfJohnnyBravo.ViewModel.Base
{
    interface IChildGrid
    {
        ICommand AddNewCommand { get; }

        string Test { get; }
    }
}
