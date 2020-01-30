using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using WpfJohnnyBravo.Locators;
using WpfJohnnyBravo.Models;
using WpfJohnnyBravo.Service;
using WpfJohnnyBravo.Service.Base;
using WpfJohnnyBravo.UserControls;
using WpfJohnnyBravo.ViewModel.Base;

namespace WpfJohnnyBravo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private readonly ActorService _actorService;

        public ObservableCollection<ITab> Tabs { get; set; } = new ObservableCollection<ITab>();
        public override ICommand AddNewCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public MainViewModel()
        {
            //_actorService = actorService;
        }

        public override void Initialize()
        {
            base.Initialize();

            TabLocator.RegisterTab(new DataGridTab() { Header = "Actor"}, typeof(ActorDataGrid));
            TabLocator.RegisterTab(new DataGridTab() { Header = "Agency" }, typeof(AgencyDataGrid));

            Tabs = new ObservableCollection<ITab>(TabLocator.GetTabs());
        }
    }
}