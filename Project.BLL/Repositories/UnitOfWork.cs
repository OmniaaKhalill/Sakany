
using Project.BLL.Interfaces;

namespace Project.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IApartmentRepo ApartmentRepo { get; set; }
        public IBuildingRepo BuildingRepo { get; set; }
        public IFloorRepo FloorRepo { get; set; }
        public IManagerRepo OwnerRepo { get; set; }
        public IRenterRepo RenterRepo { get; set; }
        public IRenterServiceRepo RenterServiceRepo { get; set; }
        public IRoomRepo RoomRepo { get; set; }
        public IServiceRepo ServiceRepo { get; set; }

        public UnitOfWork(IApartmentRepo apartmentRepo, IBuildingRepo buildingRepo, IFloorRepo floorRepo, IManagerRepo ownerRepo, IRenterRepo renterRepo, IRenterServiceRepo renterServiceRepo, IRoomRepo roomRepo, IServiceRepo serviceRepo)
        {
            ApartmentRepo = apartmentRepo;
            BuildingRepo = buildingRepo;
            FloorRepo = floorRepo;
            OwnerRepo = ownerRepo;
            RenterRepo = renterRepo;
            ServiceRepo = serviceRepo;
            RoomRepo = roomRepo;
            ServiceRepo = serviceRepo;
        }
    }
}
