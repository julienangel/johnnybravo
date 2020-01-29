using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfJohnnyBravo.ViewModel.Base
{
    public class BaseViewModel : ViewModelBase
    {
        public bool IsBusy { get; set; }

        public BaseViewModel()
        {
           
        }

        public virtual void Initialize()
        {

        }
    }

}
