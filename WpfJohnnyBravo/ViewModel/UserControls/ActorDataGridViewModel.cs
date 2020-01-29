using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfJohnnyBravo.Models;
using WpfJohnnyBravo.Service;
using WpfJohnnyBravo.ViewModel.Base;
using WpfJohnnyBravo.ViewModel.Models;

namespace WpfJohnnyBravo.ViewModel.UserControls
{
    public class ActorDataGridViewModel : BaseViewModel
    {
        public ObservableCollection<ActorViewModel> Actors { get; set; }

        public ICommand RemoveActorCommand => new RelayCommand<ActorViewModel>((actor =>
        {
            Actors.Remove(actor);

            new ActorService().Remove(actor.Id);
        }));

        public ActorDataGridViewModel()
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            Actors = new ObservableCollection<ActorViewModel>(new ActorService().GetAllActors().Select(x => new ActorViewModel(x.Id, x.Name, x.Age, x.AgencyId));

        }
    }
}
