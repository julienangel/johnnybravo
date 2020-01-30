using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WpfJohnnyBravo.ViewModel.Base;

namespace WpfJohnnyBravo.ViewModel.UserControls
{
    public class TemplateDataGridViewModel : ViewModelBase, IChildGrid
    {
        public TemplateDataGridViewModel()
        {
            
        }

        public ICommand AddNewCommand => new RelayCommand<object>((o => ((IChildGrid)((UserControl)o).DataContext).AddNewCommand.Execute(o)));
        public string Test { get; } 
    }
}
