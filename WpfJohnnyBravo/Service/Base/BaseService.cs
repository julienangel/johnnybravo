using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using WpfJohnnyBravo.Models.Base;

namespace WpfJohnnyBravo.Service.Base
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        public virtual void Add(BaseEntity baseEntity)
        {
            //perform add db operation
            //insert into table
        }

        public virtual void Remove(BaseEntity baseEntity)
        {
            //perform add db operation
            //
        }

        public virtual void Update()
        {
            //update set 
        }

        public virtual IEnumerable<T> GetAll()
        {
           return new List<T>();
        }
    }
}
