using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfJohnnyBravo.Models;
using WpfJohnnyBravo.Models.Base;
using WpfJohnnyBravo.Service.Base;

namespace WpfJohnnyBravo.Service
{
    public class ActorService : BaseService<Actor>
    {
        public ActorService()
        {
            
        }

        public override IEnumerable<Actor> GetAll()
        {
            return base.GetAll();
        }

        public IEnumerable<Actor> GetAllActors()
        {
            //get all from dataase

            var listActors = new List<Actor>()
            {
                new Actor("Nome1", "dsa", 1),
                new Actor("Nome1", "dsa", 1),
                new Actor("Nome1", "dsa", 1),
                new Actor("Nome1", "dsa", 1)
            };            

            return listActors;
        }

        public IEnumerable<Actor> GetAllActorsByAngency(int agencyId)
        {
            //get all from dataase

            return new List<Actor>() { };
        }

        public Agency GetAgency(int agencyId)
        {
            //get all from dataase

            return new Agency();
        }

    }
}
