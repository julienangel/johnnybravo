using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using WpfJohnnyBravo.ViewModel.Base;

namespace WpfJohnnyBravo.ViewModel.UserControls
{
    public class AgencyDataGridViewModel : BaseViewModel
    {
        public override ICommand AddNewCommand { get; set; } = new RelayCommand((() =>
        {
            Console.Write("");
        }));
        public new string Test { get; set; } = "Merda";

        public AgencyDataGridViewModel()
        {
            
        }
    }
}
