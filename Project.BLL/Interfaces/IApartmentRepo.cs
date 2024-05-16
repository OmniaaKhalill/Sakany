using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    public interface IApartmentRepo: IGenericRepo<Apartment>
    {
        public IEnumerable<Apartment> Rented();
        public IEnumerable<Apartment> Available();
    }
}
