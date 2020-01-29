using WpfJohnnyBravo.Models.Base;

namespace WpfJohnnyBravo.Models
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public int AgencyId { get; set; }        

        public Actor(string name, string age, int agencyId)
        {
            Name = name;
            Age = age;
            AgencyId = agencyId;
        }
    }
}
