using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfJohnnyBravo.ViewModel;
using WpfJohnnyBravo.ViewModel.Base;

namespace WpfJohnnyBravo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();            
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ((BaseViewModel)((MainWindow)sender).DataContext).IsBusy = true;
            ((BaseViewModel)((MainWindow)sender).DataContext).Initialize();
            ((BaseViewModel)((MainWindow)sender).DataContext).IsBusy = false;
        }       
    }
}
