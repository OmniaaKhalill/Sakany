using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    public interface IUnitOfWork
    {
        public IApartmentRepo ApartmentRepo { get; set; }
        public IBuildingRepo BuildingRepo { get; set; }
        public IFloorRepo FloorRepo { get; set; }
        public IManagerRepo ManagerRepo { get; set; }
        public IRenterRepo RenterRepo { get; set; }
        public IRenterServiceRepo RenterServiceRepo { get; set; }
        public IRoomRepo RoomRepo { get; set; }   
        public IServiceRepo ServiceRepo { get; set; }
    }
}
