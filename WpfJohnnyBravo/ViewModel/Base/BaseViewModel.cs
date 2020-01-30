using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace WpfJohnnyBravo.ViewModel.Base
{
    public abstract class BaseViewModel : ViewModelBase , IChildGrid
    {
        public bool IsBusy { get; set; }

        public abstract ICommand AddNewCommand { get; set; }

        public string Test { get; }

        protected BaseViewModel()
        {
           
        }

        public virtual void Initialize()
        {

        }
    }

}
