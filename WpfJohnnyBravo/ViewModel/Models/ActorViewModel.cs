using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfJohnnyBravo.ViewModel.Models
{
    public class ActorViewModel : ViewModelBase
    {
        public int Id { get; }
        public string Name { get; set; }

        public string Age { get; set; }

        public int AgencyId { get; set; }

        public ActorViewModel(int id, string name, string age, int agencyId)
        {
            Id = id;
            Name = name;
            Age = age;
            AgencyId = agencyId;
        }
    }
}
